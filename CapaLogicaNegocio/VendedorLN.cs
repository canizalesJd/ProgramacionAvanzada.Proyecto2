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
    public class VendedorLN
    {
        // Metodo para registrar un nuevo vendedor
        public void RegistrarVendedor(int idVendedor, string identificacion, string nombreCompleto, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono)
        {
            if (VendedorAD.VendedorExiste(idVendedor))
            {
                throw new ArgumentException($"Ya existe un vendedor con el ID {idVendedor}, ingrese un ID distinto.");
            }
            if (idVendedor <= 0)
            {
                throw new ArgumentException("El ID del vendedor debe ser un número positivo.");
            }
            if (string.IsNullOrWhiteSpace(identificacion))
            {
                throw new ArgumentException("La identificación del vendedor no puede estar vacía.");
            }
            if (string.IsNullOrWhiteSpace(nombreCompleto))
            {
                throw new ArgumentException("El nombre completo del vendedor no puede estar vacío.");
            }
            if (fechaNacimiento >= DateTime.Now)
            {
                throw new ArgumentException("La fecha de nacimiento del vendedor debe ser una fecha pasada.");
            }
            if (fechaIngreso > DateTime.Now)
            {
                throw new ArgumentException("La fecha de ingreso del vendedor no puede ser una fecha futura.");
            }
            if (string.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentException("El teléfono del vendedor no puede estar vacío.");
            }

            Vendedor nuevo = new Vendedor(
                idVendedor,
                identificacion,
                nombreCompleto,
                fechaNacimiento,
                fechaIngreso,
                telefono
            );

            VendedorAD.Guardar(nuevo);
        }

        // Metodo para obtener todos los vendedores
        public Vendedor[] Consultar()
        {
            return VendedorAD.Consultar();
        }
    }
}
