using CapaEntidades;
using CapaLogicaNegocio;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: Jose David Canizales Azocar
 * Fecha: Febrero 2026
 */

namespace CapaPresentacion
{
    public partial class FrmConsultarCategorias : Form
    {
        private readonly CategoriaVehiculoLN categoriaVehiculoLN;
        public FrmConsultarCategorias()
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

            // Configurar las columnas del DataGridView
            DataGridViewColumn columnaNueva = new DataGridViewColumn();
            DataGridViewCell celdaNueva = new DataGridViewTextBoxCell();

            // Configuración de la columna ID
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "ID";
            columnaNueva.HeaderText = "ID Categoría";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Configuración de la columna Nombre
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Nombre";
            columnaNueva.HeaderText = "Nombre";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Configuración de la columna Descripción
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Descripcion";
            columnaNueva.HeaderText = "Descripción";
            columnaNueva.Visible = true;
            columnaNueva.Width = 250;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Agregar las filas con los datos de las categorías
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

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            cargarCategorias();
        }
    }
}
