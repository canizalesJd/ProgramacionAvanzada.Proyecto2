namespace CapaPresentacion
{
    partial class FrmRegistrarCategoriaVehiculo
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
            this.titulo = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Label();
            this.idCategoria = new System.Windows.Forms.TextBox();
            this.idCategoriaLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.nombreCategoria = new System.Windows.Forms.TextBox();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.descripcionCategoria = new System.Windows.Forms.TextBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(44, 22);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(355, 29);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Registrar Categoría de Vehículo";
            // 
            // footer
            // 
            this.footer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.footer.AutoSize = true;
            this.footer.Cursor = System.Windows.Forms.Cursors.Default;
            this.footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.footer.Location = new System.Drawing.Point(100, 346);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(273, 15);
            this.footer.TabIndex = 2;
            this.footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            this.footer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // idCategoria
            // 
            this.idCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCategoria.Location = new System.Drawing.Point(19, 79);
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.Size = new System.Drawing.Size(400, 26);
            this.idCategoria.TabIndex = 3;
            this.idCategoria.Tag = "";
            this.idCategoria.TextChanged += new System.EventHandler(this.idCategoria_TextChanged);
            // 
            // idCategoriaLbl
            // 
            this.idCategoriaLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.idCategoriaLbl.AutoSize = true;
            this.idCategoriaLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.idCategoriaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCategoriaLbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.idCategoriaLbl.Location = new System.Drawing.Point(16, 61);
            this.idCategoriaLbl.Name = "idCategoriaLbl";
            this.idCategoriaLbl.Size = new System.Drawing.Size(25, 15);
            this.idCategoriaLbl.TabIndex = 4;
            this.idCategoriaLbl.Text = "ID  ";
            this.idCategoriaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nombreLbl
            // 
            this.nombreLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nombreLbl.Location = new System.Drawing.Point(18, 140);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(52, 15);
            this.nombreLbl.TabIndex = 6;
            this.nombreLbl.Text = "Nombre";
            this.nombreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCategoria.Location = new System.Drawing.Point(21, 158);
            this.nombreCategoria.Name = "nombreCategoria";
            this.nombreCategoria.Size = new System.Drawing.Size(396, 26);
            this.nombreCategoria.TabIndex = 5;
            this.nombreCategoria.Tag = "";
            this.nombreCategoria.TextChanged += new System.EventHandler(this.nombreCategoria_TextChanged);
            // 
            // descripcionLbl
            // 
            this.descripcionLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descripcionLbl.AutoSize = true;
            this.descripcionLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.descripcionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.descripcionLbl.Location = new System.Drawing.Point(18, 211);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(72, 15);
            this.descripcionLbl.TabIndex = 8;
            this.descripcionLbl.Text = "Descripción";
            this.descripcionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descripcionCategoria
            // 
            this.descripcionCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionCategoria.Location = new System.Drawing.Point(21, 229);
            this.descripcionCategoria.Name = "descripcionCategoria";
            this.descripcionCategoria.Size = new System.Drawing.Size(397, 26);
            this.descripcionCategoria.TabIndex = 7;
            this.descripcionCategoria.Tag = "";
            this.descripcionCategoria.TextChanged += new System.EventHandler(this.descripcionCategoria_TextChanged);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.botonGuardar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.botonGuardar.Location = new System.Drawing.Point(283, 281);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(136, 41);
            this.botonGuardar.TabIndex = 9;
            this.botonGuardar.Text = "Registrar";
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // FrmRegistrarCategoriaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 370);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.descripcionLbl);
            this.Controls.Add(this.descripcionCategoria);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.nombreCategoria);
            this.Controls.Add(this.idCategoriaLbl);
            this.Controls.Add(this.idCategoria);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.titulo);
            this.Name = "FrmRegistrarCategoriaVehiculo";
            this.Text = "AutoMarket - Registrar Categoría de Vehículo";
            this.Load += new System.EventHandler(this.FrmRegistrarCategoriaVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label footer;
        private System.Windows.Forms.TextBox idCategoria;
        private System.Windows.Forms.Label idCategoriaLbl;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.TextBox nombreCategoria;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.TextBox descripcionCategoria;
        private System.Windows.Forms.Button botonGuardar;
    }
}