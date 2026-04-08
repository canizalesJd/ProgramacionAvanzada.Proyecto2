/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

namespace Servidor.Comunicacion
{
    public class Mensaje
    {
        // Propiedades 
        public string Accion { get; set; }
        public string Tipo { get; set; }
        public string Datos { get; set; }

        // Constructor vacio
        public Mensaje() { 
            Accion = string.Empty;
            Tipo = string.Empty;
            Datos = string.Empty;
        }

        // Constructor con parámetros
        public Mensaje(string accion, string tipo, string datos)
        {
            Accion = accion;
            Tipo = tipo;
            Datos = datos;
        }
    }
}
