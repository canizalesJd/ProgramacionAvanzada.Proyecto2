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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void registrarCategoriaVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.Show();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.Show();
        }

        private void registrarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSucursal frm = new FrmSucursal();
            frm.Show();
        }

        private void registrarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedor frm = new FrmVendedor();
            frm.Show();
        }

        private void registrarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehiculo frm = new FrmVehiculo();
            frm.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCategoria frm = new FrmConsultarCategoria();
            frm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente frm = new FrmConsultarCliente();
            frm.Show();
        }
    }
}
