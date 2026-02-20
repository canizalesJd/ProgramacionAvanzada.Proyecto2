using CapaEntidades;
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
            VehiculoXSucursal[] vehiculosXSucursal = vehiculoXSucursalLN.Consultar();
            if (vehiculosXSucursal.Length == 0)
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
            dgvConsulta.DataSource = null; // Limpiar cualquier fuente de datos previa
            dgvConsulta.Rows.Clear(); // Limpiar filas existentes
            dgvConsulta.Columns.Clear(); // Limpiar columnas existentes

            // Configurar las columnas del DataGridView
            DataGridViewColumn columnaNueva = new DataGridViewColumn();
            DataGridViewCell celdaNueva = new DataGridViewTextBoxCell();

            // Configuración de la columna Sucursal (Nombre)
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Sucursal";
            columnaNueva.HeaderText = "Sucursal (Nombre)";
            columnaNueva.Visible = true;
            columnaNueva.Width = 200;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configuración de la columna Vehículo (Año, Marca, Modelo)
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Vehiculo";
            columnaNueva.HeaderText = "Vehículo";
            columnaNueva.Visible = true;
            columnaNueva.Width = 300;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configuración de la columna Vehículo (Estado)
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Estado";
            columnaNueva.HeaderText = "Vehículo (Estado)";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configuración de la columna Vehiculo (Categoria)
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Categoria";
            columnaNueva.HeaderText = "Vehículo (Categoría)";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configuración de la columna Vehículo (Cantidad)
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Cantidad";
            columnaNueva.HeaderText = "Vehículo (Cantidad)";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configuración de la columna Vehículo (Precio)
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Precio";
            columnaNueva.HeaderText = "Vehículo (Precio)";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Agregar filas con los datos de los vehículos
            // Agregar filas al DataGridView
            if (vehiculosXSucursal != null && vehiculosXSucursal.Length > 0)
            {              
                for (int i = 0; i < vehiculosXSucursal.Length; i++)
                {
                    VehiculoXSucursal vehiculoXSucursal = vehiculosXSucursal[i];
                    if (vehiculoXSucursal != null)
                    {
                        dgvConsulta.Rows.Add(
                            vehiculoXSucursal.Sucursal.Nombre,
                            vehiculoXSucursal.Vehiculo.DisplayMember,
                            vehiculoXSucursal.Vehiculo.Estado == 'U' ? "Usado" : "Nuevo",
                            vehiculoXSucursal.Vehiculo.Categoria.Nombre,
                            vehiculoXSucursal.Cantidad,
                            vehiculoXSucursal.Vehiculo.Precio.ToString("C", new System.Globalization.CultureInfo("es-CR")) // [1]
                        );
                    }
                }
            }
            // Referencias
            // [1] - Formato de moneda: https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#code-example
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CargarVehiculosXSucursal(); // Recargar la lista de vehículos por sucursal para reflejar cualquier cambio reciente en la información disponible.
        }
    }
}
