/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: Jose David Canizales Azocar
 * Fecha: Febrero 2026
 */


namespace CapaEntidades
{
    public class Cliente : Persona
    {
        public int IdCliente { get; private set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        public Cliente(int idCliente, string identificacion,
            string nombreCompleto, DateTime fechaNacimiento,
            DateTime fechaRegistro, bool activo)
            : base(identificacion, nombreCompleto, fechaNacimiento)
        {
            IdCliente = idCliente;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }

        public override string ToString()
        {
            return $"Cliente: {NombreCompleto} - ID: {Identificacion} - Activo: {(Activo ? "Sí" : "No")}";
        }
    }
}
