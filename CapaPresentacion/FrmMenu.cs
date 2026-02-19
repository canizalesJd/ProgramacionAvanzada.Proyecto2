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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        // Registros
        private void categoriaDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehiculo frmVehiculo = new FrmVehiculo();
            frmVehiculo.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedor frmVendedor = new FrmVendedor();
            frmVendedor.Show();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSucursal frmSucursal = new FrmSucursal();
            frmSucursal.Show();
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Show();
        }

        // Consultas de Información
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCategorias frmConsultarCategorias = new FrmConsultarCategorias();
            frmConsultarCategorias.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarClientes frmConsultarClientes = new FrmConsultarClientes();
            frmConsultarClientes.Show();
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarSucursales frmConsultarSucursales = new FrmConsultarSucursales();
            frmConsultarSucursales.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarVehiculos frmConsultarVehiculos = new FrmConsultarVehiculos();
            frmConsultarVehiculos.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarVendedores frmConsultarVendedores = new FrmConsultarVendedores();
            frmConsultarVendedores.Show();
        }
    }
}
