/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Febrero 2026
 */

namespace CapaEntidades
{
    /// <summary>
    /// Clase que representa la relación entre un vehículo y una sucursal, indicando cuántos vehículos de ese tipo hay disponibles en esa sucursal.
    /// </summary>
    public class VehiculoXSucursal
    {
        // Propiedades que representan la relación entre un vehículo y una sucursal, incluyendo la cantidad de vehículos disponibles en esa sucursal. La propiedad Sucursal es de tipo Sucursal, la propiedad Vehiculo es de tipo Vehiculo, y la propiedad Cantidad es un entero que indica cuántos vehículos de ese tipo hay en la sucursal.
        public Sucursal Sucursal { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int Cantidad { get; set; }

        /// <summary>
        /// Constructor para inicializar los atributos de la relación entre un vehículo y una sucursal.
        /// </summary>
        /// <param name="sucursal">
        /// Sucursal a la que pertenece el vehículo. Este valor debe ser una instancia válida de la clase Sucursal que esté registrada en el sistema, y representa la sucursal donde se encuentra disponible el vehículo.
        /// </param>
        /// <param name="vehiculo">
        /// Vehículo que está disponible en la sucursal. Este valor debe ser una instancia válida de la clase Vehiculo que esté registrada en el sistema, y representa el vehículo específico que se encuentra disponible en la sucursal.
        /// </param>
        /// <param name="cantidad">
        /// Cantidad de vehículos disponibles en la sucursal. Este valor debe ser un número entero positivO.
        /// </param>
        public VehiculoXSucursal(Sucursal sucursal, Vehiculo vehiculo, int cantidad)
        {
                Sucursal = sucursal;
                Vehiculo = vehiculo;
                Cantidad = cantidad;
        }
    }
}
