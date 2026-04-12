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
            // Textos dinámicos
            detallesServidorLbl.Text = $"Servidor: {cliente.ObtenerIP()}  |  Puerto: {cliente.ObtenerPuerto()}";
            lblBienvenida.Text = "Por favor, ingrese su identificación para conectarse.";

            // Botones de gestión de ventas y consulta deshabilitados inicialmente
            botonConsultar.Enabled = false;
            botonGestionVentas.Enabled = false;

            // Boton de desconectar deshabilitado inicialmente
            botonDesconectar.Enabled = true;
        }

        // Evento del botón de conectar
        private void botonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idCliente.Text))
                {
                    MessageBox.Show("Por favor, ingrese su identificación.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    idCliente.Focus();
                    return;
                }

                string identificacion = idCliente.Text.Trim();

                bool conectado = cliente.Conectar(identificacion);

                if (conectado)
                {
                    nombreCliente = cliente.NombreCliente;
                    lblBienvenida.Text = $"¡Bienvenido, {nombreCliente}!";

                    ActualizarEstadoConectado();
                }
                else
                {
                    MessageBox.Show("No se pudo validar el cliente.\nVerifique que exista y esté activo.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectarse al sistema de ventas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento del botón de desconectar
        private void botonDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Desconectar();

                MessageBox.Show("Desconectado del sistema de ventas.", "Información",
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

            botonConsultar.Enabled = true;
            botonGestionVentas.Enabled = true;

        }

        // Método para actualizar la interfaz al estar desconectado
        private void ActualizarEstadoDesconectado()
        {
            estadoLbl.Text = "Estado: DESCONECTADO";
            estadoLbl.ForeColor = Color.Red;

            idCliente.Enabled = true;
            botonConectar.Enabled = true;
            botonDesconectar.Enabled = false;

            botonConsultar.Enabled = false;
            botonGestionVentas.Enabled = false;

            lblBienvenida.Text = "Por favor, ingrese su identificación para conectarse.";
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

        private void botonGestionVentas_Click(object sender, EventArgs e)
        {
            // Abrir Formulario de Gestión de Ventas
            try
            {
                // Verificar la conexión con el servidor antes
                if (!cliente.VerificarConexion())
                {
                    MessageBox.Show("El servidor no está disponible.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cliente.Desconectar(); // Desconectar y actualizar estado
                    ActualizarEstadoDesconectado();
                    return;
                }

                FrmVenta frmVenta = new FrmVenta(cliente);
                frmVenta.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            // Abrir Formulario de Consultar Ventas
            try
            {
                // Verificar la conexión con el servidor antes
                if (!cliente.VerificarConexion())
                {
                    MessageBox.Show("El servidor no está disponible.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cliente.Desconectar(); // Desconectar y actualizar estado
                    ActualizarEstadoDesconectado();
                    return;
                }

                FrmConsultarVentas frmConsultarVentas = new FrmConsultarVentas(cliente);
                frmConsultarVentas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
    }
}
