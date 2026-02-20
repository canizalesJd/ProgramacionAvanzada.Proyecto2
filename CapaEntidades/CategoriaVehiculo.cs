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
    public class CategoriaVehiculo
    {
        // Propiedades
        public int IdCategoria { get; private set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        /// <summary>
        /// Constructor para inicializar los atributos de una categoría de vehículo, incluyendo el identificador único, nombre y descripción        /// </summary>
        /// <param name="idCategoria">
        /// Identificador único de la categoría de vehículo. Este valor debe ser único para cada categoría registrada en el sistema.
        /// </param>
        /// <param name="nombre">
        /// Nombre de la categoría de vehículo. Este valor representa el nombre descriptivo de la categoría, como Sedán, SUV, Camioneta, etc.
        /// </param>
        /// <param name="descripcion">
        /// Descripción de la categoría de vehículo. Este valor proporciona información adicional sobre la categoría, como características específicas, usos recomendados, etc. Puede ser un texto descriptivo que ayude a los usuarios a entender mejor las diferencias entre las categorías de vehículos disponibles en el sistema.
        /// </param>
        public CategoriaVehiculo(int idCategoria, string nombre, string descripcion)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
