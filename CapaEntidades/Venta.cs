/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

namespace CapaEntidades
{
    /// <summary>
    /// Clase que representa la entidad de Venta, que contiene información sobre una venta realizada
    /// </summary>
    public class Venta
    {
        // Atributos
        private Cliente Cliente { get; set; }
        private Sucursal Sucursal { get; set; }
        private Vendedor Vendedor { get; set; }
        private Vehiculo Vehiculo { get; set; }
        private DateTime FechaVenta { get; set; }
        private decimal Monto { get; set; }

        /// <summary>
        /// Constructor para inicializar los atributos de la venta.
        /// </summary>
        public Venta(Cliente cliente, Sucursal sucursal, Vendedor vendedor, Vehiculo vehiculo, DateTime fechaVenta, decimal monto)
        {
            Cliente = cliente;
            Sucursal = sucursal;
            Vendedor = vendedor;
            Vehiculo = vehiculo;
            FechaVenta = fechaVenta;
            Monto = monto;
        }
    }
}
