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
            Cliente[] clientes = clienteLN.Consultar();
            if (clientes.Length == 0)
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

            dgvConsulta.DataSource = null; // Limpiar cualquier fuente de datos previa
            dgvConsulta.Rows.Clear(); // Limpiar filas existentes
            dgvConsulta.Columns.Clear(); // Limpiar columnas existentes

            // Configurar columnas manualmente para asegurar el orden y formato deseado
            DataGridViewColumn columnaNueva = new DataGridViewColumn();
            DataGridViewCell celdaNueva = new DataGridViewTextBoxCell();

            // Configurar columna para ID Cliente
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "ID";
            columnaNueva.HeaderText = "ID Cliente";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Configurar columna para Nombre Completo
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Nombre";
            columnaNueva.HeaderText = "Nombre Completo";
            columnaNueva.Visible = true;
            columnaNueva.Width = 200;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Agregar columna para Fecha Nacimiento
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "FechaNacimiento";
            columnaNueva.HeaderText = "Fecha Nacimiento";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Configurar columna para Fecha Registro
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "FechaRegistro";
            columnaNueva.HeaderText = "Fecha Registro";
            columnaNueva.Visible = true;
            columnaNueva.Width = 150;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Configurar columna para Activo
            columnaNueva = new DataGridViewColumn();
            celdaNueva = new DataGridViewTextBoxCell();
            columnaNueva.CellTemplate = celdaNueva;
            columnaNueva.Name = "Activo";
            columnaNueva.HeaderText = "Activo";
            columnaNueva.Visible = true;
            columnaNueva.Width = 100;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(columnaNueva);

            // Agregar filas al DataGridView
            if (clientes != null && clientes.Count() > 0)
            {
                foreach (var cliente in clientes)
                {
                    if (cliente != null)
                    {
                        dgvConsulta.Rows.Add(
                            cliente.IdCliente,
                            cliente.NombreCompleto,
                            cliente.FechaNacimiento.ToString("dd/MM/yyyy"),
                            cliente.FechaRegistro.ToString("dd/MM/yyyy"),
                            cliente.Activo ? "Sí" : "No"
                        );
                    }
                }
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "Actualizar", encargado de recargar la lista de clientes en el DataGridView
        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
