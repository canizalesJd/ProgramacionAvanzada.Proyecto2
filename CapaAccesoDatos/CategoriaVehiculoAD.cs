/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Marzo 2026
 */

using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos
{
    /// <summary>
    /// Clase de acceso a datos para la entidad CategoriaVehiculo.
    /// </summary>
    public class CategoriaVehiculoAD
    {
        // Arreglo estático para almacenar categorías de vehículos, con una capacidad máxima de 20 registros
        private static CategoriaVehiculo[] categorias = new CategoriaVehiculo[20];
        private static int contador;
        private static readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["AutoMarketBD"].ConnectionString;

        /// <summary>
        /// Método para agregar una nueva categoría de vehículo al arreglo.
        /// </summary>
        public static void Guardar(CategoriaVehiculo categoria)
        {
            // 1. Validación previa: que no exista ya en BD
            if (CategoriaExiste(categoria.IdCategoria))
            {
                throw new InvalidOperationException("La categoría con el ID proporcionado ya existe.");
            }

            // 2. Insertar en la base de datos
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"INSERT INTO dbo.CategoriaVehiculo
                             (IdCategoria, NombreCategoria, Descripcion)
                             VALUES (@IdCategoria, @NombreCategoria, @Descripcion)";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
                    comando.Parameters.AddWithValue("@NombreCategoria", categoria.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                    try
                    {
                        conexion.Open();
                        int filas = comando.ExecuteNonQuery();

                        // Verificar si la inserción fue exitosa
                        if (filas == 0)
                        {
                            throw new InvalidOperationException("No se pudo insertar la categoría en la base de datos.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al guardar la categoría en la base de datos: " + ex.Message, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Método para verificar si una categoría de vehículo con un ID específico ya existe en el arreglo.
        /// </summary>
        public static bool CategoriaExiste(int idCategoria)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"SELECT COUNT(1)
                             FROM dbo.CategoriaVehiculo
                             WHERE IdCategoria = @IdCategoria";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdCategoria", idCategoria);

                    try
                    {
                        conexion.Open();
                        // ExecuteScalar devuelve el primer valor de la primera fila del resultado
                        int cantidad = (int)comando.ExecuteScalar();
                        return cantidad > 0;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al verificar la existencia de la categoría: " + ex.Message, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Método para obtener todas las categorías de vehículo
        /// </summary>
        public static List<CategoriaVehiculo> Consultar()
        {
            List<CategoriaVehiculo> lista = new List<CategoriaVehiculo>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"SELECT IdCategoria, NombreCategoria, Descripcion
                             FROM dbo.CategoriaVehiculo";
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
                                CategoriaVehiculo categoria = new CategoriaVehiculo(
                                    lector.GetInt32(0),
                                    lector.GetString(1),
                                    lector.GetString(2)
                                );

                                lista.Add(categoria);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al consultar las categorías: " + ex.Message, ex);
                    }
                }
            }
            return lista;
        }

    }
}
