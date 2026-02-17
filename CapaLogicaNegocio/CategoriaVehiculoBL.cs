using CapaAccesoDatos;
using CapaEntidades;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: Jose David Canizales Azocar
 * Fecha: Febrero 2026
 */

namespace CapaLogicaNegocio
{
    public class CategoriaVehiculoBL
    {
        // Metodo para registrar una nueva categoría de vehículo
        public void RegistrarCategoria(int id, string nombre, string descripcion)
        {
            if (CategoriaVehiculoDAL.CategoriaExiste(id))
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

            CategoriaVehiculo nueva = new CategoriaVehiculo(
                id, 
                nombre, 
                descripcion
            );
            CategoriaVehiculoDAL.Guardar(nueva);
        }

        // Metodo para obtener todas las categorías de vehículo
        public CategoriaVehiculo[] ObtenerCategorias()
        {
            return CategoriaVehiculoDAL.Consultar();
        }
    }
}
