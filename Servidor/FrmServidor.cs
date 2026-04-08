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
            InitializeComponent();
            // Crear instancia del servidor y suscribirse a los eventos de actualización
            servidor = new ServidorSocket();

            servidor.NuevaBitacora += AgregarBitacora;
        }

        // Metodo para agregar un mensaje a la bitácora del servidor
        public void AgregarBitacora(string mensaje)
        {
            DateTime fechaActual = DateTime.Now;

            if (bitacoraBox.InvokeRequired)
            {
                bitacoraBox.Invoke(new Action(() => AgregarBitacora(mensaje)));
                return;
            }

            bitacoraBox.AppendText($"{fechaActual:yyyy-MM-dd HH:mm:ss} - {mensaje}{Environment.NewLine}");
        }

        // Boton para encender el servidor
        private void botonEncender_Click(object sender, EventArgs e)
        {
            servidor.Iniciar();
        }

        // Boton para apagar el servidor
        private void botonApagar_Click(object sender, EventArgs e)
        {
            servidor.Detener();
        }

        // Boton para limpiar la bitácora del servidor
        private void botonLimpiarBitacora_Click(object sender, EventArgs e)
        {
            bitacoraBox.Clear();
        }

        // Boton para abrir FrmMenu
        private void botonAdministracion_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }
    }
}
