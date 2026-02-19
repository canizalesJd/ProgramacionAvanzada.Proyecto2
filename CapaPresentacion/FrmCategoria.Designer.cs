namespace CapaPresentacion
{
    partial class FrmCategoria
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
            footer = new Label();
            idCategoria = new TextBox();
            idCategoriaLbl = new Label();
            nombreLbl = new Label();
            nombreCategoria = new TextBox();
            descripcionLbl = new Label();
            descripcionCategoria = new TextBox();
            botonGuardar = new Button();
            botonCancelar = new Button();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(23, 24);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(355, 29);
            titulo.TabIndex = 0;
            titulo.Text = "Registrar Categoría de Vehículo";
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.ImageAlign = ContentAlignment.BottomCenter;
            footer.Location = new Point(74, 413);
            footer.Margin = new Padding(4, 0, 4, 0);
            footer.Name = "footer";
            footer.Size = new Size(273, 15);
            footer.TabIndex = 2;
            footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            footer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // idCategoria
            // 
            idCategoria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idCategoria.BorderStyle = BorderStyle.FixedSingle;
            idCategoria.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idCategoria.Location = new Point(22, 98);
            idCategoria.Margin = new Padding(4, 3, 4, 3);
            idCategoria.Name = "idCategoria";
            idCategoria.Size = new Size(359, 26);
            idCategoria.TabIndex = 3;
            idCategoria.Tag = "";
            // 
            // idCategoriaLbl
            // 
            idCategoriaLbl.Anchor = AnchorStyles.Left;
            idCategoriaLbl.AutoSize = true;
            idCategoriaLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idCategoriaLbl.ImageAlign = ContentAlignment.BottomCenter;
            idCategoriaLbl.Location = new Point(19, 77);
            idCategoriaLbl.Margin = new Padding(4, 0, 4, 0);
            idCategoriaLbl.Name = "idCategoriaLbl";
            idCategoriaLbl.Size = new Size(25, 15);
            idCategoriaLbl.TabIndex = 4;
            idCategoriaLbl.Text = "ID  ";
            idCategoriaLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nombreLbl
            // 
            nombreLbl.Anchor = AnchorStyles.Left;
            nombreLbl.AutoSize = true;
            nombreLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreLbl.ImageAlign = ContentAlignment.BottomCenter;
            nombreLbl.Location = new Point(21, 169);
            nombreLbl.Margin = new Padding(4, 0, 4, 0);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(52, 15);
            nombreLbl.TabIndex = 6;
            nombreLbl.Text = "Nombre";
            nombreLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nombreCategoria
            // 
            nombreCategoria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nombreCategoria.BorderStyle = BorderStyle.FixedSingle;
            nombreCategoria.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreCategoria.Location = new Point(24, 189);
            nombreCategoria.Margin = new Padding(4, 3, 4, 3);
            nombreCategoria.Name = "nombreCategoria";
            nombreCategoria.Size = new Size(355, 26);
            nombreCategoria.TabIndex = 5;
            nombreCategoria.Tag = "";
            // 
            // descripcionLbl
            // 
            descripcionLbl.Anchor = AnchorStyles.Left;
            descripcionLbl.AutoSize = true;
            descripcionLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descripcionLbl.ImageAlign = ContentAlignment.BottomCenter;
            descripcionLbl.Location = new Point(21, 250);
            descripcionLbl.Margin = new Padding(4, 0, 4, 0);
            descripcionLbl.Name = "descripcionLbl";
            descripcionLbl.Size = new Size(72, 15);
            descripcionLbl.TabIndex = 8;
            descripcionLbl.Text = "Descripción";
            descripcionLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // descripcionCategoria
            // 
            descripcionCategoria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descripcionCategoria.BorderStyle = BorderStyle.FixedSingle;
            descripcionCategoria.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descripcionCategoria.Location = new Point(24, 271);
            descripcionCategoria.Margin = new Padding(4, 3, 4, 3);
            descripcionCategoria.Name = "descripcionCategoria";
            descripcionCategoria.Size = new Size(356, 26);
            descripcionCategoria.TabIndex = 7;
            descripcionCategoria.Tag = "";
            // 
            // botonGuardar
            // 
            botonGuardar.Anchor = AnchorStyles.Right;
            botonGuardar.BackColor = SystemColors.ActiveCaption;
            botonGuardar.Location = new Point(163, 321);
            botonGuardar.Margin = new Padding(4, 3, 4, 3);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(219, 47);
            botonGuardar.TabIndex = 9;
            botonGuardar.Text = "Registrar";
            botonGuardar.UseVisualStyleBackColor = false;
            botonGuardar.Click += botonGuardar_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.Anchor = AnchorStyles.Right;
            botonCancelar.BackColor = Color.IndianRed;
            botonCancelar.Location = new Point(24, 321);
            botonCancelar.Margin = new Padding(4, 3, 4, 3);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(131, 47);
            botonCancelar.TabIndex = 10;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = false;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 441);
            Controls.Add(botonCancelar);
            Controls.Add(botonGuardar);
            Controls.Add(descripcionLbl);
            Controls.Add(descripcionCategoria);
            Controls.Add(nombreLbl);
            Controls.Add(nombreCategoria);
            Controls.Add(idCategoriaLbl);
            Controls.Add(idCategoria);
            Controls.Add(footer);
            Controls.Add(titulo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCategoria";
            Text = "AutoMarket - Registrar Categoría de Vehículo";
            ResumeLayout(false);
            PerformLayout();

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
        private Button botonCancelar;
    }
}