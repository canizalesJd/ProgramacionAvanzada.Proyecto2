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
    public class VentaAD
    {
        // Conexión a la base de datos utilizando la cadena de conexión definida en el archivo de configuración
        private static readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["AutoMarketBD"].ConnectionString;

        /// <summary>
        /// Método para guardar una venta en la base de datos
        /// </summary>
        public static void Guardar(Venta venta)
        {
            if (venta == null)
                throw new ArgumentNullException(nameof(venta), "La venta no puede ser nula.");

            if (venta.Cliente == null)
                throw new ArgumentException("El cliente no es válido.");

            if (venta.Sucursal == null)
                throw new ArgumentException("La sucursal no es válida.");

            if (venta.Vehiculo == null)
                throw new ArgumentException("El vehículo no es válido.");

            if (venta.FechaVenta == default)
                throw new ArgumentException("La fecha de venta no es válida.");

            if (venta.Monto <= 0)
                throw new ArgumentException("El monto de la venta debe ser mayor a cero.");

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"INSERT INTO dbo.Venta
                             (IdCliente, IdSucursal, IdVehiculo, FechaVenta, Monto)
                             VALUES
                             (@IdCliente, @IdSucursal, @IdVehiculo, @FechaVenta, @Monto)";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdCliente", venta.Cliente.IdCliente);
                    comando.Parameters.AddWithValue("@IdSucursal", venta.Sucursal.IdSucursal);
                    comando.Parameters.AddWithValue("@IdVehiculo", venta.Vehiculo.IdVehiculo);
                    comando.Parameters.AddWithValue("@FechaVenta", venta.FechaVenta);
                    comando.Parameters.AddWithValue("@Monto", venta.Monto);

                    try
                    {
                        conexion.Open();
                        int filas = comando.ExecuteNonQuery();

                        if (filas == 0)
                            throw new InvalidOperationException("No se pudo registrar la venta en la base de datos.");
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al registrar la venta en la base de datos: " + ex.Message, ex);
                    }
                }
            }
        }

        // Consultar las ventas de un cliente por su ID
        public static List<Venta> ConsultarVentasPorCliente(int idCliente)
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string sentencia = @"
                SELECT
                    v.FechaVenta,
                    v.Monto,

                    c.IdCliente,
                    c.Identificacion AS ClienteIdentificacion,
                    c.NombreCompleto AS ClienteNombre,
                    c.FechaNacimiento AS ClienteFechaNacimiento,
                    c.FechaRegistro AS ClienteFechaRegistro,
                    c.Activo AS ClienteActivo,

                    s.IdSucursal,
                    s.Nombre AS SucursalNombre,
                    s.Direccion AS SucursalDireccion,
                    s.Telefono AS SucursalTelefono,
                    s.Activo AS SucursalActiva,

                    ven.IdVendedor,
                    ven.Identificacion AS VendedorIdentificacion,
                    ven.NombreCompleto AS VendedorNombre,
                    ven.FechaNacimiento AS VendedorFechaNacimiento,
                    ven.FechaIngreso AS VendedorFechaIngreso,
                    ven.Telefono AS VendedorTelefono,

                    ve.IdVehiculo,
                    ve.Marca AS VehiculoMarca,
                    ve.Modelo AS VehiculoModelo,
                    ve.Ano AS VehiculoAnio,
                    ve.Precio AS VehiculoPrecio,
                    ve.Estado AS VehiculoEstado,

                    cat.IdCategoria,
                    cat.NombreCategoria AS CategoriaNombre,
                    cat.Descripcion AS CategoriaDescripcion

                FROM dbo.Venta v
                INNER JOIN dbo.Cliente c ON v.IdCliente = c.IdCliente
                INNER JOIN dbo.Sucursal s ON v.IdSucursal = s.IdSucursal
                INNER JOIN dbo.Vendedor ven ON s.IdVendedor = ven.IdVendedor
                INNER JOIN dbo.Vehiculo ve ON v.IdVehiculo = ve.IdVehiculo
                INNER JOIN dbo.CategoriaVehiculo cat ON ve.IdCategoria = cat.IdCategoria
                WHERE v.IdCliente = @IdCliente
                ORDER BY v.FechaVenta DESC";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@IdCliente", idCliente);

                    try
                    {
                        conexion.Open();

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente(
                                    reader.GetInt32(reader.GetOrdinal("IdCliente")),
                                    reader.GetString(reader.GetOrdinal("ClienteIdentificacion")),
                                    reader.GetString(reader.GetOrdinal("ClienteNombre")),
                                    reader.GetDateTime(reader.GetOrdinal("ClienteFechaNacimiento")),
                                    reader.GetDateTime(reader.GetOrdinal("ClienteFechaRegistro")),
                                    reader.GetBoolean(reader.GetOrdinal("ClienteActivo"))
                                );

                                Vendedor vendedor = new Vendedor(
                                    reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                                    reader.GetString(reader.GetOrdinal("VendedorIdentificacion")),
                                    reader.GetString(reader.GetOrdinal("VendedorNombre")),
                                    reader.GetDateTime(reader.GetOrdinal("VendedorFechaNacimiento")),
                                    reader.GetDateTime(reader.GetOrdinal("VendedorFechaIngreso")),
                                    reader.GetString(reader.GetOrdinal("VendedorTelefono"))
                                );

                                Sucursal sucursal = new Sucursal(
                                    reader.GetInt32(reader.GetOrdinal("IdSucursal")),
                                    reader.GetString(reader.GetOrdinal("SucursalNombre")),
                                    reader.GetString(reader.GetOrdinal("SucursalDireccion")),
                                    reader.GetString(reader.GetOrdinal("SucursalTelefono")),
                                    vendedor,
                                    reader.GetBoolean(reader.GetOrdinal("SucursalActiva"))
                                );

                                CategoriaVehiculo categoria = new CategoriaVehiculo(
                                    reader.GetInt32(reader.GetOrdinal("IdCategoria")),
                                    reader.GetString(reader.GetOrdinal("CategoriaNombre")),
                                    reader.GetString(reader.GetOrdinal("CategoriaDescripcion"))
                                );

                                Vehiculo vehiculo = new Vehiculo(
                                    reader.GetInt32(reader.GetOrdinal("IdVehiculo")),
                                    reader.GetString(reader.GetOrdinal("VehiculoMarca")),
                                    reader.GetString(reader.GetOrdinal("VehiculoModelo")),
                                    reader.GetInt32(reader.GetOrdinal("VehiculoAnio")),
                                    reader.GetDecimal(reader.GetOrdinal("VehiculoPrecio")),
                                    categoria,
                                    reader.GetString(reader.GetOrdinal("VehiculoEstado"))[0]
                                );

                                Venta venta = new Venta(
                                    cliente,
                                    sucursal,
                                    vehiculo,
                                    reader.GetDateTime(reader.GetOrdinal("FechaVenta")),
                                    reader.GetDecimal(reader.GetOrdinal("Monto"))
                                );
                                ventas.Add(venta);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al consultar las ventas del cliente en la base de datos: " + ex.Message, ex);
                    }
                }
            }
            return ventas;
        }
    }
}
