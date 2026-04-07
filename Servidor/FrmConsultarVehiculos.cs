/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    // Formulario para consultar la lista de vehículos registrados en el sistema
    public partial class FrmConsultarVehiculos : Form
    {
        // Instancia de la clase de lógica de negocio para gestionar los vehículos.
        private readonly VehiculoLN vehiculoLN;
        public FrmConsultarVehiculos()
        {
            vehiculoLN = new VehiculoLN();
            InitializeComponent();
        }

        // Evento que se ejecuta al cargar el formulario, encargado de cargar la lista de vehículos en el DataGridView
        private void FrmConsultarVehiculos_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
        }

        // Método para cargar la lista de vehículos desde la lógica de negocio y mostrarla en el DataGridView. Configura las columnas del DataGridView y agrega filas con los datos de cada vehículo, incluyendo su categoría y estado formateados adecuadamente.
        private void CargarVehiculos()
        {
            List<Vehiculo> vehiculos = vehiculoLN.Consultar();

            if (vehiculos == null || vehiculos.Count == 0)
            {
                MessageBox.Show(
                    "No hay vehículos registrados.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();
                return;
            }

            dgvConsulta.DataSource = null;
            dgvConsulta.Rows.Clear();
            dgvConsulta.Columns.Clear();
            dgvConsulta.AutoGenerateColumns = false;

            // ID Vehículo
            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdVehiculo";
            colId.HeaderText = "ID Vehículo";
            colId.DataPropertyName = "IdVehiculo";
            colId.Visible = true;
            colId.Width = 100;
            dgvConsulta.Columns.Add(colId);

            // Marca
            var colMarca = new DataGridViewTextBoxColumn();
            colMarca.Name = "Marca";
            colMarca.HeaderText = "Marca";
            colMarca.DataPropertyName = "Marca";
            colMarca.Visible = true;
            colMarca.Width = 150;
            dgvConsulta.Columns.Add(colMarca);

            // Modelo
            var colModelo = new DataGridViewTextBoxColumn();
            colModelo.Name = "Modelo";
            colModelo.HeaderText = "Modelo";
            colModelo.DataPropertyName = "Modelo";
            colModelo.Visible = true;
            colModelo.Width = 150;
            dgvConsulta.Columns.Add(colModelo);

            // Año
            var colAnio = new DataGridViewTextBoxColumn();
            colAnio.Name = "Anio";
            colAnio.HeaderText = "Año";
            colAnio.DataPropertyName = "Anio";
            colAnio.Visible = true;
            colAnio.Width = 80;
            dgvConsulta.Columns.Add(colAnio);

            // Precio (se formatea en CellFormatting)
            var colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "Precio";
            colPrecio.HeaderText = "Precio";
            colPrecio.DataPropertyName = "PrecioTexto";
            colPrecio.Visible = true;
            colPrecio.Width = 100;
            dgvConsulta.Columns.Add(colPrecio);

            // Estado (se formatea en CellFormatting)
            var colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.DataPropertyName = "EstadoTexto";
            colEstado.Visible = true;
            colEstado.Width = 80;
            dgvConsulta.Columns.Add(colEstado);

            // Categoría (Nombre)
            var colCategoriaNombre = new DataGridViewTextBoxColumn();
            colCategoriaNombre.Name = "CategoriaNombre";
            colCategoriaNombre.HeaderText = "Categoría";
            colCategoriaNombre.DataPropertyName = "CategoriaNombre"; // usamos CellFormatting
            colCategoriaNombre.Visible = true;
            colCategoriaNombre.Width = 150;
            dgvConsulta.Columns.Add(colCategoriaNombre);

            // Categoría (Descripción)
            var colCategoriaDescripcion  = new DataGridViewTextBoxColumn();
            colCategoriaDescripcion.Name = "CategoriaDescripcion";
            colCategoriaDescripcion.HeaderText = "Descripción Categoría";
            colCategoriaDescripcion.DataPropertyName = "CategoriaDescripcion"; // usamos CellFormatting
            colCategoriaDescripcion.Visible = true;
            colCategoriaDescripcion.Width = 200;
            dgvConsulta.Columns.Add(colCategoriaDescripcion);

            // Asignar la lista como DataSource
            dgvConsulta.DataSource = vehiculos;
        }

        // Evento del botón "Actualizar" para recargar la lista de vehículos y reflejar cualquier cambio reciente en la información disponible.
        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            CargarVehiculos();
        }
    }
}
