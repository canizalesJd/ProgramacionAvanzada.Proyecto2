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
    /// Clase de acceso a datos para la entidad Sucursal. Esta clase proporciona métodos para almacenar y consultar sucursales en un arreglo estático.
    /// </summary>
    public class SucursalAD
    {
        // Arreglo estático para almacenar sucursales, con una capacidad máxima de 5 registros
        private static Sucursal[] sucursales = new Sucursal[5];
        private static int contador;

        /// <summary>
        /// Metodo para guardar una nueva sucursal en el arreglo. Antes de agregar una nueva sucursal, se realizan las siguientes validaciones:
        /// </summary>
        /// <param name="sucursal"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void Guardar(Sucursal sucursal)
        {
            // Evitar duplicados: Antes de agregar una nueva sucursal, verificar que no exista una sucursal con el mismo ID. Si ya existe, lanzar una excepción indicando que la sucursal ya existe.
            if (SucursalExiste(sucursal.IdSucursal))
            {
                throw new InvalidOperationException("La sucursal con el ID proporcionado ya existe.");
            }
            // Verificar capacidad: Antes de agregar una nueva sucursal, verificar que el arreglo no haya alcanzado su capacidad máxima de 5 registros. Si se intenta agregar más allá de esta capacidad, lanzar una excepción indicando que no se pueden agregar más sucursales.
            if (contador >= sucursales.Length)
            {
                throw new InvalidOperationException("No se pueden agregar más sucursales, capacidad máxima alcanzada.");
            }
            sucursales[contador] = sucursal;
            contador++;
        }

        /// <summary>
        /// Método para verificar si una sucursal existe por su ID
        /// </summary>
        /// <param name="idSucursal">
        /// ID de la sucursal que se desea verificar.
        /// </param>
        public static bool SucursalExiste(int idSucursal)
        {
            for (int i = 0; i < contador; i++)
            {
                if (sucursales[i].IdSucursal == idSucursal)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Método para obtener todas las sucursales. Retorna solo las sucursales agregadas.
        /// </summary>
        public static Sucursal[] Consultar()
        {
            Sucursal[] resultado = new Sucursal[contador];
            Array.Copy(sucursales, resultado, contador);
            return resultado;
        }
    }
}
