using CapaEntidades;

namespace CapaAccesoDatos
{
    public class VehiculoXSucursalAD
    {
        // Arreglo estático para almacenar las relaciones entre vehículos y sucursales, con una capacidad máxima de 100 registros
        private static VehiculoXSucursal[] vehiculosXSucursal = new VehiculoXSucursal[100];
        private static int contador;

        /// <summary>
        /// Método para guardar una nueva relación entre un vehículo y una sucursal.
        /// </summary>
        public static void Guardar(VehiculoXSucursal vehiculoXSucursal)
        {
            // Validar que el objeto no sea nulo
            if (vehiculoXSucursal == null)
            {
                throw new ArgumentNullException(nameof(vehiculoXSucursal), "No se puede guardar una relación nula entre vehículo y sucursal.");
            }

            // Validar que el vehículo y la sucursal no sean nulos
            if (vehiculoXSucursal.Vehiculo == null)
            {
                throw new ArgumentException("El vehículo no puede ser nulo.", nameof(vehiculoXSucursal));
            }

            if (vehiculoXSucursal.Sucursal == null)
            {
                throw new ArgumentException("La sucursal no puede ser nula.", nameof(vehiculoXSucursal));
            }

            // Validar que la relacion no sea duplicada
            if (VehiculoXSucursalExiste(vehiculoXSucursal.Vehiculo.IdVehiculo, vehiculoXSucursal.Sucursal.IdSucursal))
            {
                throw new InvalidOperationException("La relación entre el vehículo y la sucursal ya existe.");
            }

            // Validar que la cantidad sea un número positivo
            if (vehiculoXSucursal.Cantidad < 0)
            {
                throw new ArgumentException("La cantidad debe ser un número positivo.");
            }

            // Verificar capacidad: Antes de agregar una nueva relación entre vehículo y sucursal, verificar que el arreglo no haya alcanzado su capacidad máxima de 100 registros. Si se intenta agregar más allá de esta capacidad, lanzar una excepción indicando que no se pueden agregar más relaciones.
            if (contador >= vehiculosXSucursal.Length)
            {
                throw new InvalidOperationException("No se pueden agregar más relaciones entre vehículos y sucursales, capacidad máxima alcanzada.");
            }
            vehiculosXSucursal[contador] = vehiculoXSucursal;
            contador++;
        }

        /// <summary>
        /// Método para verificar si una relación entre un vehículo y una sucursal ya existe en el arreglo
        /// </summary>
        public static bool VehiculoXSucursalExiste(int idVehiculo, int idSucursal)
        {
            for (int i = 0; i < contador; i++)
            {
                if (vehiculosXSucursal[i].Vehiculo.IdVehiculo == idVehiculo 
                    && vehiculosXSucursal[i].Sucursal.IdSucursal == idSucursal)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Método para consultar todas las relaciones entre vehículos y sucursales almacenadas en el arreglo.
        /// </summary>
        public static VehiculoXSucursal[] Consultar()
        {
            // Retornar solo los registros válidos del arreglo, es decir, aquellos que han sido agregados hasta el contador actual. Esto evita retornar elementos nulos o no inicializados.
            VehiculoXSucursal[] resultado = new VehiculoXSucursal[contador];
            Array.Copy(vehiculosXSucursal, resultado, contador);
            return resultado;
        }
    }
}
