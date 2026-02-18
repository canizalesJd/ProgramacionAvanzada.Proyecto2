using CapaLogicaNegocio;
using CapaEntidades;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: Jose David Canizales Azocar
 * Fecha: Febrero 2026
 */

namespace CapaPresentacion
{
    public partial class FrmRegistrarSucursal : Form
    {
        private readonly SucursalBL sucursalBL;
        private readonly VendedorBL vendedorBL;
        public FrmRegistrarSucursal()
        {
            InitializeComponent();
            sucursalBL = new SucursalBL();
            vendedorBL = new VendedorBL();
        }

        private void limpiarCampos()
        {
            idSucursal.Clear();
            nombreSucursal.Clear();
            direccionSucursal.Clear();
            telefonoSucursal.Clear();
            comboVendedorEncargado.SelectedIndex = -1;
        }

        private void CargarVendedores()
        {
            Vendedor[] vendedores = vendedorBL.Consultar();

            if (vendedores.Length == 0)
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

        private void FrmRegistrarSucursal_Load(object sender, EventArgs e)
        {
            CargarVendedores();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
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

                if (comboVendedorEncargado.SelectedItem is not Vendedor vendedorEncargado)
                {
                    MessageBox.Show("Debe seleccionar un vendedor encargado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sucursalBL.RegistrarSucursal(id, nombre, direccion, telefono, vendedorEncargado);
                MessageBox.Show("Sucursal registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
