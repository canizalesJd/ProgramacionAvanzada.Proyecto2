/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Febrero 2026
 */

// Referencias
// [1] - Formato de moneda: https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#code-example


using System.Globalization;

namespace CapaEntidades
{
    /// <summary>
    /// Clase que representa la relación entre un vehículo y una sucursal
    /// </summary>
    public class VehiculoXSucursal
    {
        // Propiedades que representan la relación entre un vehículo y una sucursal, incluyendo la cantidad de vehículos disponibles en esa sucursal. La propiedad Sucursal es de tipo Sucursal, la propiedad Vehiculo es de tipo Vehiculo, y la propiedad Cantidad es un entero que indica cuántos vehículos de ese tipo hay en la sucursal.
        public Sucursal Sucursal { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int Cantidad { get; set; }

        // Propiedades estaticas para el UI

        // Propiedad para mostrar el nombre de la sucursal
        public string NombreSucursal => Sucursal.Nombre;

        // Propiedad para mostrar el año, marca y modelo del vehículo
        public string DescripcionVehiculo => Vehiculo.DisplayMember;

        // Propiedad para mostrar la categoría del vehículo
        public string CategoriaNombre => Vehiculo.Categoria.Nombre;

        // Propiedad para mostrar el estado en formato legible
        public string EstadoTexto => Vehiculo.Estado == 'N' ? "Nuevo" : "Usado";
        // Propiedad para mostrar el precio en formato de moneda CRC
        public string PrecioTexto => Vehiculo.Precio.ToString("C", new CultureInfo("es-CR")); // [1]
        // Propiedad para mostrar el nombre de la categoría del vehículo

        /// <summary>
        /// Constructor para inicializar los atributos de la asociación entre un vehículo y una sucursal.
        /// </summary>
        public VehiculoXSucursal(Sucursal sucursal, Vehiculo vehiculo, int cantidad)
        {
                Sucursal = sucursal;
                Vehiculo = vehiculo;
                Cantidad = cantidad;
        }
    }
}
