namespace CapaPresentacion
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPrincipal = new MenuStrip();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            categoriaDeVehiculoToolStripMenuItem = new ToolStripMenuItem();
            vehiculoToolStripMenuItem = new ToolStripMenuItem();
            vendedorToolStripMenuItem = new ToolStripMenuItem();
            sucursalToolStripMenuItem = new ToolStripMenuItem();
            registroClienteToolStripMenuItem = new ToolStripMenuItem();
            consultarInformacionToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            sucursalesToolStripMenuItem = new ToolStripMenuItem();
            vehiculosToolStripMenuItem = new ToolStripMenuItem();
            vendedoresToolStripMenuItem = new ToolStripMenuItem();
            footer = new Label();
            titulo = new Label();
            vehiculoPorSucursalToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Items.AddRange(new ToolStripItem[] { registrosToolStripMenuItem, consultarInformacionToolStripMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Padding = new Padding(7, 2, 0, 2);
            menuPrincipal.Size = new Size(568, 24);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaDeVehiculoToolStripMenuItem, vehiculoToolStripMenuItem, vendedorToolStripMenuItem, sucursalToolStripMenuItem, registroClienteToolStripMenuItem, vehiculoPorSucursalToolStripMenuItem });
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(67, 20);
            registrosToolStripMenuItem.Text = "Registros";
            // 
            // categoriaDeVehiculoToolStripMenuItem
            // 
            categoriaDeVehiculoToolStripMenuItem.Name = "categoriaDeVehiculoToolStripMenuItem";
            categoriaDeVehiculoToolStripMenuItem.Size = new Size(189, 22);
            categoriaDeVehiculoToolStripMenuItem.Text = "Categoría de Vehículo";
            categoriaDeVehiculoToolStripMenuItem.Click += CategoriaDeVehiculoToolStripMenuItem_Click;
            // 
            // vehiculoToolStripMenuItem
            // 
            vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            vehiculoToolStripMenuItem.Size = new Size(189, 22);
            vehiculoToolStripMenuItem.Text = "Vehículo";
            vehiculoToolStripMenuItem.Click += VehiculoToolStripMenuItem_Click;
            // 
            // vendedorToolStripMenuItem
            // 
            vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            vendedorToolStripMenuItem.Size = new Size(189, 22);
            vendedorToolStripMenuItem.Text = "Vendedor";
            vendedorToolStripMenuItem.Click += VendedorToolStripMenuItem_Click;
            // 
            // sucursalToolStripMenuItem
            // 
            sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            sucursalToolStripMenuItem.Size = new Size(189, 22);
            sucursalToolStripMenuItem.Text = "Sucursal";
            sucursalToolStripMenuItem.Click += SucursalToolStripMenuItem_Click;
            // 
            // registroClienteToolStripMenuItem
            // 
            registroClienteToolStripMenuItem.Name = "registroClienteToolStripMenuItem";
            registroClienteToolStripMenuItem.Size = new Size(189, 22);
            registroClienteToolStripMenuItem.Text = "Cliente";
            registroClienteToolStripMenuItem.Click += RegistroClienteToolStripMenuItem_Click;
            // 
            // consultarInformacionToolStripMenuItem
            // 
            consultarInformacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem, clienteToolStripMenuItem, sucursalesToolStripMenuItem, vehiculosToolStripMenuItem, vendedoresToolStripMenuItem });
            consultarInformacionToolStripMenuItem.Name = "consultarInformacionToolStripMenuItem";
            consultarInformacionToolStripMenuItem.Size = new Size(138, 20);
            consultarInformacionToolStripMenuItem.Text = "Consultar Información";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(192, 22);
            categoriaToolStripMenuItem.Text = " Categoría de Vehículo";
            categoriaToolStripMenuItem.Click += CategoriaToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(192, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += ClienteToolStripMenuItem_Click;
            // 
            // sucursalesToolStripMenuItem
            // 
            sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            sucursalesToolStripMenuItem.Size = new Size(192, 22);
            sucursalesToolStripMenuItem.Text = "Sucursales";
            sucursalesToolStripMenuItem.Click += SucursalesToolStripMenuItem_Click;
            // 
            // vehiculosToolStripMenuItem
            // 
            vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            vehiculosToolStripMenuItem.Size = new Size(192, 22);
            vehiculosToolStripMenuItem.Text = "Vehículos";
            vehiculosToolStripMenuItem.Click += VehiculosToolStripMenuItem_Click;
            // 
            // vendedoresToolStripMenuItem
            // 
            vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            vendedoresToolStripMenuItem.Size = new Size(192, 22);
            vendedoresToolStripMenuItem.Text = "Vendedores";
            vendedoresToolStripMenuItem.Click += VendedoresToolStripMenuItem_Click;
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.Location = new Point(158, 349);
            footer.Margin = new Padding(4, 0, 4, 0);
            footer.Name = "footer";
            footer.Size = new Size(273, 15);
            footer.TabIndex = 1;
            footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            footer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.None;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(188, 169);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(209, 42);
            titulo.TabIndex = 2;
            titulo.Text = "AutoMarket";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vehiculoPorSucursalToolStripMenuItem
            // 
            vehiculoPorSucursalToolStripMenuItem.Name = "vehiculoPorSucursalToolStripMenuItem";
            vehiculoPorSucursalToolStripMenuItem.Size = new Size(189, 22);
            vehiculoPorSucursalToolStripMenuItem.Text = "Vehículo por Sucursal";
            vehiculoPorSucursalToolStripMenuItem.Click += VehiculoPorSucursalToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 373);
            Controls.Add(titulo);
            Controls.Add(footer);
            Controls.Add(menuPrincipal);
            MainMenuStrip = menuPrincipal;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMenu";
            Text = "AutoMarket - Inicio";
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem consultarInformacionToolStripMenuItem;
        private System.Windows.Forms.Label footer;
        private System.Windows.Forms.Label titulo;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem registrosToolStripMenuItem;
        private ToolStripMenuItem categoriaDeVehiculoToolStripMenuItem;
        private ToolStripMenuItem vehiculoToolStripMenuItem;
        private ToolStripMenuItem vendedorToolStripMenuItem;
        private ToolStripMenuItem sucursalToolStripMenuItem;
        private ToolStripMenuItem registroClienteToolStripMenuItem;
        private ToolStripMenuItem sucursalesToolStripMenuItem;
        private ToolStripMenuItem vehiculosToolStripMenuItem;
        private ToolStripMenuItem vendedoresToolStripMenuItem;
        private ToolStripMenuItem vehiculoPorSucursalToolStripMenuItem;
    }
}

