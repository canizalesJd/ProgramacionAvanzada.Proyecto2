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
    /// Clase de lógica de negocio para la gestión de vendedores.
    /// </summary>
    public class VendedorLN
    {
        /// <summary>
        /// Registra un nuevo vendedor en el sistema después de validar los datos de entrada.
        /// </summary>
        /// <param name="idVendedor">
        /// El ID único del vendedor. Debe ser un número positivo y no puede existir otro vendedor con el mismo ID.
        /// </param>
        /// <param name="identificacion">
        /// La identificación del vendedor. No puede estar vacía o contener solo espacios en blanco.
        /// </param>
        /// <param name="nombreCompleto">
        /// El nombre completo del vendedor. No puede estar vacío o contener solo espacios en blanco.
        /// </param>
        /// <param name="fechaNacimiento">
        /// La fecha de nacimiento del vendedor. Debe ser una fecha pasada, es decir, anterior a la fecha actual y el vendedor debe tener al menos 18 años de edad.
        /// </param>
        /// <param name="fechaIngreso">
        /// La fecha de ingreso del vendedor a la empresa. No puede ser una fecha futura, es decir, debe ser igual o anterior a la fecha actual.
        /// </param>
        /// <param name="telefono">
        /// El número de teléfono del vendedor. No puede estar vacío o contener solo espacios en blanco.
        /// </param>
        public void RegistrarVendedor(int idVendedor, string identificacion, string nombreCompleto, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono)
        {
            // Validación de datos de entrada
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

            // Edad mínima de 18 años
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            int minimaEdad = 18;

            if (edad < minimaEdad)
            {
                throw new ArgumentException($"El vendedor debe tener al menos {minimaEdad} años de edad.");
            }

            if (fechaIngreso > DateTime.Now)
            {
                throw new ArgumentException("La fecha de ingreso del vendedor no puede ser una fecha futura.");
            }
            if (string.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentException("El teléfono del vendedor no puede estar vacío.");
            }

            // Crear y guardar el nuevo vendedor
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

        // Método para obtener todos los vendedores
        public Vendedor[] Consultar()
        {
            return VendedorAD.Consultar();
        }
    }
}
