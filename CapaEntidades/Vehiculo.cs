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
    /// Clase que representa la entidad de Vehículo.
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

        // Display member para mostrar el anio + marca + modelo en los ComboBox
        public string DisplayMember => $"{Anio} - {Marca} {Modelo}";
        // Propiedad para mostrar el estado en formato legible
        public string EstadoTexto => Estado == 'N' ? "Nuevo" : "Usado";
        // Propiedad para mostrar el precio en formato de moneda CRC
        public string PrecioTexto => Precio.ToString("C", new CultureInfo("es-CR")); // [1]
        // Propiedad para mostrar el nombre de la categoría del vehículo
        public string CategoriaNombre => Categoria.Nombre;
        // Propiedad para mostrar la descripcion de la categoría del vehículo
        public string CategoriaDescripcion => Categoria.Descripcion;
        /// <summary>
        /// Constructor para inicializar los atributos de un vehículo.
        /// </summary>
        public Vehiculo(int idVehiculo, string marca, string modelo, int anio, decimal precio, CategoriaVehiculo categoria, char estado)
        {
            // Validar que el estado sea 'N' o 'U'
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
