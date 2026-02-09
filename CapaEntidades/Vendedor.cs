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
    public class Vendedor
    {
        public int IdVendedor { get; private set; }
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; }

        public Vendedor(int idVendedor, string identificacion, string nombreCompleto, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono)
        {
            IdVendedor = idVendedor;
            Identificacion = identificacion;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
            FechaIngreso = fechaIngreso;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"Vendedor: {NombreCompleto} - ID: {Identificacion} - Tel: {Telefono}";
        }
    }
}
