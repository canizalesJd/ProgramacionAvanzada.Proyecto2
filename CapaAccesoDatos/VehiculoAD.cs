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
    public class VehiculoAD
    {
        private static Vehiculo[] vehiculos = new Vehiculo[50];
        private static int contador;

        // Método para agregar un nuevo vehículo
        public static void Guardar(Vehiculo vehiculo)
        {
            // Evitar duplicados: Antes de agregar un nuevo vehículo, verificar que no exista un vehículo con el mismo ID. Si ya existe, lanzar una excepción indicando que el vehículo ya existe.
            if (VehiculoExiste(vehiculo.IdVehiculo))
            {
                throw new InvalidOperationException("El vehículo con el ID proporcionado ya existe.");
            }

            // Verificar capacidad: Antes de agregar un nuevo vehículo, verificar que el arreglo no haya alcanzado su capacidad máxima de 50 registros. Si se intenta agregar más allá de esta capacidad, lanzar una excepción indicando que no se pueden agregar más vehículos.
            if (contador >= vehiculos.Length)
            {
                throw new InvalidOperationException("No se pueden agregar más vehículos, capacidad máxima alcanzada.");
            }
            vehiculos[contador] = vehiculo;
            contador++;
        }

        // Método para verificar si un vehículo existe por su ID
        public static bool VehiculoExiste(int idVehiculo)
        {
            for (int i = 0; i < contador; i++)
            {
                if (vehiculos[i].IdVehiculo == idVehiculo)
                {
                    return true;
                }
            }
            return false;
        }

        // Método para obtener todos los vehículos
        public static Vehiculo[] Consultar()
        {
            // Retorna solo los vehículos agregados, no los espacios vacíos del arreglo
            Vehiculo[] resultado = new Vehiculo[contador];
            Array.Copy(vehiculos, resultado, contador);
            return resultado;
        }
    }
}
