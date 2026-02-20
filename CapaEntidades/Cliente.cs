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
    /// Clase que representa la entidad de Cliente, que hereda de la clase Persona. Esta clase incluye propiedades específicas para el cliente, como IdCliente, FechaRegistro y Activo, además de las propiedades heredadas de Persona como Identificacion, NombreCompleto y FechaNacimiento.
    /// </summary>
    public class Cliente : Persona
    {
        // Propiedades específicas de Cliente
        public int IdCliente { get; private set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        // Constructor que inicializa las propiedades de Cliente, incluyendo las propiedades heredadas de Persona
        public Cliente(int idCliente, string identificacion,
            string nombreCompleto, DateTime fechaNacimiento,
            DateTime fechaRegistro, bool activo)
            : base(identificacion, nombreCompleto, fechaNacimiento)
        {
            IdCliente = idCliente;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }
    }
}
