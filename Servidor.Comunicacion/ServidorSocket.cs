/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

using CapaAccesoDatos;
using CapaEntidades;
using CapaLogicaNegocio;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.Text;
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
        private const int PUERTO_SERVIDOR = 15500;
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

        // Instancia de la lógica de negocio para gestionar clientes
        private readonly ClienteLN clienteLN;

        // Instancia de la lógica de negocio para gestionar sucursales
        private readonly SucursalLN sucursalLN;

        // Instancia de la lógica de negocio para gestionar ventas
        private readonly VentaLN ventaLN;

        // Variable para el nombre del cliente
        private string nombreCliente = string.Empty;

        // Constructor
        public ServidorSocket()
        {
            clientesConectados = new List<InfoCliente>();
            clienteLN = new ClienteLN();
            sucursalLN = new SucursalLN();
            ventaLN = new VentaLN();
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
            string identificacion = string.Empty;
            InfoCliente? infoCliente = null;
            Cliente? clienteDatos = null;
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
                        identificacion = mensajeBienvenida.Datos; // Obtener la identificación del cliente desde el mensaje de bienvenida

                        // Validar el cliente utilizando la lógica de negocio
                        clienteDatos = clienteLN.ConsultarPorIdentificacion(identificacion);

                        // Inicializar Mensaje
                        Mensaje respuestaBienvenida = new();

                        if (clienteDatos != null && clienteDatos.Activo)
                        {
                            nombreCliente = clienteDatos.NombreCompleto.Trim();
                            infoCliente = new InfoCliente(cliente, nombreCliente);
                            clientesConectados.Add(infoCliente); // Agregar el clienta a la lista de clientes conectados
                            // Crear un objeto InfoCliente para almacenar la información del cliente conectado
                            string clienteJson = JsonConvert.SerializeObject(clienteDatos);
                            respuestaBienvenida = new("OK", "Conexion", clienteJson);
                            // Notificar que un nuevo cliente se ha conectado
                            NuevaBitacora?.Invoke($"Cliente conectado: {nombreCliente}. Total: {clientesConectados.Count} de {MAX_CLIENTES}");
                            ClienteConectado?.Invoke(nombreCliente);
                            // Enviar la respuesta de bienvenida al cliente
                            string respuestaJson = JsonConvert.SerializeObject(respuestaBienvenida);
                            writer.WriteLine(respuestaJson);
                            writer.Flush();
                        } else
                        {
                            // Si el cliente no es válido o no está activo, enviar un mensaje de error y cerrar la conexión
                            respuestaBienvenida = new("ERROR", "CONEXION", $"Identificación no válida o cliente inactivo.");
                            // Notificar que un cliente ha intentado conectarse con una identificación no válida o inactiva
                            NuevaBitacora?.Invoke($"Intento de conexión fallido con identificación: {identificacion}"); // Notificar en la bitácora

                            string respuestaJson = JsonConvert.SerializeObject(respuestaBienvenida); // Serializar el mensaje de error
                            writer.WriteLine(respuestaJson);
                            writer.Flush();
                            cliente.Close();
                            return;
                        }

                    }
                }

                // PASO 2: Ciclo de peticiones normales
                while (cliente.Connected && servidorActivo)
                {
                    string? mensajeJson = reader.ReadLine(); // Leer un mensaje del cliente (JSON)
                    string nombreCliente = clienteDatos != null ? clienteDatos.NombreCompleto : identificacion; // Obtener el nombre del cliente para la bitácora

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
                NuevaBitacora?.Invoke($"Error en la comunicación con Cliente con identificación {identificacion}: {ex.Message}");
            }
            finally
            {
                // Remover lista y cerrar
                if (infoCliente != null)
                {
                    clientesConectados.Remove(infoCliente); // Remover el cliente de la lista de clientes conectados
                    NuevaBitacora?.Invoke($"Cliente desconectado: {nombreCliente}. Total: {clientesConectados.Count} de {MAX_CLIENTES}"); // Notificar que el cliente se ha desconectado
                    ClienteDesconectado?.Invoke(infoCliente.Nombre); // Notificar a la interfaz de usuario
                }

                cliente.Close(); // Cerrar la conexión con el cliente
                NuevaBitacora?.Invoke($"Conexión cerrada con {nombreCliente}"); // Notificar que la conexión con el cliente se ha cerrado
            }
        }

        // Metodo para obtener los vehículos disponibles por sucursal
        public Mensaje ObtenerVehiculosPorSucursal(Mensaje mensaje)
        {
            try
            {
                int idSucursal = int.Parse(mensaje.Datos); // Obtener el ID de la sucursal desde el mensaje
                List<Vehiculo> vehiculos = VehiculoXSucursalAD.ObtenerVehiculosPorSucursal(idSucursal); // Obtener los vehículos disponibles desde la capa de acceso a datos
                string datosJson = JsonConvert.SerializeObject(vehiculos); // Serializar la lista de vehículos a JSON
                return new Mensaje("OK", "OBTENER_VEHICULOS_POR_SUCURSAL", datosJson); // Retornar un mensaje con la lista de vehículos disponibles
            }
            catch (Exception ex)
            {
                return new Mensaje("ERROR", "OBTENER_VEHICULOS_POR_SUCURSAL", $"Error al obtener vehículos por sucursal: {ex.Message}"); // Retornar un mensaje de error si ocurre una excepción
            }
        }

        // Metodo para obtener las sucursales activas
        public Mensaje ObtenerSucursalesActivas()
        {
            try
            {
                List<Sucursal> sucursales = sucursalLN.ConsultarActivas(); // Obtener la lista de sucursales activas desde la lógica de negocio
                string datosJson = JsonConvert.SerializeObject(sucursales); // Serializar la lista de sucursales a JSON
                return new Mensaje("OK", "SUCURSALES_ACTIVAS", datosJson); // Retornar un mensaje con la lista de sucursales activas
            }
            catch (Exception ex)
            {
                return new Mensaje("ERROR", "SUCURSALES_ACTIVAS", $"Error al obtener sucursales activas: {ex.Message}"); // Retornar un mensaje de error si ocurre una excepción
            }
        }

        // Metodo para registrar una venta
        public Mensaje RegistrarVenta(Mensaje mensaje)
        {
            try
            {
                Venta venta = JsonConvert.DeserializeObject<Venta>(mensaje.Datos)!;
                ventaLN.RegistrarVenta(
                    venta.Cliente,
                    venta.Sucursal,
                    venta.Vehiculo,
                    venta.FechaVenta,
                    venta.Monto
                );

                return new Mensaje("OK", "REGISTRAR_VENTA", "Venta registrada exitosamente.");
            }
            catch (Exception ex)
            {
                return new Mensaje("ERROR", "REGISTRAR_VENTA", $"Error al registrar la venta: {ex.Message}");
            }
        }

        // Metodo para obtener las ventas por cliente
        public Mensaje ObtenerVentasPorCliente(Mensaje mensaje)
        {
            try
            {
                int idCliente = int.Parse(mensaje.Datos); // Obtener el ID del cliente desde el mensaje
                List<Venta> ventas = ventaLN.ConsultarVentasPorCliente(idCliente); // Obtener la lista de ventas del cliente desde la lógica de negocio
                string datosJson = JsonConvert.SerializeObject(ventas); // Serializar la lista de ventas a JSON
                return new Mensaje("OK", "OBTENER_VENTAS_POR_CLIENTE", datosJson); // Retornar un mensaje con la lista de ventas del cliente
            }
            catch (Exception ex)
            {
                return new Mensaje("ERROR", "OBTENER_VENTAS_POR_CLIENTE", $"Error al obtener las ventas por cliente: {ex.Message}"); // Retornar un mensaje de error si ocurre una excepción
            }
        }

        // Metodo para procesar un mensaje recibido del cliente y generar una respuesta
        public Mensaje ProcesarMensaje(Mensaje mensaje)
        {
            Mensaje respuesta = new();
            try
            {
                switch (mensaje.Tipo)
                {
                    case "SERVIDOR":
                        if (mensaje.Accion == "PING")
                            return new Mensaje("OK", "SERVIDOR", "Servidor activo");
                        break;
                    case "SUCURSAL":
                        if (mensaje.Accion == "OBTENER_SUCURSALES_ACTIVAS")
                            return ObtenerSucursalesActivas();
                        if (mensaje.Accion == "OBTENER_VEHICULOS_POR_SUCURSAL")
                            return ObtenerVehiculosPorSucursal(mensaje);
                        break;
                    case "VENTA":
                        if (mensaje.Accion == "REGISTRAR_VENTA")
                            return RegistrarVenta(mensaje);
                        if (mensaje.Accion == "OBTENER_VENTAS_POR_CLIENTE")
                            return ObtenerVentasPorCliente(mensaje);
                        break;
                    default:
                        respuesta = new Mensaje("ERROR", "RESPUESTA", "Tipo de mensaje no reconocido");
                        break;
                }
            }
            catch (Exception ex)
            {
                return new Mensaje("ERROR", "RESPUESTA", $"Error al procesar el mensaje: {ex.Message}");
            }
            return respuesta;
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
