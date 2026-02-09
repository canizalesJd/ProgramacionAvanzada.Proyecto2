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
    public class Sucursal
    {
        public int IdSucursal { get; private set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Vendedor VendedorEncargado { get; set; }
        public Sucursal(int idSucursal, string nombre, string direccion, string telefono, Vendedor vendedorEncargado)
        {
            IdSucursal = idSucursal;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            VendedorEncargado = vendedorEncargado;
        }
        public override string ToString()
        {
            return $"Sucursal: {Nombre} - Dirección: {Direccion} - Tel: {Telefono} - Encargado: {VendedorEncargado}";
        }
    }
}
