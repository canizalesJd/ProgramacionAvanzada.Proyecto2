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
    // Formulario para registrar una nueva categoría de vehículo en el sistema.
    public partial class FrmCategoria : Form
    {
        // Instancia de la clase de lógica de negocio para gestionar las categorías de vehículos.
        private readonly CategoriaVehiculoLN categoriaVehiculoLN;

        // Constructor del formulario que inicializa los componentes y la instancia de la lógica de negocio.
        public FrmCategoria()
        {
            InitializeComponent();
            categoriaVehiculoLN = new CategoriaVehiculoLN();
        }

        // Método para limpiar los campos de entrada después de registrar una categoría o al cancelar la operación.
        private void LimpiarCampos()
        {
            idCategoria.Clear();
            nombreCategoria.Clear();
            descripcionCategoria.Clear();
        }

        // Evento del botón "Guardar" que se ejecuta al hacer clic. Valida los datos ingresados, registra la categoría utilizando la lógica de negocio y muestra mensajes de éxito o error según corresponda.
        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (!int.TryParse(idCategoria.Text, out int id))
                    {
                        MessageBox.Show("El ID debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string nombre = nombreCategoria.Text.Trim();
                    string descripcion = descripcionCategoria.Text.Trim();

                    categoriaVehiculoLN.RegistrarCategoria(id, nombre, descripcion);

                    MessageBox.Show("Categoría registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento del botón "Cancelar" que se ejecuta al hacer clic. Cierra el formulario actual.
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
