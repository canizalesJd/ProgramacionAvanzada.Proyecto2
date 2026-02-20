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
    /// Clase de lógica de negocio para la entidad Sucursal.
    /// </summary>
    public class SucursalLN
    {
        /// <summary>
        /// Método para registrar una nueva sucursal
        /// </summary>
        public void RegistrarSucursal(int idSucursal, string nombre, string direccion, string telefono, Vendedor vendedorEncargado, bool activa)
        {
            // Validación de datos de entrada
            if (idSucursal <= 0)
            {
                throw new ArgumentException("El ID de la sucursal debe ser un número positivo.");
            }
            if (SucursalAD.SucursalExiste(idSucursal))
            {
                throw new InvalidOperationException($"La sucursal con ID {idSucursal} ya existe.");
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre de la sucursal no puede estar vacío.");
            }
            if (string.IsNullOrWhiteSpace(direccion))
            {
                throw new ArgumentException("La dirección de la sucursal no puede estar vacía.");
            }
            if (string.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentException("El teléfono de la sucursal no puede estar vacío.");
            }
            if (vendedorEncargado == null)
            {
                throw new ArgumentException("Debe asignar un vendedor encargado a la sucursal.");
            }
            // Crear y guardar la nueva sucursal
            Sucursal nuevaSucursal = new Sucursal(
                idSucursal,
                nombre,
                direccion,
                telefono,
                vendedorEncargado,
                activa
            );
            SucursalAD.Guardar(nuevaSucursal);
        }

        // Método para obtener todas las sucursales
        public Sucursal[] Consultar()
        {
            return SucursalAD.Consultar();
        }

        // Método para obtener las sucursales activas
        public Sucursal[] ConsultarActivas()
        {
            return SucursalAD.ConsultarActivas();
        }
    }
}
