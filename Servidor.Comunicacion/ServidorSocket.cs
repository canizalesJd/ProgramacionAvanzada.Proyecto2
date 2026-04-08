/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Servidor.Comunicacion
{
    // Clase para almacenar información de cada cliente conectado
    public class InfoCliente
    {
        // Propiedades
        public TcpClient Conexion { get; set; }
        public string Nombre { get; set; }

        // Constructor
        public InfoCliente(TcpClient conexion, string nombre) { 
            Conexion = conexion;
            Nombre = nombre;
        }

    }

    public class ServidorSocket
    {
        // Configuracion Servidor
        private const string IP_SERVIDOR = "127.0.0.1"; // LOCALHOST
        private const int PUERTO_SERVIDOR = 5000;
        private const int MAX_CLIENTES = 5;

        // Atributos
        private TcpListener? servidor; // ?: nullable
        private Thread? hiloEscucha;
        private bool servidorActivo = false;
        private List<InfoCliente> clientesConectados = new List<InfoCliente>();

        // Eventos
        public event Action<string>? NuevaBitacora;
        public event Action<string>? ClienteConectado;
        public event Action<string>? ClienteDesconectado;

        // Constructor
        public ServidorSocket()
        {
            clientesConectados = new List<InfoCliente>();
        }

        // Metodo para iniciar el servidor
        public void Iniciar()
        {
            try
            {
                // Crear el servidor TCP
                servidor = new TcpListener(IPAddress.Parse(IP_SERVIDOR), PUERTO_SERVIDOR);
                servidor.Start(); // Iniciar el servidor
                servidorActivo = true;
                // Notificar que el servidor ha iniciado
                NuevaBitacora?.Invoke($"Servidor iniciado en {IP_SERVIDOR}:{PUERTO_SERVIDOR}");
                NuevaBitacora?.Invoke($"Máximo de clientes: {MAX_CLIENTES}");

                // Iniciar el hilo de escucha para aceptar clientes
                hiloEscucha = new Thread(EscucharConexiones);
                hiloEscucha.IsBackground = true; // Ejecutarse en segundo plano
                hiloEscucha.Start(); // Iniciar el hilo de escucha
            }
            catch (Exception ex)
            {
                NuevaBitacora?.Invoke($"Error al iniciar el servidor: {ex.Message}");
            }
        }

        // Metodo para escuchar conexiones entrantes
        public void EscucharConexiones()
        {
            while (servidorActivo)
            {
                try
                {
                    // Aceptar una nueva conexión
                    TcpClient cliente = servidor!.AcceptTcpClient();
                    // Verificar si se ha alcanzado el límite de clientes
                    if (clientesConectados.Count >= MAX_CLIENTES)
                    {
                        NuevaBitacora?.Invoke($"Conexión rechazada, límite de clientes alcanzado."); // Notificar
                        cliente.Close(); // Cerrar la conexión del cliente rechazado
                        continue; // Continuar esperando nuevas conexiones
                    }
                    // Iniciar un hilo para manejar la comunicación con este cliente
                    Thread hiloCliente = new Thread(() => AtenderCliente(cliente));
                    hiloCliente.IsBackground = true; // Ejecutarse en segundo plano
                    hiloCliente.Start(); // Iniciar el hilo del cliente
                }
                catch (Exception ex)
                {
                    NuevaBitacora?.Invoke($"Error al aceptar conexiones: {ex.Message}");
                }
            }

        }

        // Metodo para atender la comunicación con un cliente específico
        public void AtenderCliente(TcpClient cliente)
        {
            // Inicializar variables para manejar la comunicación con el cliente
            NetworkStream? stream = null;
            string nombreCliente = "Desconocido";
            InfoCliente? infoCliente = null;
            try
            {
                // Obtener el stream de comunicación con el cliente
                stream = cliente.GetStream();
                // Lector y escritor para la comunicación con el cliente
                using StreamReader reader = new(stream, Encoding.UTF8, leaveOpen: true);
                using StreamWriter writer = new(stream, Encoding.UTF8, leaveOpen: true);

                // PASO 1: Recibir el mensaje de bienvenida con el nombre del cliente
                string? mensajeBienvenidaJson = reader.ReadLine(); // Leer el mensaje de bienvenida (JSON)
                if (!string.IsNullOrEmpty(mensajeBienvenidaJson))
                {
                    Mensaje? mensajeBienvenida = JsonConvert.DeserializeObject<Mensaje>(mensajeBienvenidaJson); // Deserializar el mensaje de bienvenida

                    if (mensajeBienvenida != null && mensajeBienvenida.Accion == "CONECTAR")
                    {
                        nombreCliente = mensajeBienvenida.Datos; // Obtener el nombre del cliente desde el mensaje de bienvenida

                        // Crear un objeto InfoCliente para almacenar la información del cliente conectado
                        infoCliente = new InfoCliente(cliente, nombreCliente);
                        clientesConectados.Add(infoCliente); // Agregar el cliente a la lista de clientes conectados

                        // Notificar que un nuevo cliente se ha conectado
                        NuevaBitacora?.Invoke($"Cliente conectado: {nombreCliente}. Total: {clientesConectados.Count} de {MAX_CLIENTES}"); // Notificar en la bitácora
                        ClienteConectado?.Invoke(nombreCliente); // Notificar a la interfaz de usuario

                        // Enviar un mensaje de bienvenida al cliente
                        Mensaje respuestaBienvenida = new("OK", "Conexion", $"Bienvenido, {nombreCliente}");
                        string respuestaJson = JsonConvert.SerializeObject(respuestaBienvenida); // Serializar el mensaje de bienvenida
                        writer.WriteLine(respuestaJson);
                        writer.Flush(); // Asegurar que el mensaje se envíe al cliente
                    }
                }

                // PASO 2: Ciclo de peticiones normales
                while (cliente.Connected && servidorActivo)
                {
                    string? mensajeJson = reader.ReadLine(); // Leer un mensaje del cliente (JSON)

                    if (string.IsNullOrEmpty(mensajeJson))
                        break; // Si el mensaje es nulo o vacío, salir del ciclo (cliente desconectado)

                    NuevaBitacora?.Invoke($"Mensaje recibido de {nombreCliente}: {mensajeJson}"); // Notificar el mensaje recibido en la bitácora
                    Mensaje? mensaje = JsonConvert.DeserializeObject<Mensaje>(mensajeJson); // Deserializar el mensaje recibido

                    if (mensaje != null)
                    {
                        Mensaje respuesta = ProcesarMensaje(mensaje);
                        string respuestaJson = JsonConvert.SerializeObject(respuesta); // Serializar la respuesta
                        writer.WriteLine(respuestaJson); // Enviar la respuesta al cliente
                        writer.Flush(); // Asegurar que la respuesta se envíe al cliente
                        NuevaBitacora?.Invoke($"Respuesta enviada a {nombreCliente}: {respuesta.Accion}"); // Notificar la respuesta enviada en la bitácora
                    }
                }

            }
            catch (Exception ex)
            {
                NuevaBitacora?.Invoke($"Error en la comunicación con {nombreCliente}: {ex.Message}");
            }
            finally
            {
                // Remover lista y cerrar
                if (infoCliente != null)
                {
                    clientesConectados.Remove(infoCliente); // Remover el cliente de la lista de clientes conectados
                    NuevaBitacora?.Invoke($"Cliente desconectado: {nombreCliente}. Total: {clientesConectados.Count} de {MAX_CLIENTES}"); // Notificar que el cliente se ha desconectado
                    ClienteDesconectado?.Invoke(nombreCliente); // Notificar a la interfaz de usuario
                }

                cliente.Close(); // Cerrar la conexión con el cliente
                NuevaBitacora?.Invoke($"Conexión cerrada con {nombreCliente}"); // Notificar que la conexión con el cliente se ha cerrado
                ClienteConectado?.Invoke(nombreCliente); // Notificar a la interfaz de usuario que el cliente se ha desconectado
            }
        }

        // Metodo para procesar un mensaje recibido del cliente y generar una respuesta
        public Mensaje ProcesarMensaje(Mensaje mensaje)
        {
            Mensaje respuesta = new();

            try
            {
                switch (mensaje.Accion)
                {
                    case "PING":
                        return new Mensaje("PONG", "RESPUESTA", "OK");

                    default:
                        return new Mensaje("ERROR", "RESPUESTA", "Acción no reconocida");
                }
            }
            catch (Exception ex)
            {
                return new Mensaje("ERROR", "RESPUESTA", $"Error al procesar el mensaje: {ex.Message}");
            }
        }

        // Metodo para detener el servidor
        public void Detener()
        {
            try
            {
                servidorActivo = false; // Detener el ciclo de escucha
                foreach (InfoCliente info in clientesConectados)
                {
                    info.Conexion.Close(); // Cerrar la conexión de cada cliente conectado
                }
                servidor?.Stop(); // Detener el servidor TCP
                NuevaBitacora?.Invoke("Servidor detenido."); // Notificar que el servidor se ha detenido
            }
            catch (Exception ex)
            {
                NuevaBitacora?.Invoke($"Error al detener el servidor: {ex.Message}");
            }
        }

        // ========================================================
        //                  METODOS INFORMATIVOS
        // ========================================================

        public int ObtenerCantidadClientes()
        {
            return clientesConectados.Count; // Retornar la cantidad de clientes conectados
        }

        // Metodo para obtener la IP del servidor
        public string ObtenerIP() => IP_SERVIDOR; // Retornar la IP del servidor
        // Metodo para obtener el puerto del servidor
        public int ObtenerPuerto() => PUERTO_SERVIDOR; // Retornar el puerto del servidor
        // Metodo para obtener el máximo de clientes permitidos
        public int ObtenerMaxClientes() => MAX_CLIENTES; // Retornar el máximo de clientes permitidos
    }
}
