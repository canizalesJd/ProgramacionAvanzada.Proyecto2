using CapaAccesoDatos;
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
    // Formulario para consultar la lista de vendedores registrados en el sistema
    public partial class FrmConsultarVendedores : Form
    {
        // Instancia de la clase de lógica de negocio para gestionar los vendedores.
        private readonly VendedorLN vendedorLN;
        public FrmConsultarVendedores()
        {
            vendedorLN = new VendedorLN();
            InitializeComponent();
        }

        // Evento que se ejecuta al cargar el formulario, encargado de cargar la lista de vendedores en el DataGridView
        private void FrmConsultarVendedores_Load(object sender, EventArgs e)
        {
            CargarVendedores();
        }

        // Método para cargar la lista de vendedores desde la lógica de negocio y mostrarla en el DataGridView. Configura las columnas del DataGridView y agrega filas con los datos de cada vendedor, incluyendo su fecha de nacimiento e ingreso formateados adecuadamente.
        private void CargarVendedores()
        {
            List<Vendedor> vendedores = vendedorLN.Consultar();
            if (vendedores == null || vendedores.Count == 0)
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

            // Asignar directamente la lista como DataSource
            dgvConsulta.DataSource = null;
            dgvConsulta.Columns.Clear();
            dgvConsulta.AutoGenerateColumns = false;


            // Configurar columna para ID Vendedor
            var colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "IdVendedor";
            colId.Name = "IdVendedor";
            colId.DataPropertyName = "IdVendedor";
            colId.HeaderText = "ID Vendedor";
            colId.Visible = true;
            colId.Width = 100;
            dgvConsulta.Columns.Add(colId); // Agregar la columna al DataGridView

            // Configurar columna para la Identificación del vendedor
            var colIdentificacion = new DataGridViewTextBoxColumn();
            colIdentificacion.DataPropertyName = "Identificacion";
            colIdentificacion.Name = "Identificacion";
            colIdentificacion.HeaderText = "Identificación";
            colIdentificacion.Visible = true;
            colIdentificacion.Width = 150;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(colIdentificacion);

            // Configurar columna para Nombre
            var colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "NombreCompleto";
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.Visible = true;
            colNombre.Width = 150;
            dgvConsulta.Columns.Add(colNombre); // Agregar la columna al DataGridView

            // Configurar columna para Teléfono
            var colTelefono = new DataGridViewTextBoxColumn();
            colTelefono.DataPropertyName = "Telefono";
            colTelefono.Name = "Telefono";
            colTelefono.HeaderText = "Teléfono";
            colTelefono.Visible = true;
            colTelefono.Width = 120;
            dgvConsulta.Columns.Add(colTelefono); // Agregar la columna al DataGridView

            // Configurar columna para Fecha de Nacimiento
            var colFechaNacimiento = new DataGridViewTextBoxColumn();
            colFechaNacimiento.DataPropertyName = "FechaNacimiento";
            colFechaNacimiento.Name = "FechaNacimiento";
            colFechaNacimiento.HeaderText = "Fecha de Nacimiento";
            colFechaNacimiento.Visible = true;
            colFechaNacimiento.Width = 150;
            dgvConsulta.Columns.Add(colFechaNacimiento); // Agregar la columna al DataGridView

            // Configurar columna para Fecha de Ingreso
            var colFechaIngreso = new DataGridViewTextBoxColumn();
            colFechaIngreso.DataPropertyName = "FechaIngreso";
            colFechaIngreso.Name = "FechaIngreso";
            colFechaIngreso.HeaderText = "Fecha de Ingreso";
            colFechaIngreso.Visible = true;
            colFechaIngreso.Width = 150;
            dgvConsulta.Columns.Add(colFechaIngreso); // Agregar la columna al DataGridView
            // Usar lista como DataSource para aprovechar el enlace de datos y mostrar los vendedores en el DataGridView.
            dgvConsulta.DataSource = vendedores;
        }

        // Evento que se ejecuta al hacer clic en el botón de actualizar, encargado de recargar la lista de vendedores para reflejar cualquier cambio reciente en la información disponible.
        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CargarVendedores();
        }
    }
}
