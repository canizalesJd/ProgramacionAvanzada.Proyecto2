/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Febrero 2026
 */


using System;

namespace CapaEntidades
{
    public class Vendedor : Persona
    {
        public int IdVendedor { get; private set; }
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; }

        // Display member para mostrar la identificacion + nombre completo en los ComboBox
        public string DisplayMember => $"{Identificacion} - {NombreCompleto}";


        public Vendedor(int idVendedor, string identificacion,
            string nombreCompleto, DateTime fechaNacimiento,
            DateTime fechaIngreso, string telefono)
            : base(identificacion, nombreCompleto, fechaNacimiento)
        {
            IdVendedor = idVendedor;
            FechaIngreso = fechaIngreso;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"Vendedor: {NombreCompleto} - ID: {Identificacion} - Fecha Ingreso: {FechaIngreso}";
        }
    }
}
