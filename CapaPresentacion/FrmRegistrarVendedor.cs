using CapaLogicaNegocio;

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
    public partial class FrmRegistrarVendedor : Form
    {
        private readonly VendedorBL vendedorBL;
        public FrmRegistrarVendedor()
        {
            InitializeComponent();
            vendedorBL = new VendedorBL();
        }

        private void LimpiarCampos()
        {
            idVendedor.Clear();
            identificacionVendedor.Clear();
            nombreCompletoVendedor.Clear();
            fechaNacimientoVendedor.Value = DateTime.Now;
            fechaIngresoVendedor.Value = DateTime.Now;
            telefonoVendedor.Clear();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
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
                vendedorBL.RegistrarVendedor(id, identificacion, nombre, fechaNacimiento, fechaIngreso, telefono);
                MessageBox.Show("Vendedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
