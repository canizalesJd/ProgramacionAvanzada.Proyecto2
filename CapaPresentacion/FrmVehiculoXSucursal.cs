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
    // Formulario para mostrar los vehículos disponibles en cada sucursal.
    public partial class FrmVehiculoXSucursal : Form
    {
        // Instancia de la clase de lógica de negocio para gestionar las operaciones relacionadas con las sucursales y los vehículos.
        private readonly SucursalLN sucursalLN;
        private readonly VehiculoLN vehiculoLN;
        private readonly VehiculoXSucursalLN vehiculoXSucursalLN;

        public FrmVehiculoXSucursal()
        {
            InitializeComponent();
            sucursalLN = new SucursalLN();
            vehiculoLN = new VehiculoLN();
            vehiculoXSucursalLN = new VehiculoXSucursalLN();
        }

        private void FrmVehiculoXSucursal_Load(object sender, EventArgs e)
        {
            CargarSucursales();
            CargarVehiculos();
        }

        private void CargarSucursales()
        {
            List<Sucursal> sucursales = sucursalLN.ConsultarActivas();

            if (sucursales == null || sucursales.Count == 0)
            {
                MessageBox.Show(
                    "No hay sucursales activas registradas. Solo se pueden asignar vehículos a sucursales activas.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                comboSucursal.Enabled = false;
                botonGuardar.Enabled = false;
                this.Close(); // Cerrar el formulario si no hay sucursales disponibles
                return;
            }

            comboSucursal.DataSource = sucursales;
            comboSucursal.DisplayMember = "Nombre";
            comboSucursal.ValueMember = "IdSucursal";
            comboSucursal.SelectedIndex = -1;

            comboSucursal.Enabled = true;
            botonGuardar.Enabled = true;
        }

        private void CargarVehiculos()
        {
            List<Vehiculo> vehiculos = vehiculoLN.Consultar();
            if (vehiculos == null || vehiculos.Count == 0)
            {
                MessageBox.Show(
                    "No hay vehículos registrados. Debe registrar al menos uno antes de asignar a una sucursal.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                comboVehiculo.Enabled = false;
                botonGuardar.Enabled = false;
                this.Close(); // Cerrar el formulario si no hay vehículos disponibles
                return;
            }
            comboVehiculo.DataSource = vehiculos;
            comboVehiculo.DisplayMember = "DisplayMember";
            comboVehiculo.ValueMember = "IdVehiculo";
            comboVehiculo.SelectedIndex = -1;
            comboVehiculo.Enabled = true;
            botonGuardar.Enabled = true;
        }

        // Limpia todos los campos del formulario
        private void LimpiarCampos()
        {
            comboSucursal.SelectedIndex = -1;
            comboVehiculo.SelectedIndex = -1;
            cantidad.Clear();
        }

        // Evento del botón Guardar
        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de entrada

                if (comboSucursal.SelectedItem is not Sucursal sucursalSeleccionada)
                {
                    MessageBox.Show(
                        "Debe seleccionar una sucursal.",
                        "Error",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // La sucursal debe estar activa 
                if (!sucursalSeleccionada.Activa)
                {
                    MessageBox.Show(
                        "La sucursal seleccionada no está activa. Solo se pueden asignar vehículos a sucursales activas.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                if (comboVehiculo.SelectedItem is not Vehiculo vehiculoSeleccionado)
                {
                    MessageBox.Show("Debe seleccionar un vehículo.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                if (!int.TryParse(cantidad.Text, out int cantidadVehiculo))
                {
                    MessageBox.Show(
                        "La cantidad debe ser un número entero válido.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                if (cantidadVehiculo <= 0)
                {
                    MessageBox.Show(
                        "La cantidad debe ser un número entero positivo.",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                vehiculoXSucursalLN.RegistrarVehiculoXSucursal(
                    vehiculoSeleccionado,
                    sucursalSeleccionada,
                    cantidadVehiculo
                );

                MessageBox.Show(
                    "Vehículo asignado a la sucursal exitosamente.",
                    "Éxito", MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimpiarCampos();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error de operación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error inesperado: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Evento del botón Cancelar
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
