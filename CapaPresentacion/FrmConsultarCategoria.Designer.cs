namespace CapaPresentacion
{
    partial class FrmConsultarCategoria
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
            components = new System.ComponentModel.Container();
            titulo = new Label();
            dgvConsulta = new DataGridView();
            categoriaVehiculoBLBindingSource = new BindingSource(components);
            footer = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaVehiculoBLBindingSource).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(94, 18);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(359, 29);
            titulo.TabIndex = 1;
            titulo.Text = "Consultar Categoría de Vehículo";
            // 
            // dgvConsulta
            // 
            dgvConsulta.AllowUserToAddRows = false;
            dgvConsulta.AllowUserToDeleteRows = false;
            dgvConsulta.AllowUserToOrderColumns = true;
            dgvConsulta.AutoGenerateColumns = false;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.DataSource = categoriaVehiculoBLBindingSource;
            dgvConsulta.Location = new Point(12, 68);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.ReadOnly = true;
            dgvConsulta.Size = new Size(521, 337);
            dgvConsulta.TabIndex = 2;
            // 
            // categoriaVehiculoBLBindingSource
            // 
            categoriaVehiculoBLBindingSource.DataSource = typeof(CapaLogicaNegocio.CategoriaVehiculoLN);
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.ImageAlign = ContentAlignment.BottomCenter;
            footer.Location = new Point(142, 426);
            footer.Margin = new Padding(4, 0, 4, 0);
            footer.Name = "footer";
            footer.Size = new Size(273, 15);
            footer.TabIndex = 3;
            footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            footer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // FrmConsultarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 450);
            Controls.Add(footer);
            Controls.Add(dgvConsulta);
            Controls.Add(titulo);
            Name = "FrmConsultarCategoria";
            Text = "AutoMarket - Consultar Categoría de Vehículo";
            Load += FrmConsultarCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaVehiculoBLBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private DataGridView dgvConsulta;
        private BindingSource categoriaVehiculoBLBindingSource;
        private Label footer;
    }
}