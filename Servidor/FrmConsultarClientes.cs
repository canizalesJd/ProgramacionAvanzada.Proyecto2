using CapaEntidades;
using CapaLogicaNegocio;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

namespace CapaPresentacion
{
    // Formulario para consultar la lista de clientes registrados en el sistema
    public partial class FrmConsultarClientes : Form
    {
        // Instancia de la capa de lógica de negocio para acceder a las operaciones relacionadas con clientes
        private readonly ClienteLN clienteLN;
        public FrmConsultarClientes()
        {
            clienteLN = new ClienteLN();
            InitializeComponent();
        }

        // Evento que se ejecuta al cargar el formulario, encargado de cargar la lista de clientes en el DataGridView
        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        // Método encargado de cargar la lista de clientes desde la capa de lógica de negocio y mostrarla en el DataGridView
        private void CargarClientes()
        {
            List<Cliente> clientes = clienteLN.Consultar();
            if (clientes == null || clientes.Count == 0)
            {
                MessageBox.Show(
                    "No hay clientes registrados.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close(); // Cerrar el formulario si no hay clientes disponibles
                return;
            }

            // Asignar directamente la lista como DataSource
            dgvConsulta.DataSource = null;
            dgvConsulta.Columns.Clear();
            dgvConsulta.AutoGenerateColumns = false;

            // Columna ID
            var colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "IdCliente";
            colId.Name = "IdCategoria";
            colId.HeaderText = "ID Cliente";
            colId.Width = 100;
            dgvConsulta.Columns.Add(colId);

            // Columna Identificacion
            var colIdentificacion = new DataGridViewTextBoxColumn();
            colIdentificacion.DataPropertyName = "Identificacion";
            colIdentificacion.Name = "Identificacion";
            colIdentificacion.HeaderText = "Identificación";
            colIdentificacion.Width = 100;
            dgvConsulta.Columns.Add(colIdentificacion);

            // Columna Nombre
            var colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "NombreCompleto";
            colNombre.Name = "NombreCompleto";
            colNombre.HeaderText = "Nombre Completo";
            colNombre.Width = 220;
            dgvConsulta.Columns.Add(colNombre);

            // Columna Fecha Nacimiento
            var colFechaNacimiento = new DataGridViewTextBoxColumn();
            colFechaNacimiento.DataPropertyName = "FechaNacimiento";
            colFechaNacimiento.Name = "FechaNacimiento";
            colFechaNacimiento.HeaderText = "Fecha Nacimiento";
            colFechaNacimiento.Width = 100;
            dgvConsulta.Columns.Add(colFechaNacimiento);

            // Columna Fecha Registro
            var colFechaRegistro = new DataGridViewTextBoxColumn();
            colFechaRegistro.DataPropertyName = "FechaRegistro";
            colFechaRegistro.Name = "FechaRegistro";
            colFechaRegistro.HeaderText = "Fecha Registro";
            colFechaRegistro.Width = 100;
            dgvConsulta.Columns.Add(colFechaRegistro);

            // Columna Activo
            var colActivo = new DataGridViewTextBoxColumn();
            colActivo.DataPropertyName = "ActivoTexto";
            colActivo.Name = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.Width = 100;
            dgvConsulta.Columns.Add(colActivo);
            // Usar lista como DataSource para aprovechar el enlace de datos y mostrar los clientes en el DataGridView.
            dgvConsulta.DataSource = clientes;
        }

        // Evento que se ejecuta al hacer clic en el botón "Actualizar", encargado de recargar la lista de clientes en el DataGridView
        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
