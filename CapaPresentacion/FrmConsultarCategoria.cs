using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class FrmConsultarCategoriaVehiculo : Form
    {
        private readonly CategoriaVehiculoBL categoriaVehiculoBL;
        public FrmConsultarCategoriaVehiculo()
        {
            categoriaVehiculoBL = new CategoriaVehiculoBL();
            InitializeComponent();
        }

        private void FrmConsultarCategoriaVehiculo_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            CategoriaVehiculo[] categorias = categoriaVehiculoBL.Consultar();
            if (categorias.Length == 0)
            {
                MessageBox.Show(
                    "No hay categorías de vehículos registradas.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close(); // Cerrar el formulario si no hay categorías disponibles
                return;
            }

            dataGridView.DataSource = null; // Limpiar cualquier fuente de datos previa
            dataGridView.Rows.Clear(); // Limpiar filas existentes
            dataGridView.Columns.Clear(); // Limpiar columnas existentes

            DataGridViewColumn columnaNueva = new DataGridViewColumn();
            DataGridViewCell celdaNueva = new DataGridViewTextBoxCell();

            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "ID";
            columnaNueva.HeaderText = "ID Categoría";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;

            dataGridView.Columns.Add(columnaNueva);

            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();

            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Nombre";
            columnaNueva.HeaderText = "Nombre";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;

            dataGridView.Columns.Add(columnaNueva);

            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();

            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Descripcion";
            columnaNueva.HeaderText = "Descripción";
            columnaNueva.Visible = true;
            columnaNueva.Width = 250;

            dataGridView.Columns.Add(columnaNueva);

            if (categorias != null && categorias.Length > 0)
            {
                foreach (var categoria in categorias)
                {
                    if (categoria != null)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                        row.Cells[0].Value = categoria.IdCategoria;
                        row.Cells[1].Value = categoria.Nombre;
                        row.Cells[2].Value = categoria.Descripcion;
                        dataGridView.Rows.Add(row);
                    }
                }
            }


        }
            
    }
}
