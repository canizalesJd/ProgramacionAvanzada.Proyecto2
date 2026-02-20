using System.Reflection;
using System.Text.RegularExpressions;
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
    /// Clase de lógica de negocio para la entidad VehiculoXSucursal. Proporciona métodos para registrar la relación entre vehículos y sucursales, así como para consultar las relaciones existentes.
    /// </summary>
    public class VehiculoXSucursalLN
    {
        /// <summary>
        /// Registra la relación entre un vehículo y una sucursal, indicando la cantidad de vehículos disponibles en esa sucursal.
        /// </summary>
        /// <param name="vehiculo">
        /// El objeto Vehiculo que se desea asociar con la sucursal.
        /// </param>
        /// <param name="sucursal">
        /// El objeto Sucursal con el que se desea asociar el vehículo.
        /// </param>
        /// <param name="cantidad">
        /// La cantidad de vehículos disponibles en la sucursal. Este valor debe ser un número entero positivo que indique cuántos vehículos del tipo especificado están disponibles en la sucursal.
        /// </param>
        public void RegistrarVehiculoXSucursal(Vehiculo vehiculo, Sucursal sucursal, int cantidad)
        {
            // Validar los parámetros de entrada
            if (vehiculo == null)
            {
                throw new ArgumentNullException(nameof(vehiculo), "El vehículo no puede ser nulo.");
            }

            if (sucursal == null)
            {
                throw new ArgumentNullException(nameof(sucursal), "La sucursal no puede ser nula.");
            }

            if (cantidad <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La cantidad debe ser mayor que cero.");
            }

            VehiculoXSucursal nuevoVehiculoXSucursal = new VehiculoXSucursal(sucursal,
                vehiculo,
                cantidad
            );
            VehiculoXSucursalAD.Guardar(nuevoVehiculoXSucursal);
        }

        // Método para obtener todas las relaciones entre vehículos y sucursales
        public VehiculoXSucursal[] Consultar()
        {
            return VehiculoXSucursalAD.Consultar();
        }
    }
}
