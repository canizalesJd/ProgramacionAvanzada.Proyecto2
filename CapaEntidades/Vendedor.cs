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
    /// Clase que representa la entidad de Vendedor, que hereda de Persona
    /// </summary>
    public class Vendedor : Persona
    {
        // Propiedades específicas de Vendedor
        public int IdVendedor { get; private set; }
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; }

        // Display member para mostrar la identificacion + nombre completo en los ComboBox
        public string DisplayMember => $"{Identificacion} - {NombreCompleto}";

        // Constructor que inicializa las propiedades de Vendedor, incluyendo las propiedades heredadas de Persona
        public Vendedor(int idVendedor, string identificacion,
            string nombreCompleto, DateTime fechaNacimiento,
            DateTime fechaIngreso, string telefono)
            : base(identificacion, nombreCompleto, fechaNacimiento)
        {
            IdVendedor = idVendedor;
            FechaIngreso = fechaIngreso;
            Telefono = telefono;
        }
    }
}
