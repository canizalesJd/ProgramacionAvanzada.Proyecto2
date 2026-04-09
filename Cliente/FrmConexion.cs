/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

using Cliente.Comunicacion;

namespace Cliente
{
    public partial class FrmConexion : Form
    {
        // Variables de instancia
        private ClienteSocket cliente;
        private string nombreCliente;

        // Constructor

        public FrmConexion()
        {
            InitializeComponent();

            cliente = new ClienteSocket();
            nombreCliente = string.Empty;

            detallesServidorLbl.Text = $"Servidor: {cliente.ObtenerIP()}  |  Puerto: {cliente.ObtenerPuerto()}";
        }

        // Evento del botón de conectar
        private void botonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDAR: El ID del cliente no puede estar vacío
                if (string.IsNullOrWhiteSpace(idCliente.Text))
                {
                    MessageBox.Show("Por favor, ingrese su Identificación de cliente.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    idCliente.Focus();
                    return;
                }

                // Guardar el ID del cliente
                string identificacion = idCliente.Text.Trim();

                // Intentar conectar al servidor
                bool conectado = cliente.Conectar(identificacion);

                if (conectado)
                {
                    MessageBox.Show($"Conectado al servidor como '{identificacion}'", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ActualizarEstadoConectado();
                }
                else
                {
                    MessageBox.Show("No se pudo conectar al servidor.\n\n" +
                        "Verifique que el servidor esté encendido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento del botón de desconectar
        private void botonDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Desconectar();

                MessageBox.Show("Desconectado del servidor.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarEstadoDesconectado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al desconectar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para actualizar la interfaz al estar conectado
        private void ActualizarEstadoConectado()
        {
            estadoLbl.Text = "Estado: CONECTADO";
            estadoLbl.ForeColor = Color.Green;

            idCliente.Enabled = false;
            botonConectar.Enabled = false;
            botonDesconectar.Enabled = true;

        }

        // Método para actualizar la interfaz al estar desconectado
        private void ActualizarEstadoDesconectado()
        {
            estadoLbl.Text = "Estado: DESCONECTADO";
            estadoLbl.ForeColor = Color.Red;

            idCliente.Enabled = true;
            botonConectar.Enabled = true;

            botonDesconectar.Enabled = false;
        }

        // Evento de cerrar el formulario
        private void FrmConexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (cliente.EstaConectado)
                {
                    cliente.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar: {ex.Message}", "Error");
            }
        }
    }
}
