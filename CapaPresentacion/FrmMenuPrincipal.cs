using System;
using System.Windows.Forms;

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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void registrarCategoriaVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoriaVehiculo frm = new FrmRegistrarCategoriaVehiculo();
            frm.Show();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente frm = new FrmRegistrarCliente();
            frm.Show();
        }

        private void registrarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarSucursal frm = new FrmRegistrarSucursal();
            frm.Show();
        }

        private void registrarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarVendedor frm = new FrmRegistrarVendedor();
            frm.Show();
        }
    }
}
