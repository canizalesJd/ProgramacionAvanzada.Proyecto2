using CapaEntidades;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Febrero 2026
 */

namespace CapaAccesoDatos
{
    /// <summary>
    /// Clase de acceso a datos para la entidad CategoriaVehiculo. Esta clase proporciona métodos para almacenar y consultar categorías de vehículos en un arreglo estático.
    /// </summary>
    public class CategoriaVehiculoAD
    {
        // Arreglo estático para almacenar categorías de vehículos, con una capacidad máxima de 20 registros
        private static CategoriaVehiculo[] categorias = new CategoriaVehiculo[20];
        private static int contador;

        /// <summary>
        /// Método para agregar una nueva categoría de vehículo al arreglo. Antes de agregar, verifica que no exista una categoría con el mismo ID y que no se haya alcanzado la capacidad máxima del arreglo. Si alguna de estas condiciones no se cumple, lanza una excepción indicando el error correspondiente.
        /// </summary>
        /// <param name="categoria">
        /// La categoría de vehículo a agregar. Debe contener un ID único que no exista en el arreglo y no debe ser nula.
        /// </param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void Guardar(CategoriaVehiculo categoria)
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
        public static bool CategoriaExiste(int idCategoria)
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
        /// <summary>
        /// Metodo para consultar todas las categorías de vehículos almacenadas en el arreglo. Retorna un nuevo arreglo que contiene solo las categorías agregadas, sin incluir los espacios vacíos del arreglo original. Si no hay categorías almacenadas, retorna un arreglo vacío.
        /// </summary>
        public static CategoriaVehiculo[] Consultar()
        {
            // Retornar solo las categorías agregadas, sin incluir los espacios vacíos del arreglo original usando el contador para determinar cuántas categorías se han agregado.
            CategoriaVehiculo[] resultado = new CategoriaVehiculo[contador];
            Array.Copy(categorias, resultado, contador);
            return resultado;
        }

    }
}
