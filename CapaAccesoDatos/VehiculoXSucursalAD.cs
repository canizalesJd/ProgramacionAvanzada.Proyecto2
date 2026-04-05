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
    public class VehiculoXSucursalAD
    {
        // Conexión a la base de datos utilizando la cadena de conexión definida en el archivo de configuración
        private static readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["AutoMarketBD"].ConnectionString;

        /// <summary>
        /// Método para guardar una nueva relación entre un vehículo y una sucursal.
        /// </summary>
        public static void Guardar(VehiculoXSucursal vehiculoXSucursal)
        {
            // Validar que el objeto no sea nulo
            if (vehiculoXSucursal == null)
            {
                throw new ArgumentNullException(nameof(vehiculoXSucursal), "No se puede guardar una relación nula entre vehículo y sucursal.");
            }

            // Validar que el vehículo y la sucursal no sean nulos
            if (vehiculoXSucursal.Vehiculo == null)
            {
                throw new ArgumentException("El vehículo no puede ser nulo.", nameof(vehiculoXSucursal));
            }

            if (vehiculoXSucursal.Sucursal == null)
            {
                throw new ArgumentException("La sucursal no puede ser nula.", nameof(vehiculoXSucursal));
            }

            // Validar que la relación no sea duplicada
            if (VehiculoXSucursalExiste(vehiculoXSucursal.Vehiculo.IdVehiculo, vehiculoXSucursal.Sucursal.IdSucursal))
            {
                throw new InvalidOperationException("La relación entre el vehículo y la sucursal ya existe.");
            }

            // Validar que la cantidad sea un número positivo
            if (vehiculoXSucursal.Cantidad < 0)
            {
                throw new ArgumentException("La cantidad debe ser un número positivo.");
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"INSERT INTO dbo.VehiculoxSucursal
                                     (IdSucursal, IdVehiculo, Cantidad)
                                     VALUES (@IdSucursal, @IdVehiculo, @Cantidad)";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdSucursal", vehiculoXSucursal.Sucursal.IdSucursal);
                    comando.Parameters.AddWithValue("@IdVehiculo", vehiculoXSucursal.Vehiculo.IdVehiculo);
                    comando.Parameters.AddWithValue("@Cantidad", vehiculoXSucursal.Cantidad);

                    try
                    {
                        conexion.Open();
                        int filas = comando.ExecuteNonQuery();

                        if (filas == 0)
                            throw new InvalidOperationException("No se pudo insertar la relación vehículo-sucursal en la base de datos.");
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al guardar la relación vehículo-sucursal en la base de datos: " + ex.Message, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Método para verificar si una relación entre un vehículo y una sucursal ya existe en el arreglo
        /// </summary>
        public static bool VehiculoXSucursalExiste(int idVehiculo, int idSucursal)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"SELECT COUNT(1)
                             FROM dbo.VehiculoxSucursal
                             WHERE IdVehiculo = @IdVehiculo
                             AND IdSucursal = @IdSucursal";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
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
                        throw new Exception("Error al verificar la existencia de la relación vehículo-sucursal: " + ex.Message, ex);
                    }
                }
            }
        }

        /// <summary>
        /// Método para consultar todas las relaciones entre vehículos y sucursales almacenadas en el arreglo.
        /// </summary>
        public static List<VehiculoXSucursal> Consultar()
        {
            List<VehiculoXSucursal> lista = new List<VehiculoXSucursal>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
            string sentencia = @"
            SELECT  vxs.IdSucursal,
                    vxs.IdVehiculo,
                    vxs.Cantidad,

                    s.Nombre,
                    s.Direccion,
                    s.Telefono,
                    s.Activo,
                    s.IdVendedor,

                    ven.IdVendedor,
                    ven.Identificacion,
                    ven.NombreCompleto,
                    ven.FechaNacimiento,
                    ven.FechaIngreso,
                    ven.Telefono,

                    v.Marca,
                    v.Modelo,
                    v.Ano,
                    v.Precio,
                    v.Estado,

                    c.IdCategoria,
                    c.NombreCategoria,
                    c.Descripcion
            FROM    dbo.VehiculoxSucursal vxs
            INNER JOIN dbo.Sucursal s           ON vxs.IdSucursal = s.IdSucursal
            INNER JOIN dbo.Vendedor ven         ON ven.IdVendedor = s.IdVendedor
            INNER JOIN dbo.Vehiculo v           ON vxs.IdVehiculo = v.IdVehiculo
            INNER JOIN dbo.CategoriaVehiculo c  ON v.IdCategoria = c.IdCategoria";

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
                                // Vendedor encargado de la sucursal
                                Vendedor vendedor = new Vendedor(
                                    lector.GetInt32(8),                // IdVendedor
                                    lector.GetString(9),               // Identificacion
                                    lector.GetString(10),               // NombreCompleto
                                    lector.GetDateTime(11),            // FechaNacimiento
                                    lector.GetDateTime(12),            // FechaIngreso
                                    lector.GetString(13)                // Telefono vendedor
                                );

                                // Sucursal
                                Sucursal sucursal = new Sucursal(
                                    lector.GetInt32(0),                // IdSucursal
                                    lector.GetString(3),               // Nombre
                                    lector.GetString(4),               // Direccion
                                    lector.GetString(5),                 // Telefono sucursal
                                    vendedor,                          // VendedorEncargado
                                    lector.GetBoolean(6)               // Activa
                                );

                                // Categoría de vehículo
                                CategoriaVehiculo categoria = new CategoriaVehiculo(
                                    lector.GetInt32(19),               // IdCategoria
                                    lector.GetString(20),              // NombreCategoria
                                    lector.GetString(21)               // Descripcion
                                );

                                // Vehículo
                                char estado = lector.GetString(18)[0];

                                Vehiculo vehiculo = new Vehiculo(
                                    lector.GetInt32(1),                // IdVehiculo (de vxs)
                                    lector.GetString(14),              // Marca
                                    lector.GetString(15),              // Modelo
                                    lector.GetInt32(16),               // Año
                                    lector.GetDecimal(17),             // Precio
                                    categoria,                         // Categoria
                                    estado                             // Estado
                                );

                                // Relación VehiculoXSucursal
                                int cantidad = lector.GetInt32(2);

                                VehiculoXSucursal vehiculoXSucursal = new VehiculoXSucursal(
                                    sucursal,
                                    vehiculo,
                                    cantidad
                                );

                                lista.Add(vehiculoXSucursal);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al consultar VehiculoXSucursal: " + ex.Message, ex);
                    }
                }
            }

            return lista;
        }
    }
}
