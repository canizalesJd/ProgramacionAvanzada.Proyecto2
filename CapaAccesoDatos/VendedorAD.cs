/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Febrero 2026
 */

using CapaEntidades;
using System.Data;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos
{
    /// <summary>
    /// Clase de acceso a datos para la entidad Vendedor.
    /// </summary>
    public class VendedorAD
    {
        // Conexión a la base de datos utilizando la cadena de conexión definida en el archivo de configuración
        private static readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["AutoMarketBD"].ConnectionString;

        /// <summary>
        /// Método que agrega un nuevo vendedor al arreglo de vendedores.
        /// </summary>
        public static void Guardar(Vendedor vendedor)
        {
            // Evitar duplicados: Antes de agregar un nuevo vendedor, verificar que no exista un vendedor con el mismo ID. Si ya existe, lanzar una excepción indicando que el vendedor ya existe.
            if (VendedorExiste(vendedor.IdVendedor))
                throw new InvalidOperationException("El vendedor con el ID proporcionado ya existe.");

            // Verificar unicidad del número de identificación: Antes de agregar un nuevo vendedor, verificar que no exista un vendedor con la misma identificación
            if (IdentificacionVendedorExiste(vendedor.Identificacion))
                throw new InvalidOperationException("El vendedor con la identificación proporcionada ya existe.");

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"INSERT INTO dbo.Vendedor
                                     (IdVendedor, Identificacion, NombreCompleto, FechaNacimiento, FechaIngreso, Telefono)
                                     VALUES (@IdVendedor, @Identificacion, @NombreCompleto, @FechaNacimiento, @FechaIngreso, @Telefono)";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdVendedor", vendedor.IdVendedor);
                    comando.Parameters.AddWithValue("@Identificacion", vendedor.Identificacion);
                    comando.Parameters.AddWithValue("@NombreCompleto", vendedor.NombreCompleto);
                    comando.Parameters.AddWithValue("@FechaNacimiento", vendedor.FechaNacimiento);
                    comando.Parameters.AddWithValue("@FechaIngreso", vendedor.FechaIngreso);
                    comando.Parameters.AddWithValue("@Telefono", vendedor.Telefono);

                    try
                    {
                        conexion.Open();
                        int filas = comando.ExecuteNonQuery();

                        if (filas == 0)
                            throw new InvalidOperationException("No se pudo insertar el vendedor en la base de datos.");
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al guardar el vendedor en la base de datos: " + ex.Message, ex);
                    }
                }
            }
        }

        // Método para verificar si un vendedor existe por su ID
        public static bool VendedorExiste(int idVendedor)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"SELECT COUNT(1)
                             FROM dbo.Vendedor
                             WHERE IdVendedor = @IdVendedor";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdVendedor", idVendedor);

                    try
                    {
                        conexion.Open();
                        // ExecuteScalar devuelve el primer valor de la primera fila del resultado
                        int cantidad = (int)comando.ExecuteScalar();
                        return cantidad > 0;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al verificar la existencia del vendedor: " + ex.Message, ex);
                    }
                }
            }
        }


        // Método para verificar si un vendedor existe por su ID
        public static bool IdentificacionVendedorExiste(string identificacion)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"SELECT COUNT(1)
                             FROM dbo.Vendedor
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
                        throw new Exception("Error al verificar la identificación del vendedor: " + ex.Message, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Metodo que devuelve un arreglo con todos los vendedores almacenados.
        /// </summary>
        public static List<Vendedor> Consultar()
        {
            List<Vendedor> lista = new List<Vendedor>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"SELECT IdVendedor,
                                    Identificacion,
                                    NombreCompleto,
                                    FechaNacimiento,
                                    FechaIngreso,
                                    Telefono
                    FROM dbo.Vendedor";
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
                                Vendedor vendedor = new Vendedor(
                                    lector.GetInt32(0),          // IdCliente
                                    lector.GetString(1),         // Identificacion
                                    lector.GetString(2),         // NombreCompleto
                                    lector.GetDateTime(3),       // FechaNacimiento
                                    lector.GetDateTime(4),       // FechaIngreso
                                    lector.GetString(5)          // Telefono
                                );
                                lista.Add(vendedor);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al consultar los vendedores: " + ex.Message, ex);
                    }
                }
            }
            return lista;
        }
    }
}
