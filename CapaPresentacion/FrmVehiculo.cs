using CapaLogicaNegocio;
using CapaEntidades;

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
    public partial class FrmVehiculo : Form
    {
        private readonly VehiculoLN vehiculoLN;
        private readonly CategoriaVehiculoLN categoriaVehiculoLN;

        public FrmVehiculo()
        {
            InitializeComponent();
            vehiculoLN = new VehiculoLN();
            categoriaVehiculoLN = new CategoriaVehiculoLN();
        }

        private void limpiarCampos()
        {
            idVehiculo.Clear();
            marcaVehiculo.Clear();
            modeloVehiculo.Clear();
            anioVehiculo.Clear();
            precioVehiculo.Clear();
            comboCategoriaVehiculo.SelectedIndex = -1;
            comboEstadoVehiculo.SelectedIndex = -1;
        }

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

        private void FrmRegistrarVehiculo_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarEstadoVehiculo();
        }

        private void CargarEstadoVehiculo()
        {
            comboEstadoVehiculo.Items.Clear();

            comboEstadoVehiculo.Items.Add(new { Texto = "Nuevo", Valor = 'N' });
            comboEstadoVehiculo.Items.Add(new { Texto = "Usado", Valor = 'U' });

            comboEstadoVehiculo.DisplayMember = "Texto";
            comboEstadoVehiculo.ValueMember = "Valor";
            comboEstadoVehiculo.SelectedIndex = -1;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
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

                limpiarCampos();
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

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
