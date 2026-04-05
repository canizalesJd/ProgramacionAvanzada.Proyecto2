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
    /// Clase de acceso a datos para la entidad Sucursal. Esta clase proporciona métodos para almacenar y consultar sucursales en un arreglo estático.
    /// </summary>
    public class SucursalAD
    {
        // Conexión a la base de datos utilizando la cadena de conexión definida en el archivo de configuración
        private static readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["AutoMarketBD"].ConnectionString;

        /// <summary>
        /// Método para guardar una nueva sucursal en el arreglo.
        /// </summary>
        public static void Guardar(Sucursal sucursal)
        {
            // Evitar duplicados
            if (SucursalExiste(sucursal.IdSucursal))
            {
                throw new InvalidOperationException("La sucursal con el ID proporcionado ya existe.");
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"INSERT INTO dbo.Sucursal
                                     (IdSucursal, Nombre, Direccion, Telefono, IdVendedor, Activo)
                                     VALUES (@IdSucursal, @Nombre, @Direccion, @Telefono, @IdVendedor, @Activo)";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdSucursal", sucursal.IdSucursal);
                    comando.Parameters.AddWithValue("@Nombre", sucursal.Nombre);
                    comando.Parameters.AddWithValue("@Direccion", sucursal.Direccion);
                    comando.Parameters.AddWithValue("@Telefono", sucursal.Telefono);
                    comando.Parameters.AddWithValue("@IdVendedor", sucursal.VendedorEncargado.IdVendedor);
                    comando.Parameters.AddWithValue("@Activo", sucursal.Activa);

                    try
                    {
                        conexion.Open();
                        int filas = comando.ExecuteNonQuery();

                        if (filas == 0)
                            throw new InvalidOperationException("No se pudo insertar la sucursal en la base de datos.");
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al guardar la sucursal en la base de datos: " + ex.Message, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Método para verificar si una sucursal existe por su ID
        /// </summary>
        public static bool SucursalExiste(int idSucursal)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"SELECT COUNT(1)
                             FROM dbo.Sucursal
                             WHERE IdSucursal = @IdSucursal";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdSucursal", idSucursal);

                    try
                    {
                        conexion.Open();
                        // ExecuteScalar devuelve el primer valor de la primera fila del resultado
                        int cantidad = (int)comando.ExecuteScalar();
                        return cantidad > 0;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al verificar la existencia de la sucursal: " + ex.Message, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Método para obtener todas las sucursales. Retorna solo las sucursales agregadas.
        /// </summary>
        public static List<Sucursal> Consultar()
        {
            List<Sucursal> lista = new List<Sucursal>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"
                    SELECT  s.IdSucursal,
                            s.Nombre,
                            s.Direccion,
                            s.Telefono,
                            s.Activo,
                            v.IdVendedor,
                            v.Identificacion,
                            v.NombreCompleto,
                            v.FechaNacimiento,
                            v.FechaIngreso,
                            v.Telefono
                    FROM    dbo.Sucursal s
                    INNER JOIN dbo.Vendedor v ON s.IdVendedor = v.IdVendedor";

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
                                // Construir VendedorEncargado
                                Vendedor vendedor = new Vendedor(
                                    lector.GetInt32(5),    // IdVendedor
                                    lector.GetString(6),   // Identificacion
                                    lector.GetString(7),   // NombreCompleto
                                    lector.GetDateTime(8), // FechaNacimiento
                                    lector.GetDateTime(9), // FechaIngreso
                                    lector.GetString(10)   // Telefono vendedor
                                );
                                 
                                // Construir Sucursal
                                Sucursal sucursal = new Sucursal(
                                    lector.GetInt32(0),   // IdSucursal
                                    lector.GetString(1),  // Nombre
                                    lector.GetString(2),  // Direccion
                                    lector.GetString(3),  // Telefono sucursal
                                    vendedor,             // VendedorEncargado
                                    lector.GetBoolean(4)  // Activa
                                );

                                lista.Add(sucursal);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al consultar las sucursales: " + ex.Message, ex);
                    }
                }
            }

            return lista;
        }

        /// <summary>
        /// Método para obtener solo las sucursales activas. Retorna solo las sucursales que tienen el atributo Activa en true.
        /// </summary>
        public static List<Sucursal> ConsultarActivas()
        {
            List<Sucursal> lista = new List<Sucursal>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"
                    SELECT  s.IdSucursal,
                            s.Nombre,
                            s.Direccion,
                            s.Telefono,
                            s.Activo,
                            v.IdVendedor,
                            v.Identificacion,
                            v.NombreCompleto,
                            v.FechaNacimiento,
                            v.FechaIngreso,
                            v.Telefono
                    FROM    dbo.Sucursal s
                    INNER JOIN dbo.Vendedor v ON s.IdVendedor = v.IdVendedor
                    WHERE s.Activo = 1";

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
                                // Construir VendedorEncargado
                                Vendedor vendedor = new Vendedor(
                                    lector.GetInt32(5),    // IdVendedor
                                    lector.GetString(6),   // Identificacion
                                    lector.GetString(7),   // NombreCompleto
                                    lector.GetDateTime(8), // FechaNacimiento
                                    lector.GetDateTime(9), // FechaIngreso
                                    lector.GetString(10)   // Telefono vendedor
                                );

                                // Construir Sucursal
                                Sucursal sucursal = new Sucursal(
                                    lector.GetInt32(0),   // IdSucursal
                                    lector.GetString(1),  // Nombre
                                    lector.GetString(2),  // Direccion
                                    lector.GetString(3),  // Telefono sucursal
                                    vendedor,             // VendedorEncargado
                                    lector.GetBoolean(4)  // Activa
                                );

                                lista.Add(sucursal);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al consultar las sucursales activas: " + ex.Message, ex);
                    }
                }
            }
            return lista;
        }
    }
}
