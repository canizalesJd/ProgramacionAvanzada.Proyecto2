using CapaLogicaNegocio;
using CapaEntidades;

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
    // Formulario para registrar una nueva sucursal en el sistema.
    public partial class FrmSucursal : Form
    {
        // Instancias de la capa de lógica de negocio para gestionar las operaciones relacionadas con sucursales y vendedores.
        private readonly SucursalLN sucursalLN;
        private readonly VendedorLN vendedorLN;
        public FrmSucursal()
        {
            InitializeComponent();
            sucursalLN = new SucursalLN();
            vendedorLN = new VendedorLN();
        }

        // Método para limpiar los campos del formulario después de registrar una sucursal o al cancelar el registro.
        private void LimpiarCampos()
        {
            idSucursal.Clear();
            nombreSucursal.Clear();
            direccionSucursal.Clear();
            telefonoSucursal.Clear();
            comboVendedorEncargado.SelectedIndex = -1;
            sucursalActiva.Checked = true; // Por defecto, la sucursal se registra como activa
        }

        // Método para cargar los vendedores disponibles en el sistema y mostrarlos en el combo box para seleccionar el encargado de la sucursal. Si no hay vendedores registrados, se muestra un mensaje informativo y se deshabilita la opción de guardar.
        private void CargarVendedores()
        {
            List<Vendedor> vendedores = vendedorLN.Consultar();

            if (vendedores == null || vendedores.Count == 0)
            {
                MessageBox.Show(
                    "No hay vendedores registrados. Debe registrar al menos uno antes de crear una sucursal.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                comboVendedorEncargado.Enabled = false;
                botonGuardar.Enabled = false;
                this.Close(); // Cerrar el formulario si no hay vendedores disponibles
                return;
            }

            comboVendedorEncargado.DataSource = vendedores;
            comboVendedorEncargado.DisplayMember = "DisplayMember";
            comboVendedorEncargado.ValueMember = "IdVendedor";
            comboVendedorEncargado.SelectedIndex = -1;

            comboVendedorEncargado.Enabled = true;
            botonGuardar.Enabled = true;
        }

        // Evento que se ejecuta al cargar el formulario, donde se llama al método para cargar los vendedores disponibles.
        private void FrmRegistrarSucursal_Load(object sender, EventArgs e)
        {
            CargarVendedores();
        }

        // Evento que se ejecuta al hacer clic en el botón de guardar, donde se valida la información ingresada, se registra la nueva sucursal utilizando la lógica de negocio y se muestra un mensaje de éxito o error según corresponda. Después de registrar la sucursal, se limpian los campos del formulario para permitir el registro de una nueva sucursal.
        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(idSucursal.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string nombre = nombreSucursal.Text.Trim();
                string direccion = direccionSucursal.Text.Trim();
                string telefono = telefonoSucursal.Text.Trim();
                bool activa = sucursalActiva.Checked;

                if (comboVendedorEncargado.SelectedItem is not Vendedor vendedorEncargado)
                {
                    MessageBox.Show("Debe seleccionar un vendedor encargado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sucursalLN.RegistrarSucursal(id, nombre, direccion, telefono, vendedorEncargado, activa);
                MessageBox.Show("Sucursal registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento que se ejecuta al hacer clic en el botón de cancelar, donde se cierra el formulario actual sin guardar cambios.
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
