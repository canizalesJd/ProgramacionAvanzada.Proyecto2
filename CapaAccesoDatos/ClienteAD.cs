/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

using CapaEntidades;
using System.Data;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos
{
    /// <summary>
    /// Clase de acceso a datos para la entidad Cliente. Esta clase proporciona métodos para almacenar y consultar clientes en un arreglo estático.
    /// </summary>
    public class ClienteAD
    {
        // Conexión a la base de datos utilizando la cadena de conexión definida en el archivo de configuración
        private static readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["AutoMarketBD"].ConnectionString;

        /// <summary>
        /// Método para guardar un nuevo cliente en el arreglo.
        /// </summary>
        public static void Guardar(Cliente cliente)
        {
            // Validar que no existan duplicados por ID o identificación antes de guardar el cliente
            if (IdClienteExiste(cliente.IdCliente))
                throw new InvalidOperationException("El cliente con el ID proporcionado ya existe.");

            if (IdentificacionExiste(cliente.Identificacion))
                throw new InvalidOperationException("El cliente con la identificación proporcionada ya existe.");

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"INSERT INTO dbo.Cliente
                                     (IdCliente, Identificacion, NombreCompleto, FechaNacimiento, FechaRegistro, Activo)
                                     VALUES (@IdCliente, @Identificacion, @NombreCompleto, @FechaNacimiento, @FechaRegistro, @Activo)";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                    comando.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                    comando.Parameters.AddWithValue("@NombreCompleto", cliente.NombreCompleto);
                    comando.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                    comando.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);
                    comando.Parameters.AddWithValue("@Activo", cliente.Activo);

                    try
                    {
                        conexion.Open();
                        int filas = comando.ExecuteNonQuery();

                        if (filas == 0)
                            throw new InvalidOperationException("No se pudo insertar el cliente en la base de datos.");
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al guardar el cliente en la base de datos: " + ex.Message, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Método para verificar si un cliente existe por su ID
        /// </summary>
        public static bool IdClienteExiste(int idCliente)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"SELECT COUNT(1)
                             FROM dbo.Cliente
                             WHERE IdCliente = @IdCliente";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdCliente", idCliente);

                    try
                    {
                        conexion.Open();
                        // ExecuteScalar devuelve el primer valor de la primera fila del resultado
                        int cantidad = (int)comando.ExecuteScalar();
                        return cantidad > 0;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al verificar la existencia del cliente: " + ex.Message, ex);
                    }
                }
            }
        }

        /// <summary>
        ///  Método para verificar si un cliente existe por su identificación.
        /// </summary>
        public static bool IdentificacionExiste(string identificacion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"SELECT COUNT(1)
                             FROM dbo.Cliente
                             WHERE Identificacion = @Identificacion";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@Identificacion", identificacion);

                    try
                    {
                        conexion.Open();
                        // ExecuteScalar devuelve el primer valor de la primera fila del resultado
                        int cantidad = (int)comando.ExecuteScalar();
                        return cantidad > 0;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al verificar la existencia del cliente: " + ex.Message, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Metodo para consultar todos los clientes almacenados en el arreglo.
        /// </summary>
        public static List<Cliente> Consultar()
        {
            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"SELECT IdCliente,
                                    Identificacion,
                                    NombreCompleto,
                                    FechaNacimiento,
                                    FechaRegistro,
                                    Activo
                    FROM dbo.Cliente";
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    try
                    {
                        conexion.Open();
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                Cliente cliente = new Cliente(
                                    lector.GetInt32(0),          // IdCliente
                                    lector.GetString(1),         // Identificacion
                                    lector.GetString(2),         // NombreCompleto
                                    lector.GetDateTime(3),       // FechaNacimiento
                                    lector.GetDateTime(4),       // FechaRegistro
                                    lector.GetBoolean(5)         // Activo
                                );
                                lista.Add(cliente);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al consultar los clientes: " + ex.Message, ex);
                    }
                }
            }
            return lista;
        }
    }
}
