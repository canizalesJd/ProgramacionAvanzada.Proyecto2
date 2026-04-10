/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

// Referencias
// [1] - Formato de moneda: https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#code-example

using System.Globalization;

namespace CapaEntidades
{
    /// <summary>
    /// Clase que representa la entidad de Venta, que contiene información sobre una venta realizada
    /// </summary>
    public class Venta
    {
        // Atributos
        public int IdVenta { get; private set; }
        public Cliente Cliente { get; set; }
        public Sucursal Sucursal { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Monto { get; set; }

        // Propiedades solo para mostrar en UI
        public string ClienteNombre => Cliente.NombreCompleto;
        public string SucursalNombre => Sucursal.Nombre;
        public string VehiculoDescripcion => Vehiculo.DisplayMember;
        public string VendedorNombre => Sucursal.VendedorEncargado.NombreCompleto;
        public string VehiculoPrecioTexto => Vehiculo.Precio.ToString("C", new CultureInfo("es-CR")); // [1]
        public string MontoTexto => Monto.ToString("C", new CultureInfo("es-CR")); // [1]

        /// <summary>
        /// Constructor para inicializar los atributos de la venta.
        /// </summary>
        public Venta(Cliente cliente, Sucursal sucursal, Vehiculo vehiculo, DateTime fechaVenta, decimal monto)
        {
            Cliente = cliente;
            Sucursal = sucursal;
            Vehiculo = vehiculo;
            FechaVenta = fechaVenta;
            Monto = monto;
        }
    }
}
