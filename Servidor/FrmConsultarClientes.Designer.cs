namespace CapaPresentacion
{
    partial class FrmConsultarClientes
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
            dgvConsulta = new DataGridView();
            footer = new Label();
            botonActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(13, 17);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(197, 29);
            titulo.TabIndex = 2;
            titulo.Text = "Consultar Cliente";
            // 
            // dgvConsulta
            // 
            dgvConsulta.AllowUserToAddRows = false;
            dgvConsulta.AllowUserToDeleteRows = false;
            dgvConsulta.AllowUserToOrderColumns = true;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(12, 62);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.ReadOnly = true;
            dgvConsulta.Size = new Size(748, 372);
            dgvConsulta.TabIndex = 3;
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.ImageAlign = ContentAlignment.BottomCenter;
            footer.Location = new Point(255, 451);
            footer.Margin = new Padding(4, 0, 4, 0);
            footer.Name = "footer";
            footer.Size = new Size(273, 15);
            footer.TabIndex = 4;
            footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            footer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // botonActualizar
            // 
            botonActualizar.AutoSize = true;
            botonActualizar.BackColor = SystemColors.Info;
            botonActualizar.Location = new Point(618, 12);
            botonActualizar.Margin = new Padding(4, 3, 4, 3);
            botonActualizar.Name = "botonActualizar";
            botonActualizar.Size = new Size(141, 37);
            botonActualizar.TabIndex = 17;
            botonActualizar.Text = "Actualizar";
            botonActualizar.UseVisualStyleBackColor = false;
            botonActualizar.Click += BotonActualizar_Click;
            // 
            // FrmConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 475);
            Controls.Add(botonActualizar);
            Controls.Add(footer);
            Controls.Add(dgvConsulta);
            Controls.Add(titulo);
            Name = "FrmConsultarClientes";
            Text = "AutoMarket - Consultar Cliente";
            Load += FrmConsultarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private DataGridView dgvConsulta;
        private Label footer;
        private Button botonActualizar;
    }
}