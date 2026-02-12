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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.registrarCategoriaVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.footer = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCategoriaVehiculoToolStripMenuItem,
            this.registrarVehículoToolStripMenuItem,
            this.registrarVendedorToolStripMenuItem,
            this.registrarSucursalToolStripMenuItem,
            this.registrarClienteToolStripMenuItem,
            this.consultarInformaciónToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // registrarCategoriaVehiculoToolStripMenuItem
            // 
            this.registrarCategoriaVehiculoToolStripMenuItem.Name = "registrarCategoriaVehiculoToolStripMenuItem";
            this.registrarCategoriaVehiculoToolStripMenuItem.Size = new System.Drawing.Size(183, 20);
            this.registrarCategoriaVehiculoToolStripMenuItem.Text = "Registrar Categoría de Vehículo";
            this.registrarCategoriaVehiculoToolStripMenuItem.Click += new System.EventHandler(this.registrarCategoriaVehiculoToolStripMenuItem_Click);
            // 
            // registrarVehículoToolStripMenuItem
            // 
            this.registrarVehículoToolStripMenuItem.Name = "registrarVehículoToolStripMenuItem";
            this.registrarVehículoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.registrarVehículoToolStripMenuItem.Text = "Registrar Vehículo";
            // 
            // registrarVendedorToolStripMenuItem
            // 
            this.registrarVendedorToolStripMenuItem.Name = "registrarVendedorToolStripMenuItem";
            this.registrarVendedorToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.registrarVendedorToolStripMenuItem.Text = "Registrar Vendedor";
            // 
            // registrarSucursalToolStripMenuItem
            // 
            this.registrarSucursalToolStripMenuItem.Name = "registrarSucursalToolStripMenuItem";
            this.registrarSucursalToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.registrarSucursalToolStripMenuItem.Text = "Registrar Sucursal";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            // 
            // consultarInformaciónToolStripMenuItem
            // 
            this.consultarInformaciónToolStripMenuItem.Name = "consultarInformaciónToolStripMenuItem";
            this.consultarInformaciónToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.consultarInformaciónToolStripMenuItem.Text = "Consultar Información";
            // 
            // footer
            // 
            this.footer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.footer.AutoSize = true;
            this.footer.Cursor = System.Windows.Forms.Cursors.Default;
            this.footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer.Location = new System.Drawing.Point(263, 426);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(273, 15);
            this.footer.TabIndex = 1;
            this.footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            this.footer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titulo.AutoSize = true;
            this.titulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(291, 210);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(209, 42);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "AutoMarket";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmMenuPrincipal";
            this.Text = "AutoMarket - Inicio";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

