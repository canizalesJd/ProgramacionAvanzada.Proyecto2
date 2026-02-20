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
    // Formulario para consultar las categorías de vehículos registradas en el sistema.
    public partial class FrmConsultarCategorias : Form
    {
        // Instancia de la clase de lógica de negocio para gestionar las categorías de vehículos.
        private readonly CategoriaVehiculoLN categoriaVehiculoLN;
        public FrmConsultarCategorias()
        {
            categoriaVehiculoLN = new CategoriaVehiculoLN();
            InitializeComponent();
        }

        // Evento que se ejecuta al cargar el formulario. Llama al método para cargar las categorías de vehículos y mostrarlas en el DataGridView.
        private void FrmConsultarCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        // Método para cargar las categorías de vehículos desde la lógica de negocio y mostrarlas en el DataGridView. Si no hay categorías registradas, muestra un mensaje informativo y cierra el formulario.
        private void CargarCategorias()
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

        // Evento del botón "Actualizar" que se ejecuta al hacer clic. Llama al método para cargar las categorías de vehículos nuevamente, permitiendo al usuario ver cualquier cambio reciente en las categorías disponibles.
        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CargarCategorias();
        }
    }
}
