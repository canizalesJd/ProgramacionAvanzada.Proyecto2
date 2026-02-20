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
    /// Clase de lógica de negocio para la entidad VehiculoXSucursal.
    /// </summary>
    public class VehiculoXSucursalLN
    {
        /// <summary>
        /// Registra la relación entre un vehículo y una sucursal.
        /// </summary>
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
