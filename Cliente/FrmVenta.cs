/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

using CapaEntidades;
using Cliente.Comunicacion;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Windows.Forms;

namespace Cliente
{
    public partial class FrmVenta : Form
    {
        // Instancia de la clase ClienteSocket para manejar la comunicación con el servidor.
        private ClienteSocket cliente;
        public FrmVenta(ClienteSocket clienteSocket)
        {
            InitializeComponent();
            this.cliente = clienteSocket;

            // Cargar las sucursales activas al iniciar el formulario
            CargarSucursales();
            comboVehiculo.Enabled = false; // Deshabilitar el combo de vehículos hasta que se seleccione una sucursal
        }

        // Metodo para cargar las sucursales activas
        public void CargarSucursales()
        {
            List<Sucursal> sucursales = cliente.ObtenerSucursalesActivas();

            if (sucursales == null || sucursales.Count == 0)
            {
                MessageBox.Show(
                    "No hay sucursales activas registradas. Debe registrar al menos una antes de crear una venta.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                comboSucursal.Enabled = false;
                return;
            }
            comboSucursal.DataSource = sucursales;
            comboSucursal.DisplayMember = "Nombre";
            comboSucursal.ValueMember = "IdSucursal";
            comboSucursal.SelectedIndex = -1;

            comboSucursal.Enabled = true;
            comboVehiculo.Enabled = true; // Habilitar el combo de vehículos ahora que hay sucursales disponibles
        }

        // Cargar los vehículos disponibles para la sucursal seleccionada
        private void comboSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSucursal.SelectedIndex != -1 && comboSucursal.SelectedItem is Sucursal sucursal) // validar que el elemento seleccionado sea una instancia de Sucursal
            {
                comboVehiculo.DataSource = null; // Limpiar el combo de vehículos antes de cargar los nuevos datos
                comboVehiculo.Items.Clear(); // Limpiar los items del combo de vehículos

                int idSucursal = sucursal.IdSucursal;
                List<Vehiculo> vehiculos = cliente.ObtenerVehiculosPorSucursal(idSucursal); // Obtener los vehículos disponibles para la sucursal seleccionada

                if (vehiculos == null || vehiculos.Count == 0)
                {
                    MessageBox.Show(
                        "No hay vehículos disponibles en esta sucursal. Por favor, seleccione otra sucursal.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    // Quitar seleccion del combo sucursal para forzar al usuario a seleccionar otra sucursal
                    comboSucursal.SelectedIndex = -1;
                    return;
                }
                // Cargar los vehículos en el combo box
                comboVehiculo.Enabled = true; // Habilitar el combo de vehículos ahora que hay vehículos disponibles para la sucursal seleccionada
                comboVehiculo.DataSource = vehiculos;
                comboVehiculo.DisplayMember = "DisplayMember";
                comboVehiculo.ValueMember = "IdVehiculo";
                comboVehiculo.SelectedIndex = 0;
            }
        }

        // Cargar el precio del vehículo seleccionado en el campo de texto correspondiente
        private void comboVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVehiculo.SelectedIndex != -1 && comboVehiculo.SelectedItem is Vehiculo vehiculo) // validar que el elemento seleccionado sea una instancia de Vehiculo
            {
                precio.Text = vehiculo.PrecioTexto;
            }
        }

        // Metodo para manejar el evento del botón de realizar venta.
        private void RegistrarVenta()
        {
            if (comboVehiculo.SelectedItem is not Vehiculo vehiculoSeleccionado)
            {
                MessageBox.Show("Por favor, seleccione un vehículo para realizar la venta.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboSucursal.SelectedItem is not Sucursal sucursalSeleccionada)
            {
                MessageBox.Show("Por favor, seleccione una sucursal para realizar la venta.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CapaEntidades.Cliente clienteAutenticado = cliente.ClienteAutenticado!; // ! para indicar que se asume que el cliente autenticado no es nulo

            Venta nuevaVenta = new Venta(
                clienteAutenticado,
                sucursalSeleccionada,
                vehiculoSeleccionado,
                DateTime.Now,
                vehiculoSeleccionado.Precio
            );

            bool ventaExitosa = cliente.RegistrarVenta(nuevaVenta);

            if (ventaExitosa)
            {
                MessageBox.Show("¡Venta realizada con éxito!", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al realizar la venta. Por favor, inténtelo de nuevo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            RegistrarVenta(); // Llamar al método para registrar la venta al hacer clic en el botón de guardar
        }
    }
}
