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
    /// Clase de lógica de negocio para la entidad CategoriaVehiculo. Proporciona métodos para registrar nuevas categorías de vehículo y consultar las categorías existentes.
    /// </summary>
    public class CategoriaVehiculoLN
    {
        /// <summary>
        /// Metodo para registrar una nueva categoría de vehículo.
        /// </summary>
        /// <param name="id">
        /// El ID de la categoría, debe ser un número positivo y único.
        /// </param>
        /// <param name="nombre">
        /// El nombre de la categoría, no puede estar vacío.
        /// </param>
        /// <param name="descripcion">
        /// La descripción de la categoría, no puede estar vacía.
        /// </param>
        /// <exception cref="ArgumentException"></exception>
        public void RegistrarCategoria(int id, string nombre, string descripcion)
        {
            // Validaciones de entrada
            if (CategoriaVehiculoAD.CategoriaExiste(id))
            {
                throw new ArgumentException($"Ya existe una categoría con el ID {id}, ingrese un ID distinto.");
            }

            if (id <= 0)
            {
                throw new ArgumentException("El ID de la categoría debe ser un número positivo.");
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentException("La descripción de la categoría no puede estar vacía.");
            }

            // Crear una nueva instancia de CategoriaVehiculo y guardarla usando la capa de acceso a datos
            CategoriaVehiculo nueva = new CategoriaVehiculo(
                id, 
                nombre, 
                descripcion
            );
            CategoriaVehiculoAD.Guardar(nueva);
        }

        /// <summary>
        /// Metodo para consultar todas las categorías de vehículo registradas. Devuelve un arreglo de objetos CategoriaVehiculo.
        /// </summary>
        public CategoriaVehiculo[] Consultar()
        {
            return CategoriaVehiculoAD.Consultar();
        }
    }
}
