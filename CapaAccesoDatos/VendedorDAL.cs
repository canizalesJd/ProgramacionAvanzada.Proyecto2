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
    public class VendedorDAL
    {
        private Vendedor[] vendedores;
        private int contador;

        // Constructor
        public VendedorDAL()
        {
            // Los datos deben almacenarse en un arreglo de objetos Vendedor con capacidad para 20 registros.
            vendedores = new Vendedor[20];
            contador = 0;
        }

        // Método para agregar un nuevo vendedor
        public void AgregarVendedor(Vendedor vendedor)
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
        public bool VendedorExiste(int idVendedor)
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
        public Vendedor[] ObtenerVendedores()
        {
            Vendedor[] resultado = new Vendedor[contador];
            Array.Copy(vendedores, resultado, contador);
            return resultado;
        }
    }
}
