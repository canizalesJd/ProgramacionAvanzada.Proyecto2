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
    // Formulario para registrar un nuevo cliente en el sistema.
    public partial class FrmCliente : Form
    {
        // Instancia de la clase de lógica de negocio para gestionar los clientes.
        private readonly ClienteLN clienteLN;
        public FrmCliente()
        {
            InitializeComponent();
            clienteLN = new ClienteLN();
        }

        // Método para limpiar los campos de entrada después de registrar un cliente o al cancelar la operación.
        private void LimpiarCampos()
        {
            idCliente.Clear();
            identificacionCliente.Clear();
            nombreCompleto.Clear();
            fechaNacimiento.Value = DateTime.Now;
            fechaRegistro.Value = DateTime.Now;
        }

        // Evento del botón "Guardar" que se ejecuta al hacer clic. Valida los datos ingresados, registra el cliente utilizando la lógica de negocio y muestra mensajes de éxito o error según corresponda.
        private void BotonGuardar_Click(object sender, EventArgs e)
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

        // Evento del botón "Cancelar" que se ejecuta al hacer clic. Cierra el formulario actual.
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
