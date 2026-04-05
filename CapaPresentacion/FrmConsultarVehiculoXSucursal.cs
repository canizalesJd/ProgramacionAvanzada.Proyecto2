using CapaAccesoDatos;
using CapaEntidades;
using CapaLogicaNegocio;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

namespace CapaPresentacion
{
    // Formulario para consultar los vehículos disponibles en una sucursal específica.
    public partial class FrmConsultarVehiculoXSucursal : Form
    {
        // Instancia de la clase de lógica de negocio para gestionar la relación entre vehículos y sucursales.
        private readonly VehiculoXSucursalLN vehiculoXSucursalLN;

        public FrmConsultarVehiculoXSucursal()
        {
            InitializeComponent();
            vehiculoXSucursalLN = new VehiculoXSucursalLN();
        }

        // Evento que se ejecuta al cargar el formulario. Llama al método para cargar los vehículos disponibles en la sucursal y mostrarlos en el DataGridView.
        private void FrmConsultarVehiculoXSucursal_Load(object sender, EventArgs e)
        {
            CargarVehiculosXSucursal();
        }

        // Método para cargar los vehículos disponibles en la sucursal desde la lógica de negocio y mostrarlos en el DataGridView.
        private void CargarVehiculosXSucursal()
        {
            List<VehiculoXSucursal> vehiculosXSucursal = vehiculoXSucursalLN.Consultar();
            if (vehiculosXSucursal == null || vehiculosXSucursal.Count == 0)
            {
                MessageBox.Show(
                    "No hay asociaciones entre vehículos y sucursales disponibles en el sistema.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close(); // Cerrar el formulario si no hay registros para mostrar
                return;
            }

            // Limpiar el DataGridView antes de cargar los nuevos datos
            dgvConsulta.DataSource = null;
            dgvConsulta.Rows.Clear();
            dgvConsulta.Columns.Clear();
            dgvConsulta.AutoGenerateColumns = false;

            // Configuración de la columna Sucursal (Nombre)
            var colNombreSucursal = new DataGridViewTextBoxColumn();
            colNombreSucursal.DataPropertyName = "NombreSucursal";
            colNombreSucursal.Name = "Sucursal";
            colNombreSucursal.HeaderText = "Sucursal (Nombre)";
            colNombreSucursal.Visible = true;
            colNombreSucursal.Width = 200;
            dgvConsulta.Columns.Add(colNombreSucursal); // Agregar la columna al DataGridView

            // Configuración de la columna Vehículo (Año, Marca, Modelo)
            var colDescripcionVehiculo = new DataGridViewTextBoxColumn();
            colDescripcionVehiculo.DataPropertyName = "DescripcionVehiculo";
            colDescripcionVehiculo.Name = "Vehiculo";
            colDescripcionVehiculo.HeaderText = "Vehículo";
            colDescripcionVehiculo.Visible = true;
            colDescripcionVehiculo.Width = 300;
            dgvConsulta.Columns.Add(colDescripcionVehiculo); // Agregar la columna al DataGridView

            // Configuración de la columna Vehículo (Estado)
            var colEstadoVehiculo = new DataGridViewTextBoxColumn();
            colEstadoVehiculo.DataPropertyName = "EstadoTexto";
            colEstadoVehiculo.Name = "Estado";
            colEstadoVehiculo.HeaderText = "Vehículo (Estado)";
            colEstadoVehiculo.Visible = true;
            colEstadoVehiculo.Width = 100;
            dgvConsulta.Columns.Add(colEstadoVehiculo); // Agregar la columna al DataGridView

            // Configuración de la columna Vehiculo (Categoria)
            var colCategoria = new DataGridViewTextBoxColumn();
            colCategoria.DataPropertyName = "CategoriaNombre";
            colCategoria.Name = "Categoria";
            colCategoria.HeaderText = "Vehículo (Categoría)";
            colCategoria.Visible = true;
            colCategoria.Width = 150;
            dgvConsulta.Columns.Add(colCategoria); // Agregar la columna al DataGridView

            // Configuración de la columna Vehículo (Cantidad)
            var colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.DataPropertyName = "Cantidad";
            colCantidad.Name = "Cantidad";
            colCantidad.HeaderText = "Vehículo (Cantidad)";
            colCantidad.Visible = true;
            colCantidad.Width = 100;
            dgvConsulta.Columns.Add(colCantidad); // Agregar la columna al DataGridView

            // Configuración de la columna Vehículo (Precio)
            var colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.DataPropertyName = "PrecioTexto";
            colPrecio.Name = "Precio";
            colPrecio.HeaderText = "Vehículo (Precio)";
            colPrecio.Visible = true;
            colPrecio.Width = 100;
            dgvConsulta.Columns.Add(colPrecio); // Agregar la columna al DataGridView

            // Asignar la lista como DataSource
            dgvConsulta.DataSource = vehiculosXSucursal;
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CargarVehiculosXSucursal(); // Recargar la lista de vehículos por sucursal para reflejar cualquier cambio reciente en la información disponible.
        }
    }
}
