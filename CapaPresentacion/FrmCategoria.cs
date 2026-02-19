using CapaLogicaNegocio;

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
    public partial class FrmCategoria : Form
    {
        private readonly CategoriaVehiculoLN categoriaVehiculoLN;
        public FrmCategoria()
        {
            InitializeComponent();
            categoriaVehiculoLN = new CategoriaVehiculoLN();
        }
        private void LimpiarCampos()
        {
            idCategoria.Clear();
            nombreCategoria.Clear();
            descripcionCategoria.Clear();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
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

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
