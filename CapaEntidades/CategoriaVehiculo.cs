using System;

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
    public class CategoriaVehiculo
    {
        // Propiedades
        public int IdCategoria { get; private set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Constructor
        public CategoriaVehiculo(int idCategoria, string nombre, string descripcion)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"Categoría: {Nombre} - {Descripcion}";
        }
    }
}
