namespace CapaPresentacion
{
    partial class FrmMenuPrincipal
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
            registrarCategoriaVehiculoToolStripMenuItem = new ToolStripMenuItem();
            registrarVehículoToolStripMenuItem = new ToolStripMenuItem();
            registrarVendedorToolStripMenuItem = new ToolStripMenuItem();
            registrarSucursalToolStripMenuItem = new ToolStripMenuItem();
            registrarClienteToolStripMenuItem = new ToolStripMenuItem();
            consultarInformaciónToolStripMenuItem = new ToolStripMenuItem();
            footer = new Label();
            titulo = new Label();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Items.AddRange(new ToolStripItem[] { registrarCategoriaVehiculoToolStripMenuItem, registrarVehículoToolStripMenuItem, registrarVendedorToolStripMenuItem, registrarSucursalToolStripMenuItem, registrarClienteToolStripMenuItem, consultarInformaciónToolStripMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Padding = new Padding(7, 2, 0, 2);
            menuPrincipal.Size = new Size(933, 24);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuStrip1";
            // 
            // registrarCategoriaVehiculoToolStripMenuItem
            // 
            registrarCategoriaVehiculoToolStripMenuItem.Name = "registrarCategoriaVehiculoToolStripMenuItem";
            registrarCategoriaVehiculoToolStripMenuItem.Size = new Size(183, 20);
            registrarCategoriaVehiculoToolStripMenuItem.Text = "Registrar Categoría de Vehículo";
            registrarCategoriaVehiculoToolStripMenuItem.Click += registrarCategoriaVehiculoToolStripMenuItem_Click;
            // 
            // registrarVehículoToolStripMenuItem
            // 
            registrarVehículoToolStripMenuItem.Name = "registrarVehículoToolStripMenuItem";
            registrarVehículoToolStripMenuItem.Size = new Size(113, 20);
            registrarVehículoToolStripMenuItem.Text = "Registrar Vehículo";
            // 
            // registrarVendedorToolStripMenuItem
            // 
            registrarVendedorToolStripMenuItem.Name = "registrarVendedorToolStripMenuItem";
            registrarVendedorToolStripMenuItem.Size = new Size(118, 20);
            registrarVendedorToolStripMenuItem.Text = "Registrar Vendedor";
            // 
            // registrarSucursalToolStripMenuItem
            // 
            registrarSucursalToolStripMenuItem.Name = "registrarSucursalToolStripMenuItem";
            registrarSucursalToolStripMenuItem.Size = new Size(112, 20);
            registrarSucursalToolStripMenuItem.Text = "Registrar Sucursal";
            registrarSucursalToolStripMenuItem.Click += registrarSucursalToolStripMenuItem_Click;
            // 
            // registrarClienteToolStripMenuItem
            // 
            registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            registrarClienteToolStripMenuItem.Size = new Size(105, 20);
            registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            registrarClienteToolStripMenuItem.Click += registrarClienteToolStripMenuItem_Click;
            // 
            // consultarInformaciónToolStripMenuItem
            // 
            consultarInformaciónToolStripMenuItem.Name = "consultarInformaciónToolStripMenuItem";
            consultarInformaciónToolStripMenuItem.Size = new Size(138, 20);
            consultarInformaciónToolStripMenuItem.Text = "Consultar Información";
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.Location = new Point(307, 492);
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
            titulo.Location = new Point(340, 242);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(209, 42);
            titulo.TabIndex = 2;
            titulo.Text = "AutoMarket";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(titulo);
            Controls.Add(footer);
            Controls.Add(menuPrincipal);
            MainMenuStrip = menuPrincipal;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMenuPrincipal";
            Text = "AutoMarket - Inicio";
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem registrarCategoriaVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVehículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarInformaciónToolStripMenuItem;
        private System.Windows.Forms.Label footer;
        private System.Windows.Forms.Label titulo;
    }
}

