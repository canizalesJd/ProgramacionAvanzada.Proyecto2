using CapaLogicaNegocio;
using CapaEntidades;

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
    // Formulario para registrar un nuevo vehículo en el sistema.
    public partial class FrmVehiculo : Form
    {
        // Instancias de las clases de lógica de negocio para manejar las operaciones relacionadas con vehículos y categorías de vehículos.
        private readonly VehiculoLN vehiculoLN;
        private readonly CategoriaVehiculoLN categoriaVehiculoLN;

        public FrmVehiculo()
        {
            InitializeComponent();
            vehiculoLN = new VehiculoLN();
            categoriaVehiculoLN = new CategoriaVehiculoLN();
        }

        // Método para limpiar los campos del formulario después de registrar un vehículo o al cancelar la operación.
        private void LimpiarCampos()
        {
            idVehiculo.Clear();
            marcaVehiculo.Clear();
            modeloVehiculo.Clear();
            anioVehiculo.Clear();
            precioVehiculo.Clear();
            comboCategoriaVehiculo.SelectedIndex = -1;
            comboEstadoVehiculo.SelectedIndex = -1;
        }

        // Método para cargar las categorías de vehículos disponibles en el sistema. Si no hay categorías registradas, se muestra un mensaje informativo y se deshabilitan los controles relacionados con la selección de categoría y el botón de guardar, además de cerrar el formulario.
        private void CargarCategorias()
        {
            CategoriaVehiculo[] categorias = categoriaVehiculoLN.Consultar();
            if (categorias.Length == 0)
            {
                MessageBox.Show(
                    "No hay categorías de vehículos registradas. Debe registrar al menos una antes de crear un vehículo.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                comboCategoriaVehiculo.Enabled = false;
                botonGuardar.Enabled = false;
                this.Close(); // Cerrar el formulario si no hay categorías disponibles
                return;
            }
            comboCategoriaVehiculo.DataSource = categorias;
            comboCategoriaVehiculo.DisplayMember = $"Nombre";
            comboCategoriaVehiculo.ValueMember = "IdCategoria";
            comboCategoriaVehiculo.SelectedIndex = -1;
            comboCategoriaVehiculo.Enabled = true;
            botonGuardar.Enabled = true;
        }

        // Evento que se ejecuta al cargar el formulario. Llama a los métodos para cargar las categorías de vehículos y el estado del vehículo en los controles correspondientes.
        private void FrmRegistrarVehiculo_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarEstadoVehiculo();
        }

        // Método para cargar las opciones de estado del vehículo en el combo box. Se agregan las opciones "Nuevo" y "Usado" con sus respectivos valores 'N' y 'U'. Se establece el DisplayMember y ValueMember para mostrar el texto correcto en el combo box.
        private void CargarEstadoVehiculo()
        {
            comboEstadoVehiculo.Items.Clear();
            comboEstadoVehiculo.Items.Add("Nuevo");
            comboEstadoVehiculo.Items.Add("Usado");
            comboEstadoVehiculo.SelectedIndex = -1;
        }

        // Evento que se ejecuta al hacer clic en el botón de guardar. Valida los datos ingresados, registra el vehículo utilizando la lógica de negocio y muestra mensajes de éxito o error según corresponda.
        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idVehiculo.Text);
                string marca = marcaVehiculo.Text;
                string modelo = modeloVehiculo.Text;
                int anio = int.Parse(anioVehiculo.Text);
                decimal precio = decimal.Parse(precioVehiculo.Text);

                if (comboCategoriaVehiculo.SelectedItem is not CategoriaVehiculo categoriaSeleccionada)
                {
                    MessageBox.Show("Debe seleccionar una categoría.");
                    return;
                }

                if (comboEstadoVehiculo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar el estado del vehículo.");
                    return;
                }

                char estado = comboEstadoVehiculo.SelectedItem.ToString() == "Nuevo" ? 'N' : 'U';

                vehiculoLN.RegistrarVehiculo(
                    id,
                    marca,
                    modelo,
                    anio,
                    precio,
                    categoriaSeleccionada,
                    estado
                );

                MessageBox.Show("Vehículo registrado exitosamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos para ID, Año y Precio.",
                    "Error de formato",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Evento que se ejecuta al hacer clic en el botón de cancelar. Cierra el formulario sin guardar ningún cambio.
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
