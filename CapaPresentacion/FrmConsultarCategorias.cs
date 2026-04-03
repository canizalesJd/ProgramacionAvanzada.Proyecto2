using CapaEntidades;
using CapaLogicaNegocio;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Marzo 2026
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
            List<CategoriaVehiculo> categorias = categoriaVehiculoLN.Consultar();
            if (categorias == null || categorias.Count == 0)
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

            // Asignar directamente la lista como DataSource
            dgvConsulta.DataSource = null;
            dgvConsulta.Columns.Clear();
            dgvConsulta.AutoGenerateColumns = false;

            // Configurar las columnas del DataGridView
            DataGridViewColumn columnaNueva = new DataGridViewColumn();
            DataGridViewCell celdaNueva = new DataGridViewTextBoxCell();

            // Columna ID
            var colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "IdCategoria";   // nombre de la propiedad en la entidad
            colId.Name = "IdCategoria";
            colId.HeaderText = "ID Categoría";
            colId.Width = 100;
            dgvConsulta.Columns.Add(colId);

            // Columna Nombre
            var colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "Nombre";
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.Width = 150;
            dgvConsulta.Columns.Add(colNombre);

            // Columna Descripción
            var colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.DataPropertyName = "Descripcion";
            colDescripcion.Name = "Descripcion";
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.Width = 250;
            dgvConsulta.Columns.Add(colDescripcion);

            // Aquí es donde cumples el enunciado:
            dgvConsulta.DataSource = categorias;
        }

        // Evento del botón "Actualizar" que se ejecuta al hacer clic. Llama al método para cargar las categorías de vehículos nuevamente, permitiendo al usuario ver cualquier cambio reciente en las categorías disponibles.
        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CargarCategorias();
        }
    }
}
