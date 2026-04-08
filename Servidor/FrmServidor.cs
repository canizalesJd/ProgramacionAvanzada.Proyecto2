/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

using CapaPresentacion;
using Servidor.Comunicacion;

namespace Servidor
{
    /// <summary>
    /// Formulario principal del servidor
    /// Permite encender/apagar el servidor, mostrar los clientes conectados y la bitácora de eventos.
    /// </summary>
    public partial class FrmServidor : Form
    {
        // Variables de instancia
        private ServidorSocket servidor;


        // Constructor para inicializar el formulario
        public FrmServidor()
        {
            // Inicializar componentes
            InitializeComponent();

            // Crear instancia del servidor
            servidor = new ServidorSocket();

            // Suscribirse al evento de bitácora
            servidor.NuevaBitacora += (mensaje) =>
            {
                AgregarBitacora(mensaje);
            };

            // Suscribirse al evento de cliente conectado
            servidor.ClienteConectado += (nombreCliente) =>
            {
                AgregarClienteALista(nombreCliente);
            };

            // Suscribirse al evento de cliente desconectado
            servidor.ClienteDesconectado += (nombreCliente) =>
            {
                RemoverClienteDeLista(nombreCliente);
            };

            // Mostrar información del servidor en el label
            detallesServidorLbl.Text = $"IP: {servidor.ObtenerIP()}  |  Puerto: {servidor.ObtenerPuerto()}  |  Máx Clientes: {servidor.ObtenerMaxClientes()}";
        }

        // Metodo para agregar un mensaje a la bitácora del servidor
        private void AgregarBitacora(string mensaje)
        {
            // Los eventos de hilos no pueden modificar la UI directamente
            // Usamos Invoke para ejecutar el código en el hilo de la UI
            if (bitacoraLv.InvokeRequired)
            {
                bitacoraLv.Invoke(new Action(() =>
                {
                    // Agregar el mensaje con fecha/hora
                    string mensajeConHora = $"[{DateTime.Now:HH:mm:ss}] {mensaje}";
                    bitacoraLv.Items.Add(mensajeConHora);

                    // Hacer scroll automático al último elemento
                    bitacoraLv.EnsureVisible(bitacoraLv.Items.Count - 1);

                    // Actualizar contador de clientes
                    ActualizarContadorClientes();
                }));
            }
            else
            {
                string mensajeConHora = $"[{DateTime.Now:HH:mm:ss}] {mensaje}";
                bitacoraLv.Items.Add(mensajeConHora);
                bitacoraLv.EnsureVisible(bitacoraLv.Items.Count - 1);
                ActualizarContadorClientes();
            }
        }

        /// <summary>
        /// Agrega un cliente al ListView de clientes
        /// </summary>
        private void AgregarClienteALista(string nombreCliente)
        {
            if (clientesLv.InvokeRequired)
            {
                clientesLv.Invoke(new Action(() =>
                {
                    clientesLv.Items.Add(nombreCliente);
                    ActualizarContadorClientes();
                }));
            }
            else
            {
                clientesLv.Items.Add(nombreCliente);
                ActualizarContadorClientes();
            }
        }


        /// <summary>
        /// Remueve un cliente del ListView de clientes
        /// </summary>
        private void RemoverClienteDeLista(string nombreCliente)
        {
            if (clientesLv.InvokeRequired)
            {
                clientesLv.Invoke(new Action(() =>
                {
                    // Buscar el item con ese nombre y removerlo
                    foreach (ListViewItem item in clientesLv.Items)
                    {
                        if (item.Text == nombreCliente)
                        {
                            clientesLv.Items.Remove(item);
                            break;
                        }
                    }
                    ActualizarContadorClientes();
                }));
            }
            else
            {
                foreach (ListViewItem item in clientesLv.Items)
                {
                    if (item.Text == nombreCliente)
                    {
                        clientesLv.Items.Remove(item);
                        break;
                    }
                }
                ActualizarContadorClientes();
            }
        }

        // Metodo para actualizar el contador de clientes conectados en la etiqueta lblClientes
        private void ActualizarContadorClientes()
        {
            int cantidadClientes = servidor.ObtenerCantidadClientes();
            int maxClientes = servidor.ObtenerMaxClientes();
            clientesConectadosLbl.Text = $"Clientes Conectados: {cantidadClientes} de {maxClientes}";

            // Cambiar color según la cantidad
            if (cantidadClientes == maxClientes)
            {
                clientesConectadosLbl.ForeColor = Color.Red; // Máximo alcanzado
            }
            else if (cantidadClientes > 0)
            {
                clientesConectadosLbl.ForeColor = Color.DarkOrange; // Hay clientes
            }
            else
            {
                clientesConectadosLbl.ForeColor = Color.Gray; // No hay clientes
            }
        }

        // Boton para encender el servidor
        private void botonEncender_Click(object sender, EventArgs e)
        {
            try
            {
                // Iniciar el servidor
                servidor.Iniciar();

                // Deshabilitar botón Encender
                botonEncender.Enabled = false;

                // Habilitar botón Apagar
                botonApagar.Enabled = true;

                // Agregar mensaje a la bitácora
                AgregarBitacora("=== SERVIDOR ENCENDIDO ===");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Boton para apagar el servidor
        private void botonApagar_Click(object sender, EventArgs e)
        {
            try
            {
                // Detener el servidor
                servidor.Detener();

                // Habilitar botón Encender
                botonEncender.Enabled = true;

                // Deshabilitar botón Apagar
                botonApagar.Enabled = false;

                // Limpiar lista de clientes
                clientesLv.Items.Clear();
                clientesConectadosLbl.Text = "Clientes Conectados: 0 de 5";

                // Agregar mensaje a la bitácora
                AgregarBitacora("=== SERVIDOR APAGADO ===");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al detener servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Boton para limpiar la bitácora del servidor
        private void botonLimpiarBitacora_Click(object sender, EventArgs e)
        {
            bitacoraLv.Clear();
        }

        // Boton para abrir FrmMenu
        private void botonAdministracion_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }

        // Evento para manejar el cierre del formulario
        private void FrmServidor_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                // Si el servidor está activo, detenerlo
                if (botonApagar.Enabled)
                {
                    servidor.Detener();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
