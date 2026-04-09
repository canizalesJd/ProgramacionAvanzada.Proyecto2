/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.Text;
using CapaEntidades;


namespace Cliente.Comunicacion
{
    public class ClienteSocket
    {
        // Constantes
        private const int PUERTO_SERVIDOR = 5000;
        private const string IP_SERVIDOR = "127.0.0.1"; // LOCALHOST

        // Variables de instancia
        private TcpClient? cliente;
        private NetworkStream? stream;
        private StreamReader? reader;
        private StreamWriter? writer;
        private bool conectado = false;

        // Propiedades publicas
        public bool EstaConectado
        {
            get { return conectado; }
        }

        public string NombreCliente { get; private set; } = string.Empty;

        // Constructor
        public ClienteSocket()
        {
        }

        // Metodo para conectar al servidor
        public bool Conectar(string identificacion)
        {
            try
            {
                // Crear el TcpClient y conectarse al servidor
                cliente = new TcpClient();
                cliente.Connect(IPAddress.Parse(IP_SERVIDOR), PUERTO_SERVIDOR);

                // Obtener el stream de comunicación
                stream = cliente.GetStream();

                // Crear reader y writer para enviar y recibir datos
                reader = new StreamReader(stream, Encoding.UTF8);
                writer = new StreamWriter(stream, Encoding.UTF8);

                // Enviar identificacion al servidor (mensaje de bienvenida)
                Mensaje mensajeBienvenida = new("CONECTAR", "Cliente", identificacion);
                string bienvenidaJson = JsonConvert.SerializeObject(mensajeBienvenida);
                writer.WriteLine(bienvenidaJson);
                writer.Flush();

                // Esperar confirmacion del servidor
                string? respuestaJson = reader.ReadLine();
                if (!string.IsNullOrEmpty(respuestaJson))
                {
                    Mensaje? respuesta = JsonConvert.DeserializeObject<Mensaje>(respuestaJson);
                    if (respuesta != null && respuesta.Accion == "OK")
                    {
                        NombreCliente = respuesta.Datos;
                        // Conexion exitosa
                        conectado = true;
                        return true;
                    }
                }

                // Si no hubo confirmación, desconectar
                Desconectar();
                return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar al servidor: {ex.Message}");
                return false;
            }
        }

        // Metodo para desconectar del servidor
        public void Desconectar()
        {
            try
            {
                reader?.Close();
                writer?.Close();
                stream?.Close();
                cliente?.Close();
                conectado = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al desconectar: {ex.Message}");
            }
        }

        // Metodo para enviar un mensaje al servidor y recibir respuesta
        private Mensaje? EnviarYRecibir(Mensaje mensaje)
        {
            try
            {
                if (!conectado || writer == null || reader == null)
                {
                    throw new Exception("No hay conexión con el servidor");
                }

                // Serializar y enviar
                string mensajeJson = JsonConvert.SerializeObject(mensaje);
                writer.WriteLine(mensajeJson);
                writer.Flush();

                // Recibir respuesta
                string? respuestaJson = reader.ReadLine();

                if (string.IsNullOrEmpty(respuestaJson))
                {
                    throw new Exception("El servidor no respondió");
                }

                Mensaje? respuesta = JsonConvert.DeserializeObject<Mensaje>(respuestaJson);
                return respuesta;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en comunicación: {ex.Message}");
                return null;
            }
        }

        // Metodos informativos
        public string ObtenerIP() => IP_SERVIDOR;
        public int ObtenerPuerto() => PUERTO_SERVIDOR;
    }
}
