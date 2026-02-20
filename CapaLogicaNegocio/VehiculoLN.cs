using CapaAccesoDatos;
using CapaEntidades;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Febrero 2026
 */

namespace CapaLogicaNegocio
{
    /// <summary>
    /// Clase de lógica de negocio para la entidad Vehículo.
    /// </summary>
    public class VehiculoLN
    {
        /// <summary>
        /// Método para registrar un nuevo vehículo en el sistema.
        /// </summary>
        public void RegistrarVehiculo(int idVehiculo, string marca, string modelo, int anio, decimal precio, CategoriaVehiculo categoria, char estado)
        {
            if (idVehiculo <= 0) {
                throw new ArgumentException("El ID del vehículo debe ser un número positivo.");
            }
            if (VehiculoAD.VehiculoExiste(idVehiculo)) {
                throw new InvalidOperationException($"El vehículo con ID {idVehiculo} ya existe.");
            }
            if (string.IsNullOrWhiteSpace(marca)) {
                throw new ArgumentException("La marca del vehículo no puede estar vacía.");
            }
            if (string.IsNullOrWhiteSpace(modelo)) {
                throw new ArgumentException("El modelo del vehículo no puede estar vacío.");
            }
            if (anio < 1900 || anio > DateTime.Now.Year + 2) {
                throw new ArgumentException("El año del vehículo debe ser válido.");
            }
            if (precio < 0) {
                throw new ArgumentException("El precio del vehículo no puede ser negativo.");
            }
            if (categoria == null) {
                throw new ArgumentException("Debe asignar una categoría al vehículo.");
            }
            if (estado != 'N' && estado != 'U') {
                throw new ArgumentException("El estado del vehículo debe ser 'N' o 'U'.");
            }
            Vehiculo nuevoVehiculo = new Vehiculo(idVehiculo, 
                marca, 
                modelo, 
                anio, 
                precio, 
                categoria, 
                estado
            );
            VehiculoAD.Guardar(nuevoVehiculo);
        }

        // Método para obtener todos los vehículos
        public Vehiculo[] Consultar()
        {
            return VehiculoAD.Consultar();
        }
    }
}
