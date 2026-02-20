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
    // Formulario principal del sistema, que sirve como menú de navegación para acceder a las diferentes funcionalidades de registro y consulta de información.
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        // Opcion de Registros
        private void CategoriaDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.Show();
        }

        private void VehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehiculo frmVehiculo = new FrmVehiculo();
            frmVehiculo.Show();
        }

        private void VendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedor frmVendedor = new FrmVendedor();
            frmVendedor.Show();
        }

        private void SucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSucursal frmSucursal = new FrmSucursal();
            frmSucursal.Show();
        }

        private void RegistroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Show();
        }

        // Opcion de Consultas de Información
        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCategorias frmConsultarCategorias = new FrmConsultarCategorias();
            frmConsultarCategorias.Show();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarClientes frmConsultarClientes = new FrmConsultarClientes();
            frmConsultarClientes.Show();
        }

        private void SucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarSucursales frmConsultarSucursales = new FrmConsultarSucursales();
            frmConsultarSucursales.Show();
        }

        private void VehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarVehiculos frmConsultarVehiculos = new FrmConsultarVehiculos();
            frmConsultarVehiculos.Show();
        }

        private void VendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarVendedores frmConsultarVendedores = new FrmConsultarVendedores();
            frmConsultarVendedores.Show();
        }
    }
}
