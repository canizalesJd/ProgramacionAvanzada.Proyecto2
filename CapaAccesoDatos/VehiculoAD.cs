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
    /// Clase de acceso a datos para la entidad Vehiculo.
    /// </summary>
    public class VehiculoAD
    {
        // Conexión a la base de datos utilizando la cadena de conexión definida en el archivo de configuración
        private static readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["AutoMarketBD"].ConnectionString;

        /// <summary>
        /// Metodo para guardar un nuevo vehículo en el arreglo.
        /// </summary>
        public static void Guardar(Vehiculo vehiculo)
        {
            // Evitar duplicados: Antes de agregar un nuevo vehículo, verificar que no exista un vehículo con el mismo ID. Si ya existe, lanzar una excepción indicando que el vehículo ya existe.
            if (VehiculoExiste(vehiculo.IdVehiculo))
            {
                throw new InvalidOperationException("El vehículo con el ID proporcionado ya existe.");
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"INSERT INTO dbo.Vehiculo
                                     (IdVehiculo, Marca, Modelo, Ano, Precio, IdCategoria, Estado)
                                     VALUES (@IdVehiculo, @Marca, @Modelo, @Ano, @Precio, @IdCategoria, @Estado)";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdVehiculo", vehiculo.IdVehiculo);
                    comando.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                    comando.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                    comando.Parameters.AddWithValue("@Ano", vehiculo.Anio);
                    comando.Parameters.AddWithValue("@Precio", vehiculo.Precio);
                    comando.Parameters.AddWithValue("@IdCategoria", vehiculo.Categoria.IdCategoria);
                    comando.Parameters.AddWithValue("@Estado", vehiculo.Estado);

                    try
                    {
                        conexion.Open();
                        int filas = comando.ExecuteNonQuery();

                        if (filas == 0)
                            throw new InvalidOperationException("No se pudo insertar el vehículo en la base de datos.");
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al guardar el vehículo en la base de datos: " + ex.Message, ex);
                    }
                }
            }
        }

        // Método para verificar si un vehículo existe por su ID
        public static bool VehiculoExiste(int idVehiculo)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"SELECT COUNT(1)
                             FROM dbo.Vehiculo
                             WHERE IdVehiculo = @IdVehiculo";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdVehiculo", idVehiculo);

                    try
                    {
                        conexion.Open();
                        // ExecuteScalar devuelve el primer valor de la primera fila del resultado
                        int cantidad = (int)comando.ExecuteScalar();
                        return cantidad > 0;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al verificar la existencia del vehículo: " + ex.Message, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Metodo para consultar todos los vehículos almacenados en el arreglo.
        /// </summary>
        public static List<Vehiculo> Consultar()
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"
                    SELECT  v.IdVehiculo,
                            v.Marca,
                            v.Modelo,
                            v.Ano,
                            v.Precio,
                            v.IdCategoria,
                            v.Estado,
                            c.IdCategoria,
                            c.NombreCategoria,
                            c.Descripcion
                    FROM    dbo.Vehiculo v
                    INNER JOIN dbo.CategoriaVehiculo c ON v.IdCategoria = c.IdCategoria";

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
                                // Construir CategoriaVehiculo
                                CategoriaVehiculo categoriaVehiculo = new CategoriaVehiculo(
                                    lector.GetInt32(7),    // IdCategoria
                                    lector.GetString(8),   // NombreCategoria
                                    lector.GetString(9)   // Descripcion
                                );

                                // Construir Vehiculo
                                char estado = lector.GetString(6)[0];

                                Vehiculo vehiculo = new Vehiculo(
                                    lector.GetInt32(0),
                                    lector.GetString(1),
                                    lector.GetString(2),
                                    lector.GetInt32(3),
                                    lector.GetDecimal(4),
                                    categoriaVehiculo,
                                    estado
                                );

                                lista.Add(vehiculo);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al consultar los vehiculos: " + ex.Message, ex);
                    }
                }
            }

            return lista;
        }
    }
}
