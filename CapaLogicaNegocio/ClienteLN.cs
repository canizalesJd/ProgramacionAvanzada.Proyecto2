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
    /// Clase de lógica de negocio para la entidad Cliente.
    /// </summary>
    public class ClienteLN
    {
        /// <summary>
        /// Registra un nuevo cliente en el sistema.
        /// </summary>
        public void RegistrarCliente(int idCliente, string identificacion, string nombreCompleto, DateTime fechaNacimiento, DateTime fechaRegistro, bool activo = true)
        {
            // Validaciones de entrada
            if (idCliente <= 0) {
                throw new ArgumentException("El ID del cliente debe ser un número positivo.");
            }

            if (string.IsNullOrWhiteSpace(identificacion)) {
                throw new ArgumentException("La identificación no puede estar vacía.");
            }

            if (string.IsNullOrWhiteSpace(nombreCompleto)) {
                throw new ArgumentException("El nombre completo no puede estar vacío.");
            }

            if (fechaNacimiento >= DateTime.Now) {
                throw new ArgumentException("La fecha de nacimiento debe ser anterior a la fecha actual.");
            }

            // Si no se proporciona una fecha de registro, se asigna la fecha actual
            if (fechaRegistro == default) {
                fechaRegistro = DateTime.Now;
            }

            // Crear un nuevo cliente y guardarlo
            Cliente nuevoCliente = new Cliente(
                idCliente, 
                identificacion,
                nombreCompleto,
                fechaNacimiento,
                fechaRegistro, 
                activo
            );
            ClienteAD.Guardar(nuevoCliente);
        }

        // Método para obtener todos los clientes
        public Cliente[] Consultar()
        {
            return ClienteAD.Consultar();
        }
    }
}
