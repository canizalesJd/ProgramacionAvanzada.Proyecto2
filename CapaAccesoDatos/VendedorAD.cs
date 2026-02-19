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
    public class VendedorAD
    {
        private static Vendedor[] vendedores = new Vendedor[20];
        private static int contador = 0;

        // Método para agregar un nuevo vendedor

        // <summary>
        // Método que agrega un nuevo vendedor al arreglo de vendedores. Antes de agregar, verifica que no exista un vendedor con el mismo ID y que no se haya alcanzado la capacidad máxima de 20 registros. Si se intenta agregar un vendedor con un ID duplicado o si se ha alcanzado la capacidad máxima, se lanzará una excepción indicando el error correspondiente.
        // </summary>
        // <param name="vendedor">El objeto Vendedor que se desea agregar.</param>
        public static void Guardar(Vendedor vendedor)
        {
            // Evitar duplicados: Antes de agregar un nuevo vendedor, verificar que no exista un vendedor con el mismo ID. Si ya existe, lanzar una excepción indicando que el vendedor ya existe.
            if (VendedorExiste(vendedor.IdVendedor))
            {
                throw new InvalidOperationException("El vendedor con el ID proporcionado ya existe.");
            }
            // Verificar capacidad: Antes de agregar un nuevo vendedor, verificar que el arreglo no haya alcanzado su capacidad máxima de 20 registros. Si se intenta agregar más allá de esta capacidad, lanzar una excepción indicando que no se pueden agregar más vendedores.
            if (contador >= vendedores.Length)
            {
                throw new InvalidOperationException("No se pueden agregar más vendedores, capacidad máxima alcanzada.");
            }

            vendedores[contador] = vendedor;
            contador++;
        }

        // Método para verificar si un vendedor existe por su ID
        public static bool VendedorExiste(int idVendedor)
        {
            for (int i = 0; i < contador; i++)
            {
                if (vendedores[i].IdVendedor == idVendedor)
                {
                    return true;
                }
            }
            return false;
        }

        // Método para obtener todos los vendedores
        public static Vendedor[] Consultar()
        {
            Vendedor[] resultado = new Vendedor[contador];
            Array.Copy(vendedores, resultado, contador);
            return resultado;
        }
    }
}
