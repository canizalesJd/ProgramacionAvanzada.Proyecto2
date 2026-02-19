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
    /// Clase abstracta que representa a una persona en el sistema.
    /// </summary>
    public abstract class Persona
    {
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Constructor protegido para inicializar los atributos de la persona.
        /// </summary>
        /// <param name="identificacion">Identificación de la persona.</param>
        /// <param name="nombreCompleto">Nombre completo de la persona.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento de la persona.</param>
        protected Persona(string identificacion, string nombreCompleto, DateTime fechaNacimiento)
        {
            Identificacion = identificacion;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
