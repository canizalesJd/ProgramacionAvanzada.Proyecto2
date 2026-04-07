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
    // Formulario para consultar la lista de sucursales registradas en el sistema
    public partial class FrmConsultarSucursales : Form
    {
        // Instancia de la clase de lógica de negocio para gestionar las sucursales.
        private readonly SucursalLN sucursalLN;
        public FrmConsultarSucursales()
        {
            sucursalLN = new SucursalLN();
            InitializeComponent();
        }

        // Evento que se ejecuta al cargar el formulario, encargado de cargar la lista de sucursales en el DataGridView
        private void FrmConsultarSucursales_Load(object sender, EventArgs e)
        {
            CargarSucursales();
        }

        // Método encargado de cargar las sucursales desde la lógica de negocio y mostrarlas en el DataGridView. Configura las columnas del DataGridView para mostrar la información relevante de cada sucursal, incluyendo el ID, nombre, dirección, teléfono y detalles del vendedor encargado. Si no hay sucursales registradas, muestra un mensaje informativo y cierra el formulario.
        private void CargarSucursales()
        {
            List<Sucursal> sucursales = sucursalLN.Consultar();
            if (sucursales == null || sucursales.Count == 0)
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

            // Asignar directamente la lista como DataSource
            dgvConsulta.DataSource = null;
            dgvConsulta.Columns.Clear();
            dgvConsulta.AutoGenerateColumns = false;

            // Configurar columna para ID Sucursal
            var colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "IdSucursal";
            colId.Name = "IdSucursal";
            colId.HeaderText = "ID Sucursal";
            colId.Visible = true;
            colId.Width = 100;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(colId);

            // Configurar columna para Nombre
            var colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "Nombre";
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.Visible = true;
            colNombre.Width = 200;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(colNombre);

            // Configurar columna para Dirección
            var colDireccion = new DataGridViewTextBoxColumn();
            colDireccion.DataPropertyName = "Direccion";
            colDireccion.Name = "Direccion";
            colDireccion.HeaderText = "Dirección";
            colDireccion.Visible = true;
            colDireccion.Width = 300;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(colDireccion);

            // Configurar columna para Teléfono
            var colTelefono = new DataGridViewTextBoxColumn();
            colTelefono.DataPropertyName = "Telefono";
            colTelefono.Name = "Telefono";
            colTelefono.HeaderText = "Teléfono";
            colTelefono.Visible = true;
            colTelefono.Width = 150;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(colTelefono);

            // Configurar columna para Vendedor (Nombre)
            var colVendedorNombre = new DataGridViewTextBoxColumn();
            colVendedorNombre.DataPropertyName = "VendedorNombre";
            colVendedorNombre.Name = "NombreVendedor";
            colVendedorNombre.HeaderText = "Vendedor (Nombre)";
            colVendedorNombre.Visible = true;
            colVendedorNombre.Width = 200;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(colVendedorNombre);

            // Configurar columna para Vendedor (Identificación)
            var colVendedorIdentificacion = new DataGridViewTextBoxColumn();
            colVendedorIdentificacion.DataPropertyName = "VendedorIdentificacion";
            colVendedorIdentificacion.Name = "IdentificacionVendedor";
            colVendedorIdentificacion.HeaderText = "Vendedor (Identificación)";
            colVendedorIdentificacion.Visible = true;
            colVendedorIdentificacion.Width = 200;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(colVendedorIdentificacion);

            // Configurar columna para Activa
            var colActiva = new DataGridViewTextBoxColumn();
            colActiva.DataPropertyName = "ActivaTexto";
            colActiva.Name = "Activa";
            colActiva.HeaderText = "Activa";
            colActiva.Visible = true;
            colActiva.Width = 100;
            // Agregar la columna al DataGridView
            dgvConsulta.Columns.Add(colActiva);
            // Usar lista como DataSource para aprovechar el enlace de datos y mostrar las sucursales en el DataGridView.
            dgvConsulta.DataSource = sucursales;
        }

        // Evento del botón "Actualizar" que se ejecuta al hacer clic. Llama al método para cargar las sucursales nuevamente, permitiendo al usuario actualizar la información mostrada en el DataGridView para reflejar cualquier cambio reciente en las sucursales registradas.
        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CargarSucursales();
        }
    }
}
