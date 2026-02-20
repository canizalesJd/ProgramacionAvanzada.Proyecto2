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
    /// Clase de lógica de negocio para la entidad Sucursal. Proporciona métodos para registrar nuevas sucursales y consultar las sucursales existentes.
    /// </summary>
    public class SucursalLN
    {
        /// <summary>
        /// Método para registrar una nueva sucursal. Valida los datos de entrada y lanza excepciones si los datos no son válidos o si la sucursal ya existe.
        /// </summary>
        /// <param name="idSucursal">
        /// El ID de la sucursal, debe ser un número positivo y único. Si el ID ya existe en el sistema, se lanzará una excepción.
        /// </param>
        /// <param name="nombre">
        /// El nombre de la sucursal, no puede estar vacío ni contener solo espacios en blanco. Es un campo obligatorio.
        /// </param>
        /// <param name="direccion">
        /// La dirección de la sucursal, no puede estar vacía ni contener solo espacios en blanco. Es un campo obligatorio.
        /// </param>
        /// <param name="telefono">
        /// El teléfono de la sucursal, no puede estar vacío ni contener solo espacios en blanco. Es un campo obligatorio y debe ser un número de teléfono válido.
        /// </param>
        /// <param name="vendedorEncargado">
        /// El vendedor encargado de la sucursal, no puede ser nulo. Debe ser un objeto válido de la clase Vendedor que represente al encargado de la sucursal.
        /// </param>
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
