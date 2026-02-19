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
    public partial class FrmConsultarVendedores : Form
    {
        private readonly VendedorLN vendedorLN;
        public FrmConsultarVendedores()
        {
            vendedorLN = new VendedorLN();
            InitializeComponent();
        }

        private void FrmConsultarVendedores_Load(object sender, EventArgs e)
        {
            cargarVendedores();
        }

        private void cargarVendedores()
        {
            Vendedor[] vendedores = vendedorLN.Consultar();
            if (vendedores.Length == 0)
            {
                MessageBox.Show(
                    "No hay vendedores registrados.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close(); // Cerrar el formulario si no hay vendedores disponibles
                return;
            }

            dgvConsulta.DataSource = null; // Limpiar cualquier fuente de datos previa
            dgvConsulta.Rows.Clear(); // Limpiar filas existentes
            dgvConsulta.Columns.Clear(); // Limpiar columnas existentes

            // Configurar columnas manualmente para asegurar el orden y formato deseado
            DataGridViewColumn columnaNueva = new DataGridViewColumn();
            DataGridViewCell celdaNueva = new DataGridViewTextBoxCell();
            // Configurar columna para ID Vendedor
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "ID";
            columnaNueva.HeaderText = "ID Vendedor";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configurar columna para Nombre
            columnaNueva = new DataGridViewColumn();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Nombre";
            columnaNueva.HeaderText = "Nombre";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configurar columna para Teléfono
            columnaNueva = new DataGridViewColumn();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Telefono";
            columnaNueva.HeaderText = "Teléfono";
            columnaNueva.Visible = true;
            columnaNueva.Width = 120;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configurar columna para Fecha de Nacimiento
            columnaNueva = new DataGridViewColumn();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "FechaNacimiento";
            columnaNueva.HeaderText = "Fecha de Nacimiento";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Configurar columna para Fecha de Ingreso
            columnaNueva = new DataGridViewColumn();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "FechaIngreso";
            columnaNueva.HeaderText = "Fecha de Ingreso";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;
            dgvConsulta.Columns.Add(columnaNueva); // Agregar la columna al DataGridView

            // Agregar filas con los datos de los vendedores
            if (vendedores.Length > 0)
            {
                foreach (var vendedor in vendedores)
                {
                    if (vendedor != null)
                    {
                        dgvConsulta.Rows.Add(
                            vendedor.IdVendedor,
                            vendedor.NombreCompleto,
                            vendedor.Telefono,
                            vendedor.FechaNacimiento.ToString("dd/MM/yyyy"),
                            vendedor.FechaIngreso.ToString("dd/MM/yyyy")
                        );
                    }
                }
            }

        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            cargarVendedores();
        }
    }
}
