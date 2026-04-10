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
namespace CapaLogicaNegocio
{

    /// <summary>
    /// Clase de lógica de negocio para la gestión de ventas.
    /// </summary>
    public class VentaLN
    {
        public static readonly object candadoVenta = new object();

        // Metodo para registrar una nueva venta
        public void RegistrarVenta(Cliente cliente, Sucursal sucursal, Vehiculo vehiculo, DateTime fechaVenta, decimal monto)
        {
            if (cliente == null)
                throw new InvalidOperationException("El cliente no puede ser nulo.");

            if (sucursal == null)
                throw new InvalidOperationException("La sucursal no puede ser nula.");

            if (vehiculo == null)
                throw new InvalidOperationException("El vehículo no puede ser nulo.");

            if (!cliente.Activo)
                throw new InvalidOperationException("El cliente está inactivo y no puede realizar compras.");

            if (fechaVenta == default)
                fechaVenta = DateTime.Now;

            if (monto <= 0)
                throw new ArgumentException("El monto de la venta debe ser mayor a cero.");

            // Verificar que el vehículo esté disponible en la sucursal
            lock (candadoVenta)
            {
                int cantidadDisponible = VehiculoXSucursalAD.ConsultarCantidad(sucursal.IdSucursal, vehiculo.IdVehiculo);

                if (cantidadDisponible <= 0)
                    throw new InvalidOperationException("No hay stock disponible para este vehículo en la sucursal seleccionada.");

                VehiculoXSucursalAD.ActualizarCantidad(sucursal.IdSucursal, vehiculo.IdVehiculo, cantidadDisponible - 1);

                Venta nuevaVenta = new Venta(cliente, sucursal, vehiculo, fechaVenta, monto);
                VentaAD.Guardar(nuevaVenta);
            }
        }
    }
}
