using CapaLogicaNegocio;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Febrero 2026
 */

namespace CapaPresentacion
{
    // Formulario para registrar un nuevo vendedor en el sistema.
    public partial class FrmVendedor : Form
    {
        // Instancia de la clase de lógica de negocio para gestionar las operaciones relacionadas con los vendedores.
        private readonly VendedorLN vendedorLN;
        public FrmVendedor()
        {
            InitializeComponent();
            vendedorLN = new VendedorLN();
        }

        // Método para limpiar los campos del formulario después de registrar un vendedor o al cancelar el registro.
        private void LimpiarCampos()
        {
            idVendedor.Clear();
            identificacionVendedor.Clear();
            nombreCompletoVendedor.Clear();
            fechaNacimientoVendedor.Value = DateTime.Now;
            fechaIngresoVendedor.Value = DateTime.Now;
            telefonoVendedor.Clear();
        }

        // Evento que se ejecuta al hacer clic en el botón de guardar, encargado de validar los datos ingresados, registrar el nuevo vendedor a través de la lógica de negocio y mostrar mensajes de éxito o error según corresponda.
        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(idVendedor.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string identificacion = identificacionVendedor.Text.Trim();
                string nombre = nombreCompletoVendedor.Text.Trim();
                DateTime fechaNacimiento = fechaNacimientoVendedor.Value;
                DateTime fechaIngreso = fechaIngresoVendedor.Value;
                string telefono = telefonoVendedor.Text.Trim();

                vendedorLN.RegistrarVendedor(id, identificacion, nombre, fechaNacimiento, fechaIngreso, telefono);

                MessageBox.Show("Vendedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento que se ejecuta al hacer clic en el botón de cancelar, encargado de cerrar el formulario sin realizar ninguna acción adicional.
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
