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
    /// Clase que representa la entidad de Sucursal.
    /// </summary>
    public class Sucursal
    {
        // Propiedades de la sucursal
        public int IdSucursal { get; private set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Vendedor VendedorEncargado { get; set; }

        public bool Activa { get; set; } = true;

        /// <summary>
        /// Constructor para inicializar los atributos de la sucursal
        /// </summary>
        public Sucursal(int idSucursal, string nombre, string direccion, string telefono, Vendedor vendedorEncargado, bool activa)
        {
            IdSucursal = idSucursal;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            VendedorEncargado = vendedorEncargado;
            Activa = activa;
        }
    }
}
