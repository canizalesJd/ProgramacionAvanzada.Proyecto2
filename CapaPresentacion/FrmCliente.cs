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
    public partial class FrmCliente : Form
    {
        private readonly ClienteLN clienteLN;
        public FrmCliente()
        {
            InitializeComponent();
            clienteLN = new ClienteLN();
        }

        private void LimpiarCampos()
        {
            idCliente.Clear();
            identificacionCliente.Clear();
            nombreCompleto.Clear();
            fechaNacimiento.Value = DateTime.Now;
            fechaRegistro.Value = DateTime.Now;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (!int.TryParse(idCliente.Text, out int id))
                    {
                        MessageBox.Show("El ID debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string identificacion = identificacionCliente.Text.Trim();
                    string nombre = nombreCompleto.Text.Trim();
                    DateTime fechaNacimientoCliente = fechaNacimiento.Value;
                    DateTime fechaRegistroCliente = fechaRegistro.Value;

                    clienteLN.RegistrarCliente(id, identificacion, nombre, fechaNacimientoCliente, fechaRegistroCliente);

                    MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
