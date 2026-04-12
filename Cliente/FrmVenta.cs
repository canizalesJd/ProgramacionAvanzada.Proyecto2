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

namespace Cliente
{
    public partial class FrmVenta : Form
    {
        // Instancia de la clase ClienteSocket para manejar la comunicación con el servidor.
        private ClienteSocket cliente;
        public FrmVenta(ClienteSocket clienteSocket)
        {
            InitializeComponent();
            this.cliente = clienteSocket;
        }

        // Metodo para cargar las sucursales activas
        public void CargarSucursales()
        {
            // Verificar la conexión con el servidor antes
            VerificarConexion();

            List<Sucursal> sucursales = cliente.ObtenerSucursalesActivas();

            if (sucursales == null || sucursales.Count == 0)
            {
                MessageBox.Show(
                    "No hay sucursales activas registradas. Debe registrar al menos una antes de crear una venta.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                comboSucursal.Enabled = false;
                LimpiarComboVehiculo(); // Limpiar el combo de vehículos al no haber sucursales activas disponibles para la venta
                return;
            }
            comboSucursal.DataSource = sucursales;
            comboSucursal.DisplayMember = "Nombre";
            comboSucursal.ValueMember = "IdSucursal";
            comboSucursal.SelectedIndex = -1;
            comboSucursal.Text = "Seleccione una sucursal";
            comboSucursal.Enabled = true;
            comboVehiculo.Enabled = false;
            LimpiarComboVehiculo();
        }

        // Cargar los vehículos disponibles para la sucursal seleccionada
        private void comboSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar la conexión con el servidor antes
            VerificarConexion();

            // Verificar que el elemento seleccionado sea una instancia de Sucursal antes de intentar acceder a sus propiedades
            if (comboSucursal.SelectedItem is not Sucursal sucursal)
                return;

            // Limpiar el combo de vehículos y el campo de precio antes de cargar los nuevos datos
            comboVehiculo.DataSource = null;
            comboVehiculo.Items.Clear();
            precio.Clear();

            // Cargar los vehículos disponibles para la sucursal seleccionada utilizando el método ObtenerVehiculosPorSucursal del cliente
            List<Vehiculo> vehiculos = cliente.ObtenerVehiculosPorSucursal(sucursal.IdSucursal);

            // Si no hay vehículos disponibles, mostrar un mensaje al usuario y limpiar el combo de vehículos
            if (vehiculos == null || vehiculos.Count == 0)
            {
                MessageBox.Show(
                    "No hay vehículos disponibles en esta sucursal. Por favor, seleccione otra sucursal.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LimpiarComboVehiculo();
                return;
            }
            // Si hay vehículos disponibles, cargar el combo de vehículos con los datos obtenidos
            comboVehiculo.DataSource = vehiculos;
            comboVehiculo.DisplayMember = "DisplayMember";
            comboVehiculo.ValueMember = "IdVehiculo";
            comboVehiculo.Text = "Seleccione un vehículo";
            comboVehiculo.SelectedIndex = -1;
            comboVehiculo.Enabled = true;
        }

        // Cargar el precio del vehículo seleccionado en el campo de texto correspondiente
        private void comboVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVehiculo.SelectedItem is Vehiculo vehiculo)
            {
                precio.Text = vehiculo.PrecioTexto;
            }
            else
            {
                precio.Clear();
            }
        }

        // Metodo para manejar el evento del botón de realizar venta.
        private void RegistrarVenta()
        {
            // Verificar la conexión con el servidor antes
            VerificarConexion();

            if (comboVehiculo.SelectedItem is not Vehiculo vehiculoSeleccionado)
            {
                MessageBox.Show("Por favor, seleccione un vehículo para realizar la venta.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboSucursal.SelectedItem is not Sucursal sucursalSeleccionada)
            {
                MessageBox.Show("Por favor, seleccione una sucursal para realizar la venta.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CapaEntidades.Cliente clienteAutenticado = cliente.ClienteAutenticado!; // ! para indicar que se asume que el cliente autenticado no es nulo

            Venta nuevaVenta = new Venta(
                clienteAutenticado,
                sucursalSeleccionada,
                vehiculoSeleccionado,
                DateTime.Now,
                vehiculoSeleccionado.Precio
            );

            bool ventaExitosa = cliente.RegistrarVenta(nuevaVenta);

            if (ventaExitosa)
            {
                MessageBox.Show("¡Venta realizada con éxito!", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al realizar la venta. Por favor, inténtelo de nuevo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo para limpiar combobox de vehiculo
        private void LimpiarComboVehiculo()
        {
            comboVehiculo.DataSource = null;
            comboVehiculo.Items.Clear();
            comboVehiculo.Text = string.Empty;
            precio.Text = string.Empty;
        }

        // Evento para manejar el clic en el botón de guardar venta
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            RegistrarVenta(); // Llamar al método para registrar la venta al hacer clic en el botón de guardar
        }

        // Metodo para verificar la conexión
        private void VerificarConexion()
        {
            if (!cliente.VerificarConexion())
            {
                MessageBox.Show("El servidor no está disponible. Por favor, intente conectarse nuevamente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Cerrar el formulario actual si no hay conexión con el servidor
            }
        }

        // Evento para cargar las sucursales activas al iniciar el formulario
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            // Verificar la conexión con el servidor
            VerificarConexion();

            // Cargar las sucursales activas al iniciar el formulario
            CargarSucursales();
            comboVehiculo.Enabled = false; // Deshabilitar el combo de vehículos hasta que se seleccione una sucursal
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario actual al hacer clic en el botón de cancelar
        }
    }
}
