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
    /// Clase que representa la entidad de Persona, que sirve como clase base para otras entidades como Cliente. Esta clase incluye propiedades comunes a todas las personas, como identificación, nombre completo y fecha de nacimiento.
    /// </summary>
    public class Persona
    {
        // Propiedades comunes a todas las personas, como identificación, nombre completo y fecha de nacimiento.
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Constructor para inicializar los atributos de la persona.
        /// </summary>
        /// <param name="identificacion">Identificación de la persona.</param>
        /// <param name="nombreCompleto">Nombre completo de la persona.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento de la persona.</param>
        public Persona(string identificacion, string nombreCompleto, DateTime fechaNacimiento)
        {
            Identificacion = identificacion;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
