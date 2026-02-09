using CapaEntidades;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: Jose David Canizales Azocar
 * Fecha: Febrero 2026
 */

namespace CapaAccesoDatos
{
    public class CategoriaVehiculoDAL
    {
        private CategoriaVehiculo[] categorias;
        private int contador;

        // Constructor
        public CategoriaVehiculoDAL()
        {
            // Los datos deben almacenarse en un arreglo de objetos CategoriaVehiculo con capacidad para 20 registros 
            categorias = new CategoriaVehiculo[20];
            contador = 0;
        }

        // Método para agregar una nueva categoría de vehículo
        public void AgregarCategoria(CategoriaVehiculo categoria)
        {
            // Evitar duplicados: Antes de agregar una nueva categoría, verificar que no exista una categoría con el mismo ID. Si ya existe, lanzar una excepción indicando que la categoría ya existe.
            if (CategoriaExiste(categoria.IdCategoria))
            {
                throw new InvalidOperationException("La categoría con el ID proporcionado ya existe.");
            }

            // Verificar capacidad: Antes de agregar una nueva categoría, verificar que el arreglo no haya alcanzado su capacidad máxima de 20 registros. Si se intenta agregar más allá de esta capacidad, lanzar una excepción indicando que no se pueden agregar más categorías.
            if (contador >= categorias.Length)
            {
                throw new InvalidOperationException("No se pueden agregar más categorías, capacidad máxima alcanzada.");
            }
            
            categorias[contador] = categoria;
            contador++;
        }

        // Metodo para verificar si una categoría de vehículo existe por su ID
        public bool CategoriaExiste(int idCategoria)
        {
            for (int i = 0; i < contador; i++)
            {
                if (categorias[i].IdCategoria == idCategoria)
                {
                    return true;
                }
            }
            return false;
        }

        // Método para obtener todas las categorías de vehículo
        public CategoriaVehiculo[] ObtenerCategorias()
        {
            // Retorna solo las categorías agregadas, no los espacios vacíos del arreglo
            CategoriaVehiculo[] resultado = new CategoriaVehiculo[contador];
            Array.Copy(categorias, resultado, contador);
            return resultado;
        }

    }
}
