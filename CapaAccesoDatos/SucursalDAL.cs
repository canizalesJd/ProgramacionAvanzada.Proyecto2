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
    public class SucursalDAL
    {
        private Sucursal[] sucursales;
        private int contador;

        // Constructor
        public SucursalDAL()
        {
            // Los datos deben almacenarse en un arreglo de objetos Sucursal con capacidad para 5 registros.
            sucursales = new Sucursal[5];
            contador = 0;
        }

        // Método para agregar una nueva sucursal
        public void AgregarSucursal(Sucursal sucursal)
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

        // Método para verificar si una sucursal existe por su ID
        public bool SucursalExiste(int idSucursal)
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

        // Método para obtener todas las sucursales
        public Sucursal[] ObtenerSucursales()
        {
            Sucursal[] resultado = new Sucursal[contador];
            Array.Copy(sucursales, resultado, contador);
            return resultado;
        }
    }
}
