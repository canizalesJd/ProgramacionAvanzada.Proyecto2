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
    // Formulario para consultar la lista de sucursales registradas en el sistema
    public partial class FrmConsultarSucursales : Form
    {
        // Instancia de la clase de lógica de negocio para gestionar las sucursales.
        private readonly SucursalLN sucursalLN;
        public FrmConsultarSucursales()
        {
            sucursalLN = new SucursalLN();
            InitializeComponent();
        }

        // Evento que se ejecuta al cargar el formulario, encargado de cargar la lista de sucursales en el DataGridView
        private void FrmConsultarSucursales_Load(object sender, EventArgs e)
        {
            CargarSucursales();
        }

        // Método encargado de cargar las sucursales desde la lógica de negocio y mostrarlas en el DataGridView. Configura las columnas del DataGridView para mostrar la información relevante de cada sucursal, incluyendo el ID, nombre, dirección, teléfono y detalles del vendedor encargado. Si no hay sucursales registradas, muestra un mensaje informativo y cierra el formulario.
        private void CargarSucursales()
        {
            Sucursal[] sucursales = sucursalLN.Consultar();
            if (sucursales.Length == 0)
            {
                MessageBox.Show(
                    "No hay sucursales registradas.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close(); // Cerrar el formulario si no hay sucursales disponibles
                return;
            }

            dgvConsulta.DataSource = null; // Limpiar cualquier fuente de datos previa
            dgvConsulta.Rows.Clear(); // Limpiar filas existentes
            dgvConsulta.Columns.Clear(); // Limpiar columnas existentes

            // Configurar columnas manualmente para asegurar el orden y formato deseado
            DataGridViewColumn columnaNueva = new DataGridViewColumn();
            DataGridViewCell celdaNueva = new DataGridViewTextBoxCell();

            // Configurar columna para ID Sucursal
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "ID";
            columnaNueva.HeaderText = "ID Sucursal";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Configurar columna para Nombre
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Nombre";
            columnaNueva.HeaderText = "Nombre";
            columnaNueva.Visible = true;
            columnaNueva.Width = 200;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Configurar columna para Dirección
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Direccion";
            columnaNueva.HeaderText = "Dirección";
            columnaNueva.Visible = true;
            columnaNueva.Width = 300;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Configurar columna para Teléfono
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Telefono";
            columnaNueva.HeaderText = "Teléfono";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Configurar columna para Vendedor (Nombre)
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "NombreVendedor";
            columnaNueva.HeaderText = "Vendedor (Nombre)";
            columnaNueva.Visible = true;
            columnaNueva.Width = 200;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Configurar columna para Vendedor (Identificación)
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "IdentificacionVendedor";
            columnaNueva.HeaderText = "Vendedor (Identificación)";
            columnaNueva.Visible = true;
            columnaNueva.Width = 200;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Configurar columna para Activa
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Activa";
            columnaNueva.HeaderText = "Activa";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Agregar filas con los datos de las sucursales
            if (sucursales != null && sucursales.Length > 0)
            {
                for (int i = 0; i < sucursales.Length; i++)
                {
                    Sucursal sucursal = sucursales[i];
                    if (sucursal != null)
                    {
                        dgvConsulta.Rows.Add(
                            sucursal.IdSucursal,
                            sucursal.Nombre,
                            sucursal.Direccion,
                            sucursal.Telefono,
                            sucursal.VendedorEncargado != null ? sucursal.VendedorEncargado.NombreCompleto : "N/A",
                            sucursal.VendedorEncargado != null ? sucursal.VendedorEncargado.Identificacion : "N/A",
                            sucursal.Activa ? "Sí" : "No"
                        );
                    }
                }
            }
        }

        // Evento del botón "Actualizar" que se ejecuta al hacer clic. Llama al método para cargar las sucursales nuevamente, permitiendo al usuario actualizar la información mostrada en el DataGridView para reflejar cualquier cambio reciente en las sucursales registradas.
        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CargarSucursales();
        }
    }
}
