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
    public class Vehiculo
    {
        // Propiedades
        public int IdVehiculo { get; private set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal Precio { get; set; }
        public CategoriaVehiculo Categoria { get; set; }
        private char _estado;
        public char Estado
        {
            get => _estado;
            set
            {
                if (value != 'N' && value != 'U')
                    throw new ArgumentException("Estado debe ser 'N' o 'U'");
                _estado = value;
            }
        }
        // Constructor
        public Vehiculo(int idVehiculo, string marca, string modelo, int anio, decimal precio, CategoriaVehiculo categoria, char estado)
        {
            IdVehiculo = idVehiculo;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
            Categoria = categoria;
            Estado = estado;
        }
        public override string ToString()
        {
            string estadoDescripcion = Estado == 'N' ? "Sí" : "No";
            return $"{Marca} {Modelo} ({Anio}) - ₡ {Precio} - Categoría: {Categoria.Nombre} - Estado: {estadoDescripcion}";
        }
    }
}
