namespace CapaPresentacion
{
    partial class FrmVehiculo
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
            idLbl = new Label();
            idVehiculo = new TextBox();
            marcaLbl = new Label();
            marcaVehiculo = new TextBox();
            modeloLbl = new Label();
            modeloVehiculo = new TextBox();
            anioLbl = new Label();
            anioVehiculo = new TextBox();
            precioLbl = new Label();
            precioVehiculo = new TextBox();
            categoriaLbl = new Label();
            comboCategoriaVehiculo = new ComboBox();
            comboEstadoVehiculo = new ComboBox();
            estadoLbl = new Label();
            botonGuardar = new Button();
            footer = new Label();
            botonCancelar = new Button();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(187, 9);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(210, 29);
            titulo.TabIndex = 10;
            titulo.Text = "Registrar Vehículo";
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLbl.ImageAlign = ContentAlignment.BottomCenter;
            idLbl.Location = new Point(10, 60);
            idLbl.Margin = new Padding(4, 0, 4, 0);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(25, 15);
            idLbl.TabIndex = 12;
            idLbl.Text = "ID  ";
            idLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idVehiculo
            // 
            idVehiculo.BorderStyle = BorderStyle.FixedSingle;
            idVehiculo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idVehiculo.Location = new Point(13, 83);
            idVehiculo.Margin = new Padding(4, 3, 4, 3);
            idVehiculo.Name = "idVehiculo";
            idVehiculo.Size = new Size(181, 26);
            idVehiculo.TabIndex = 11;
            idVehiculo.Tag = "";
            // 
            // marcaLbl
            // 
            marcaLbl.AutoSize = true;
            marcaLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            marcaLbl.ImageAlign = ContentAlignment.BottomCenter;
            marcaLbl.Location = new Point(199, 60);
            marcaLbl.Margin = new Padding(4, 0, 4, 0);
            marcaLbl.Name = "marcaLbl";
            marcaLbl.Size = new Size(42, 15);
            marcaLbl.TabIndex = 14;
            marcaLbl.Text = "Marca";
            marcaLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // marcaVehiculo
            // 
            marcaVehiculo.BorderStyle = BorderStyle.FixedSingle;
            marcaVehiculo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            marcaVehiculo.Location = new Point(202, 83);
            marcaVehiculo.Margin = new Padding(4, 3, 4, 3);
            marcaVehiculo.Name = "marcaVehiculo";
            marcaVehiculo.Size = new Size(163, 26);
            marcaVehiculo.TabIndex = 13;
            marcaVehiculo.Tag = "";
            // 
            // modeloLbl
            // 
            modeloLbl.AutoSize = true;
            modeloLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modeloLbl.ImageAlign = ContentAlignment.BottomCenter;
            modeloLbl.Location = new Point(370, 60);
            modeloLbl.Margin = new Padding(4, 0, 4, 0);
            modeloLbl.Name = "modeloLbl";
            modeloLbl.Size = new Size(49, 15);
            modeloLbl.TabIndex = 16;
            modeloLbl.Text = "Modelo";
            modeloLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // modeloVehiculo
            // 
            modeloVehiculo.BorderStyle = BorderStyle.FixedSingle;
            modeloVehiculo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modeloVehiculo.Location = new Point(373, 83);
            modeloVehiculo.Margin = new Padding(4, 3, 4, 3);
            modeloVehiculo.Name = "modeloVehiculo";
            modeloVehiculo.Size = new Size(179, 26);
            modeloVehiculo.TabIndex = 15;
            modeloVehiculo.Tag = "";
            // 
            // anioLbl
            // 
            anioLbl.AutoSize = true;
            anioLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            anioLbl.ImageAlign = ContentAlignment.BottomCenter;
            anioLbl.Location = new Point(12, 126);
            anioLbl.Margin = new Padding(4, 0, 4, 0);
            anioLbl.Name = "anioLbl";
            anioLbl.Size = new Size(28, 15);
            anioLbl.TabIndex = 18;
            anioLbl.Text = "Año";
            anioLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // anioVehiculo
            // 
            anioVehiculo.BorderStyle = BorderStyle.FixedSingle;
            anioVehiculo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            anioVehiculo.Location = new Point(15, 149);
            anioVehiculo.Margin = new Padding(4, 3, 4, 3);
            anioVehiculo.Name = "anioVehiculo";
            anioVehiculo.Size = new Size(179, 26);
            anioVehiculo.TabIndex = 17;
            anioVehiculo.Tag = "";
            // 
            // precioLbl
            // 
            precioLbl.AutoSize = true;
            precioLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precioLbl.ImageAlign = ContentAlignment.BottomCenter;
            precioLbl.Location = new Point(199, 126);
            precioLbl.Margin = new Padding(4, 0, 4, 0);
            precioLbl.Name = "precioLbl";
            precioLbl.Size = new Size(42, 15);
            precioLbl.TabIndex = 20;
            precioLbl.Text = "Precio";
            precioLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // precioVehiculo
            // 
            precioVehiculo.BorderStyle = BorderStyle.FixedSingle;
            precioVehiculo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precioVehiculo.Location = new Point(202, 149);
            precioVehiculo.Margin = new Padding(4, 3, 4, 3);
            precioVehiculo.Name = "precioVehiculo";
            precioVehiculo.Size = new Size(163, 26);
            precioVehiculo.TabIndex = 19;
            precioVehiculo.Tag = "";
            // 
            // categoriaLbl
            // 
            categoriaLbl.AutoSize = true;
            categoriaLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoriaLbl.ImageAlign = ContentAlignment.BottomCenter;
            categoriaLbl.Location = new Point(370, 126);
            categoriaLbl.Margin = new Padding(4, 0, 4, 0);
            categoriaLbl.Name = "categoriaLbl";
            categoriaLbl.Size = new Size(60, 15);
            categoriaLbl.TabIndex = 22;
            categoriaLbl.Text = "Categoría";
            categoriaLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboCategoriaVehiculo
            // 
            comboCategoriaVehiculo.FormattingEnabled = true;
            comboCategoriaVehiculo.Location = new Point(373, 150);
            comboCategoriaVehiculo.Name = "comboCategoriaVehiculo";
            comboCategoriaVehiculo.Size = new Size(179, 23);
            comboCategoriaVehiculo.TabIndex = 23;
            // 
            // comboEstadoVehiculo
            // 
            comboEstadoVehiculo.FormattingEnabled = true;
            comboEstadoVehiculo.Location = new Point(17, 216);
            comboEstadoVehiculo.Name = "comboEstadoVehiculo";
            comboEstadoVehiculo.Size = new Size(179, 23);
            comboEstadoVehiculo.TabIndex = 25;
            // 
            // estadoLbl
            // 
            estadoLbl.AutoSize = true;
            estadoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            estadoLbl.ImageAlign = ContentAlignment.BottomCenter;
            estadoLbl.Location = new Point(14, 192);
            estadoLbl.Margin = new Padding(4, 0, 4, 0);
            estadoLbl.Name = "estadoLbl";
            estadoLbl.Size = new Size(45, 15);
            estadoLbl.TabIndex = 24;
            estadoLbl.Text = "Estado";
            estadoLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonGuardar
            // 
            botonGuardar.AutoSize = true;
            botonGuardar.BackColor = SystemColors.ActiveCaption;
            botonGuardar.Location = new Point(370, 268);
            botonGuardar.Margin = new Padding(4, 3, 4, 3);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(182, 47);
            botonGuardar.TabIndex = 26;
            botonGuardar.Text = "Registrar";
            botonGuardar.UseVisualStyleBackColor = false;
            botonGuardar.Click += BotonGuardar_Click;
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.Location = new Point(160, 335);
            footer.Margin = new Padding(4, 0, 4, 0);
            footer.Name = "footer";
            footer.Size = new Size(273, 15);
            footer.TabIndex = 27;
            footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            footer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // botonCancelar
            // 
            botonCancelar.Anchor = AnchorStyles.Right;
            botonCancelar.BackColor = Color.IndianRed;
            botonCancelar.Location = new Point(17, 268);
            botonCancelar.Margin = new Padding(4, 3, 4, 3);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(131, 47);
            botonCancelar.TabIndex = 28;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = false;
            botonCancelar.Click += BotonCancelar_Click;
            // 
            // FrmVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 359);
            Controls.Add(botonCancelar);
            Controls.Add(footer);
            Controls.Add(botonGuardar);
            Controls.Add(comboEstadoVehiculo);
            Controls.Add(estadoLbl);
            Controls.Add(comboCategoriaVehiculo);
            Controls.Add(categoriaLbl);
            Controls.Add(precioLbl);
            Controls.Add(precioVehiculo);
            Controls.Add(anioLbl);
            Controls.Add(anioVehiculo);
            Controls.Add(modeloLbl);
            Controls.Add(modeloVehiculo);
            Controls.Add(marcaLbl);
            Controls.Add(marcaVehiculo);
            Controls.Add(idLbl);
            Controls.Add(idVehiculo);
            Controls.Add(titulo);
            Name = "FrmVehiculo";
            Text = "AutoMarket -  Registrar Vehículo";
            Load += FrmRegistrarVehiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label idLbl;
        private TextBox idVehiculo;
        private Label marcaLbl;
        private TextBox marcaVehiculo;
        private Label modeloLbl;
        private TextBox modeloVehiculo;
        private Label anioLbl;
        private TextBox anioVehiculo;
        private Label precioLbl;
        private TextBox precioVehiculo;
        private Label categoriaLbl;
        private ComboBox comboCategoriaVehiculo;
        private ComboBox comboEstadoVehiculo;
        private Label estadoLbl;
        private Button botonGuardar;
        private Label footer;
        private Button botonCancelar;
    }
}