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
    /// Clase que representa la entidad de Vehículo. Se utiliza para representar los vehículos disponibles en el sistema de gestión de ventas de vehículos.
    /// </summary>
    public class Vehiculo
    {
        // Propiedades
        public int IdVehiculo { get; private set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal Precio { get; set; }
        public CategoriaVehiculo Categoria { get; set; }
        public char Estado { get; set; }
        /// <summary>
        /// Constructor para inicializar los atributos de un vehículo, incluyendo el identificador único, marca, modelo, año, precio, categoría y estado. El estado debe ser 'N' para vehículos nuevos o 'U' para vehículos usados. Si se proporciona un estado diferente, se lanzará una excepción indicando que el estado no es válido.
        /// </summary>
        /// <param name="idVehiculo">
        /// Identificador único del vehículo. Este valor debe ser único para cada vehículo registrado en el sistema.
        /// </param>
        /// <param name="marca">
        /// Marca del vehículo. Este valor representa la marca comercial del vehículo, como Toyota, Honda, Ford, etc.
        /// </param>
        /// <param name="modelo">
        /// Modelo del vehículo. Este valor representa el modelo específico del vehículo, como Corolla, Civic, Mustang, etc.
        /// </param>
        /// <param name="anio">
        /// Año de fabricación del vehículo. Este valor representa el año en que el vehículo fue fabricado, y debe ser un número entero válido que corresponda a un año realista para vehículos.
        /// </param>
        /// <param name="precio">
        /// Precio del vehículo. Este valor representa el costo del vehículo en colones costarricenses (₡) y debe ser un número decimal positivo que refleje el valor comercial del vehículo.
        /// </param>
        /// <param name="categoria">
        /// Categoría del vehículo. Este valor representa la categoría a la que pertenece el vehículo, como Sedán, SUV, Camioneta, etc. Debe ser una instancia válida de la clase CategoriaVehiculo que esté registrada en el sistema.
        /// </param>
        /// <param name="estado">
        /// Estado del vehículo. Este valor representa si el vehículo es nuevo ('N') o usado ('U'). Solo se permiten estos dos valores, y cualquier otro valor resultará en una excepción indicando que el estado no es válido.
        /// </param>
        public Vehiculo(int idVehiculo, string marca, string modelo, int anio, decimal precio, CategoriaVehiculo categoria, char estado)
        {
            // Validar que el estado sea 'N' o 'U'. Si se proporciona un valor diferente, lanzar una excepción indicando que el estado no es válido.
            if (estado != 'N' && estado != 'U')
                throw new ArgumentException("Estado debe ser 'N' o 'U'");

            IdVehiculo = idVehiculo;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
            Categoria = categoria;
            Estado = estado;
        }
    }
}
