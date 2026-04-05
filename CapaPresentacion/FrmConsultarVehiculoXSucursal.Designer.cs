namespace CapaPresentacion
{
    partial class FrmConsultarVehiculoXSucursal
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
            titulo = new Label();
            botonActualizar = new Button();
            footer = new Label();
            dgvConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(12, 12);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(355, 29);
            titulo.TabIndex = 4;
            titulo.Text = "Consultar Vehículo por Sucursal";
            // 
            // botonActualizar
            // 
            botonActualizar.AutoSize = true;
            botonActualizar.BackColor = SystemColors.Info;
            botonActualizar.Location = new Point(839, 12);
            botonActualizar.Margin = new Padding(4, 3, 4, 3);
            botonActualizar.Name = "botonActualizar";
            botonActualizar.Size = new Size(128, 37);
            botonActualizar.TabIndex = 18;
            botonActualizar.Text = "Actualizar";
            botonActualizar.UseVisualStyleBackColor = false;
            botonActualizar.Click += BotonActualizar_Click;
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.ImageAlign = ContentAlignment.BottomCenter;
            footer.Location = new Point(336, 447);
            footer.Margin = new Padding(4, 0, 4, 0);
            footer.Name = "footer";
            footer.Size = new Size(273, 15);
            footer.TabIndex = 19;
            footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            footer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // dgvConsulta
            // 
            dgvConsulta.AllowUserToAddRows = false;
            dgvConsulta.AllowUserToDeleteRows = false;
            dgvConsulta.AllowUserToOrderColumns = true;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(12, 60);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.ReadOnly = true;
            dgvConsulta.Size = new Size(956, 368);
            dgvConsulta.TabIndex = 20;
            // 
            // FrmConsultarVehiculoXSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 471);
            Controls.Add(dgvConsulta);
            Controls.Add(footer);
            Controls.Add(botonActualizar);
            Controls.Add(titulo);
            Name = "FrmConsultarVehiculoXSucursal";
            Text = "AutoMarket - Consultar Vehículo por Sucursal";
            Load += FrmConsultarVehiculoXSucursal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Button botonActualizar;
        private Label footer;
        private DataGridView dgvConsulta;
    }
}