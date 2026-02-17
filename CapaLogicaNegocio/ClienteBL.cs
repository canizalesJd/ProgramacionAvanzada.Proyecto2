using CapaAccesoDatos;
using CapaEntidades;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: Jose David Canizales Azocar
 * Fecha: Febrero 2026
 */

namespace CapaLogicaNegocio
{
    public class ClienteBL
    {
        // Metodo para registrar un cliente nuevo
        public void RegistrarCliente(int idCliente, string identificacion, string nombreCompleto, DateTime fechaNacimiento, DateTime fechaRegistro, bool activo = true)
        {
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

            Cliente nuevoCliente = new Cliente(
                idCliente, 
                identificacion,
                nombreCompleto,
                fechaNacimiento,
                fechaRegistro, 
                activo
            );
            ClienteDAL.Guardar(nuevoCliente);
        }

        // Metodo para obtener todos los clientes
        public Cliente[] ObtenerClientes()
        {
            return ClienteDAL.Consultar();
        }
    }
}
