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
        private const int PUERTO_SERVIDOR = 15500;
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
        public CapaEntidades.Cliente? ClienteAutenticado { get; private set; }

        // Constructor
        public ClienteSocket()
        {
        }

        // METODOS PUBLICOS

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
                Mensaje mensajeBienvenida = new("CONECTAR", "CLIENTE", identificacion);
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
                        ClienteAutenticado = JsonConvert.DeserializeObject<CapaEntidades.Cliente>(respuesta.Datos);
                        NombreCliente = ClienteAutenticado?.NombreCompleto ?? string.Empty;
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

        // Metodo para verificar la conexión con el servidor
        public bool VerificarConexion()
        {
            try
            {
                if (!conectado || cliente == null || !cliente.Connected)
                    return false;

                Mensaje mensaje = new Mensaje("PING", "SERVIDOR", "");
                Mensaje? respuesta = EnviarYRecibir(mensaje);

                return respuesta != null && respuesta.Accion == "OK";
            }
            catch
            {
                Desconectar();
                return false;
            }
        }

        // Metodo para obtener la lista de vehículos disponibles de una sucursal especifica
        public List<Vehiculo> ObtenerVehiculosPorSucursal(int idSucursal)
        {
            try
            {
                Mensaje mensaje = new Mensaje("OBTENER_VEHICULOS_POR_SUCURSAL", "SUCURSAL", idSucursal.ToString());
                Mensaje? respuesta = EnviarYRecibir(mensaje);
                if (respuesta != null && respuesta.Accion == "OK")
                {
                    List<Vehiculo>? vehiculos = JsonConvert.DeserializeObject<List<Vehiculo>>(respuesta.Datos);
                    return vehiculos ?? new List<Vehiculo>(); // ?? null-coalescing: Si la deserialización falla, devuelve una lista vacía en lugar de null
                }
                return new List<Vehiculo>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener vehículos: {ex.Message}");
                return new List<Vehiculo>();
            }
        }

        // Metodo para obtener sucursales activas
        public List<Sucursal> ObtenerSucursalesActivas()
        {
            try
            {
                Mensaje mensaje = new Mensaje("OBTENER_SUCURSALES_ACTIVAS", "SUCURSAL", "");
                Mensaje? respuesta = EnviarYRecibir(mensaje);
                if (respuesta != null && respuesta.Accion == "OK")
                {
                    List<Sucursal>? sucursales = JsonConvert.DeserializeObject<List<Sucursal>>(respuesta.Datos);
                    return sucursales ?? new List<Sucursal>(); // ?? null-coalescing: Si la deserialización falla, devuelve una lista vacía en lugar de null
                }
                return new List<Sucursal>();
            } catch (Exception ex) {
                Console.WriteLine($"Error al obtener sucursales: {ex.Message}");
                return new List<Sucursal>();
            }
        }

        // Metodo para registrar una venta
        public bool RegistrarVenta(Venta venta)
        {
            try
            {
                string ventaJson = JsonConvert.SerializeObject(venta);
                Mensaje mensaje = new Mensaje("REGISTRAR_VENTA", "VENTA", ventaJson);
                Mensaje? respuesta = EnviarYRecibir(mensaje);
                return respuesta != null && respuesta.Accion == "OK";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar venta: {ex.Message}");
                return false;
            }
        }

        // Metodo para consultar las ventas realizadas por el cliente
        public List<Venta> ConsultarVentasPorCliente(int idCliente)
        {
            try
            {
                Mensaje mensaje = new Mensaje("OBTENER_VENTAS_POR_CLIENTE", "VENTA", idCliente.ToString());
                Mensaje? respuesta = EnviarYRecibir(mensaje);
                if (respuesta != null && respuesta.Accion == "OK")
                {
                    List<Venta>? ventas = JsonConvert.DeserializeObject<List<Venta>>(respuesta.Datos);
                    return ventas ?? new List<Venta>(); // ?? null-coalescing: Si la deserialización falla, devuelve una lista vacía en lugar de null
                }
                return new List<Venta>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener ventas: {ex.Message}");
                return new List<Venta>();
            }
        }

        // METODOS PRIVADOS

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
