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
    /// Clase que representa la entidad de Sucursal, que incluye propiedades como IdSucursal, Nombre, Dirección, Teléfono y un objeto Vendedor que representa al vendedor encargado de la sucursal.
    /// </summary>
    public class Sucursal
    {
        // Propiedades de la sucursal, incluyendo un identificador único, nombre, dirección, teléfono y un objeto Vendedor que representa al vendedor encargado de la sucursal.
        public int IdSucursal { get; private set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Vendedor VendedorEncargado { get; set; }

        public bool Activa { get; set; } = true;

        /// <summary>
        /// Constructor para inicializar los atributos de la sucursal, incluyendo el identificador único, nombre, dirección, teléfono y el vendedor encargado.
        /// </summary>
        /// <param name="idSucursal">
        /// Identificador único de la sucursal. Este valor debe ser único para cada sucursal.
        /// </param>
        /// <param name="nombre">
        /// Nombre de la sucursal. Este valor representa el nombre comercial de la sucursal.
        /// </param>
        /// <param name="direccion">
        /// Dirección física de la sucursal. Este valor representa la ubicación de la sucursal.
        /// </param>
        /// <param name="telefono">
        /// Número de teléfono de la sucursal. Este valor representa el contacto telefónico para la sucursal.
        /// </param>
        /// <param name="vendedorEncargado">
        /// Objeto Vendedor que representa al vendedor encargado de la sucursal. Este valor debe ser una instancia válida de la clase Vendedor que esté asignada como responsable de la sucursal.
        /// </param>
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
