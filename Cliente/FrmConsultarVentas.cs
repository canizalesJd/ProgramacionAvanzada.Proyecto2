/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

using CapaEntidades;
using Cliente.Comunicacion;
using System.Net.WebSockets;

namespace Cliente
{
    public partial class FrmConsultarVentas : Form
    {

        // Instancia de la clase ClienteSocket para manejar la comunicación con el servidor.
        private ClienteSocket cliente;
        public FrmConsultarVentas(ClienteSocket clienteSocket)
        {
            InitializeComponent();
            this.cliente = clienteSocket;
            CargarVentas();
        }

        // Metodo para cargar las ventas realizadas por el cliente
        public void CargarVentas()
        {
            // Verificar la conexión con el servidor antes
            VerificarConexion();

            // Obtener informacion del cliente
            CapaEntidades.Cliente clienteAutenticado = cliente.ClienteAutenticado!;

            if (cliente.ClienteAutenticado == null)
            {
                MessageBox.Show(
                    "No se pudo obtener el cliente autenticado.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close();
                return;
            }

            List<Venta> ventas = cliente.ConsultarVentasPorCliente(clienteAutenticado.IdCliente);
            if (ventas == null || ventas.Count == 0)
            {
                MessageBox.Show(
                    "No se han registrado ventas para este cliente.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                dgvConsulta.DataSource = null; // Limpiar el DataGridView si no hay ventas
                return;
            }

            // Limpiar el DataGridView antes de cargar los nuevos datos
            dgvConsulta.DataSource = null;
            dgvConsulta.Rows.Clear();
            dgvConsulta.Columns.Clear();
            dgvConsulta.AutoGenerateColumns = false;

            // Id Venta
            var colIdVenta = new DataGridViewTextBoxColumn();
            colIdVenta.DataPropertyName = "IdVenta";
            colIdVenta.Name = "IdVenta";
            colIdVenta.HeaderText = "Id Venta";
            colIdVenta.Width = 80;
            dgvConsulta.Columns.Add(colIdVenta);

            // Fecha
            var colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "FechaVentaTexto";
            colFecha.Name = "FechaVenta";
            colFecha.HeaderText = "Fecha de Venta";
            colFecha.Width = 140;
            dgvConsulta.Columns.Add(colFecha);

            // Monto
            var colMonto = new DataGridViewTextBoxColumn();
            colMonto.DataPropertyName = "MontoTexto";
            colMonto.Name = "Monto";
            colMonto.HeaderText = "Monto";
            colMonto.Width = 120;
            dgvConsulta.Columns.Add(colMonto);

            // Cliente
            var colCliente = new DataGridViewTextBoxColumn();
            colCliente.DataPropertyName = "ClienteNombre";
            colCliente.Name = "Cliente";
            colCliente.HeaderText = "Cliente";
            colCliente.Width = 200;
            dgvConsulta.Columns.Add(colCliente);

            // Identificación del cliente
            var colIdentificacion = new DataGridViewTextBoxColumn();
            colIdentificacion.DataPropertyName = "ClienteIdentificacion";
            colIdentificacion.Name = "Identificacion";
            colIdentificacion.HeaderText = "Identificación";
            colIdentificacion.Width = 120;
            dgvConsulta.Columns.Add(colIdentificacion);

            // Sucursal
            var colSucursal = new DataGridViewTextBoxColumn();
            colSucursal.DataPropertyName = "SucursalNombre";
            colSucursal.Name = "Sucursal";
            colSucursal.HeaderText = "Sucursal";
            colSucursal.Width = 180;
            dgvConsulta.Columns.Add(colSucursal);

            // Vehículo
            var colVehiculo = new DataGridViewTextBoxColumn();
            colVehiculo.DataPropertyName = "VehiculoDescripcion";
            colVehiculo.Name = "Vehiculo";
            colVehiculo.HeaderText = "Vehículo";
            colVehiculo.Width = 220;
            dgvConsulta.Columns.Add(colVehiculo);

            // Categoría
            var colCategoria = new DataGridViewTextBoxColumn();
            colCategoria.DataPropertyName = "CategoriaNombre";
            colCategoria.Name = "Categoria";
            colCategoria.HeaderText = "Categoría";
            colCategoria.Width = 150;
            dgvConsulta.Columns.Add(colCategoria);

            dgvConsulta.DataSource = ventas;
        }

        // Metodo para verificar la conexión con el servidor antes de realizar cualquier operación
        private void VerificarConexion()
        {
            if (!cliente.VerificarConexion())
            {
                MessageBox.Show(
                    "No hay conexión con el servidor. Por favor, intente nuevamente más tarde.",
                    "Error de Conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close(); // Cerrar el formulario si no hay conexión
            }
        }

        // Metodo para el boton de actualizar la consulta de ventas
        private void botonActualizar_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }
    }
}
