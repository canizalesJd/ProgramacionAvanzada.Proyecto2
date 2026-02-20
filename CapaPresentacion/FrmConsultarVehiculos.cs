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
    // Formulario para consultar la lista de vehículos registrados en el sistema
    public partial class FrmConsultarVehiculos : Form
    {
        // Instancia de la clase de lógica de negocio para gestionar los vehículos.
        private readonly VehiculoLN vehiculoLN;
        public FrmConsultarVehiculos()
        {
            vehiculoLN = new VehiculoLN();
            InitializeComponent();
        }

        // Evento que se ejecuta al cargar el formulario, encargado de cargar la lista de vehículos en el DataGridView
        private void FrmConsultarVehiculos_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
        }

        // Método para cargar la lista de vehículos desde la lógica de negocio y mostrarla en el DataGridView. Configura las columnas del DataGridView y agrega filas con los datos de cada vehículo, incluyendo su categoría y estado formateados adecuadamente.
        private void CargarVehiculos()
        {
            Vehiculo[] vehiculos = vehiculoLN.Consultar();
            if (vehiculos.Length == 0)
            {
                MessageBox.Show(
                    "No hay vehículos registrados.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close(); // Cerrar el formulario si no hay vehículos disponibles
                return;
            }
            dgvConsulta.DataSource = null; // Limpiar cualquier fuente de datos previa
            dgvConsulta.Rows.Clear(); // Limpiar filas existentes
            dgvConsulta.Columns.Clear(); // Limpiar columnas existentes

            // Configurar columnas manualmente para asegurar el orden y formato deseado
            DataGridViewColumn columnaNueva = new DataGridViewColumn();
            DataGridViewCell celdaNueva = new DataGridViewTextBoxCell();

            // Configurar columna para ID Vehículo
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "ID";
            columnaNueva.HeaderText = "ID Vehículo";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configurar columna para Marca
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Marca";
            columnaNueva.HeaderText = "Marca";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configurar columna para Modelo
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Modelo";
            columnaNueva.HeaderText = "Modelo";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configurar columna para Año
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Anio";
            columnaNueva.HeaderText = "Año";
            columnaNueva.Visible = true;
            columnaNueva.Width = 80;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configurar columna para Precio
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Precio";
            columnaNueva.HeaderText = "Precio";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configurar columna para Estado
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Estado";
            columnaNueva.HeaderText = "Estado";
            columnaNueva.Visible = true;
            columnaNueva.Width = 80;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configurar columna para Categoría (Nombre)
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Categoria";
            columnaNueva.HeaderText = "Categoría";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configurar columna para Categoría (Descripción)
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "CategoriaDescripcion";
            columnaNueva.HeaderText = "Descripción Categoría";
            columnaNueva.Visible = true;
            columnaNueva.Width = 200;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Agregar filas con los datos de los vehículos
            // Agregar filas al DataGridView
            if (vehiculos != null && vehiculos.Count() > 0)
            {
                foreach (var vehiculo in vehiculos)
                {
                    if (vehiculo != null)
                    {
                        dgvConsulta.Rows.Add(
                            vehiculo.IdVehiculo,
                            vehiculo.Marca,
                            vehiculo.Modelo,
                            vehiculo.Anio,
                            vehiculo.Precio.ToString("C", new System.Globalization.CultureInfo("es-CR")), // [1]
                            vehiculo.Estado == 'U' ? "Usado" : "Nuevo",
                            vehiculo.Categoria?.Nombre ?? "N/A",
                            vehiculo.Categoria?.Descripcion ?? "N/A"
                        );
                    }
                }
            }
            // Referencias
            // [1] - Formato de moneda: https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#code-example
        }

        // Evento del botón "Actualizar" para recargar la lista de vehículos y reflejar cualquier cambio reciente en la información disponible.
        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CargarVehiculos();
        }
    }
}
