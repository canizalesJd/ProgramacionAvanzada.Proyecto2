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
    /// Clase que representa la entidad de Categoría de Vehículo
    /// </summary>
    public class CategoriaVehiculo
    {
        // Propiedades
        public int IdCategoria { get; private set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        /// <summary>
        /// Constructor para inicializar los atributos de una categoría de vehículo, incluyendo el identificador único, nombre y descripción
        /// </summary>
        public CategoriaVehiculo(int idCategoria, string nombre, string descripcion)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
