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
    public partial class FrmConsultarSucursales : Form
    {
        private readonly SucursalLN sucursalLN;
        public FrmConsultarSucursales()
        {
            sucursalLN = new SucursalLN();
            InitializeComponent();
        }

        private void FrmConsultarSucursales_Load(object sender, EventArgs e)
        {
            cargarSucursales();
        }

        private void cargarSucursales()
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

            // Agregar filas con los datos de las sucursales
            // Agregar las filas con los datos de las categorías
            if (sucursales != null && sucursales.Count() > 0)
            {
                foreach (var sucursal in sucursales)
                {
                    if (sucursal != null)
                    {
                        dgvConsulta.Rows.Add(
                            sucursal.IdSucursal,
                            sucursal.Nombre,
                            sucursal.Direccion,
                            sucursal.Telefono,
                            sucursal.VendedorEncargado != null ? sucursal.VendedorEncargado.NombreCompleto : "N/A",
                            sucursal.VendedorEncargado != null ? sucursal.VendedorEncargado.Identificacion : "N/A"
                        );
                    }
                }
            }


        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            cargarSucursales();
        }
    }
}
