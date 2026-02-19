using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class FrmConsultarCategoria : Form
    {
        private readonly CategoriaVehiculoLN categoriaVehiculoLN;
        public FrmConsultarCategoria()
        {
            categoriaVehiculoLN = new CategoriaVehiculoLN();
            InitializeComponent();
        }

        private void FrmConsultarCategoria_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            CategoriaVehiculo[] categorias = categoriaVehiculoLN.Consultar();
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

            dgvConsulta.DataSource = null; // Limpiar cualquier fuente de datos previa
            dgvConsulta.Rows.Clear(); // Limpiar filas existentes
            dgvConsulta.Columns.Clear(); // Limpiar columnas existentes

            DataGridViewColumn columnaNueva = new DataGridViewColumn();
            DataGridViewCell celdaNueva = new DataGridViewTextBoxCell();

            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "ID";
            columnaNueva.HeaderText = "ID Categoría";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;

            dgvConsulta.Columns.Add(columnaNueva);

            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();

            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Nombre";
            columnaNueva.HeaderText = "Nombre";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;

            dgvConsulta.Columns.Add(columnaNueva);

            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();

            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Descripcion";
            columnaNueva.HeaderText = "Descripción";
            columnaNueva.Visible = true;
            columnaNueva.Width = 250;

            dgvConsulta.Columns.Add(columnaNueva);

            if (categorias != null && categorias.Count() > 0)
            {
                foreach (var categoria in categorias)
                {
                    if (categoria != null)
                    {
                        dgvConsulta.Rows.Add(
                            categoria.IdCategoria,
                            categoria.Nombre,
                            categoria.Descripcion
                        );
                    }
                }
            }
        }
            
    }
}
