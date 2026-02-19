namespace CapaPresentacion
{
    partial class FrmVendedor
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
            idVendedor = new TextBox();
            identificacionLbl = new Label();
            identificacionVendedor = new TextBox();
            nombreLbl = new Label();
            nombreCompletoVendedor = new TextBox();
            telefonoLbl = new Label();
            telefonoVendedor = new TextBox();
            fechaNacimientoVendedor = new DateTimePicker();
            fechaNacimientoLbl = new Label();
            fechaIngresoVendedor = new DateTimePicker();
            fechaIngresoLbl = new Label();
            botonGuardar = new Button();
            footer = new Label();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(123, 21);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(223, 29);
            titulo.TabIndex = 10;
            titulo.Text = "Registrar Vendedor";
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLbl.ImageAlign = ContentAlignment.BottomCenter;
            idLbl.Location = new Point(13, 64);
            idLbl.Margin = new Padding(4, 0, 4, 0);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(25, 15);
            idLbl.TabIndex = 12;
            idLbl.Text = "ID  ";
            idLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idVendedor
            // 
            idVendedor.BorderStyle = BorderStyle.FixedSingle;
            idVendedor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idVendedor.Location = new Point(16, 87);
            idVendedor.Margin = new Padding(4, 3, 4, 3);
            idVendedor.Name = "idVendedor";
            idVendedor.Size = new Size(203, 26);
            idVendedor.TabIndex = 11;
            idVendedor.Tag = "";
            // 
            // identificacionLbl
            // 
            identificacionLbl.AutoSize = true;
            identificacionLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            identificacionLbl.ImageAlign = ContentAlignment.BottomCenter;
            identificacionLbl.Location = new Point(227, 64);
            identificacionLbl.Margin = new Padding(4, 0, 4, 0);
            identificacionLbl.Name = "identificacionLbl";
            identificacionLbl.Size = new Size(79, 15);
            identificacionLbl.TabIndex = 14;
            identificacionLbl.Text = "Identificación";
            identificacionLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // identificacionVendedor
            // 
            identificacionVendedor.BorderStyle = BorderStyle.FixedSingle;
            identificacionVendedor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            identificacionVendedor.Location = new Point(230, 87);
            identificacionVendedor.Margin = new Padding(4, 3, 4, 3);
            identificacionVendedor.Name = "identificacionVendedor";
            identificacionVendedor.Size = new Size(203, 26);
            identificacionVendedor.TabIndex = 13;
            identificacionVendedor.Tag = "";
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreLbl.ImageAlign = ContentAlignment.BottomCenter;
            nombreLbl.Location = new Point(13, 128);
            nombreLbl.Margin = new Padding(4, 0, 4, 0);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(108, 15);
            nombreLbl.TabIndex = 16;
            nombreLbl.Text = "Nombre Completo";
            nombreLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nombreCompletoVendedor
            // 
            nombreCompletoVendedor.BorderStyle = BorderStyle.FixedSingle;
            nombreCompletoVendedor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreCompletoVendedor.Location = new Point(16, 151);
            nombreCompletoVendedor.Margin = new Padding(4, 3, 4, 3);
            nombreCompletoVendedor.Name = "nombreCompletoVendedor";
            nombreCompletoVendedor.Size = new Size(203, 26);
            nombreCompletoVendedor.TabIndex = 15;
            nombreCompletoVendedor.Tag = "";
            // 
            // telefonoLbl
            // 
            telefonoLbl.AutoSize = true;
            telefonoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoLbl.ImageAlign = ContentAlignment.BottomCenter;
            telefonoLbl.Location = new Point(230, 128);
            telefonoLbl.Margin = new Padding(4, 0, 4, 0);
            telefonoLbl.Name = "telefonoLbl";
            telefonoLbl.Size = new Size(55, 15);
            telefonoLbl.TabIndex = 18;
            telefonoLbl.Text = "Teléfono";
            telefonoLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // telefonoVendedor
            // 
            telefonoVendedor.BorderStyle = BorderStyle.FixedSingle;
            telefonoVendedor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoVendedor.Location = new Point(233, 151);
            telefonoVendedor.Margin = new Padding(4, 3, 4, 3);
            telefonoVendedor.Name = "telefonoVendedor";
            telefonoVendedor.Size = new Size(203, 26);
            telefonoVendedor.TabIndex = 17;
            telefonoVendedor.Tag = "";
            // 
            // fechaNacimientoVendedor
            // 
            fechaNacimientoVendedor.CustomFormat = "dd/MM/yyyy";
            fechaNacimientoVendedor.Format = DateTimePickerFormat.Custom;
            fechaNacimientoVendedor.Location = new Point(16, 220);
            fechaNacimientoVendedor.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            fechaNacimientoVendedor.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            fechaNacimientoVendedor.Name = "fechaNacimientoVendedor";
            fechaNacimientoVendedor.Size = new Size(203, 23);
            fechaNacimientoVendedor.TabIndex = 20;
            // 
            // fechaNacimientoLbl
            // 
            fechaNacimientoLbl.AutoSize = true;
            fechaNacimientoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaNacimientoLbl.ImageAlign = ContentAlignment.BottomCenter;
            fechaNacimientoLbl.Location = new Point(15, 196);
            fechaNacimientoLbl.Margin = new Padding(4, 0, 4, 0);
            fechaNacimientoLbl.Name = "fechaNacimientoLbl";
            fechaNacimientoLbl.Size = new Size(107, 15);
            fechaNacimientoLbl.TabIndex = 19;
            fechaNacimientoLbl.Text = "Fecha Nacimiento";
            fechaNacimientoLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fechaIngresoVendedor
            // 
            fechaIngresoVendedor.CustomFormat = "dd/MM/yyyy";
            fechaIngresoVendedor.Format = DateTimePickerFormat.Custom;
            fechaIngresoVendedor.Location = new Point(233, 220);
            fechaIngresoVendedor.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            fechaIngresoVendedor.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            fechaIngresoVendedor.Name = "fechaIngresoVendedor";
            fechaIngresoVendedor.Size = new Size(204, 23);
            fechaIngresoVendedor.TabIndex = 22;
            // 
            // fechaIngresoLbl
            // 
            fechaIngresoLbl.AutoSize = true;
            fechaIngresoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaIngresoLbl.ImageAlign = ContentAlignment.BottomCenter;
            fechaIngresoLbl.Location = new Point(233, 196);
            fechaIngresoLbl.Margin = new Padding(4, 0, 4, 0);
            fechaIngresoLbl.Name = "fechaIngresoLbl";
            fechaIngresoLbl.Size = new Size(85, 15);
            fechaIngresoLbl.TabIndex = 21;
            fechaIngresoLbl.Text = "Fecha Ingreso";
            fechaIngresoLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonGuardar
            // 
            botonGuardar.AutoSize = true;
            botonGuardar.BackColor = SystemColors.ButtonShadow;
            botonGuardar.Location = new Point(278, 277);
            botonGuardar.Margin = new Padding(4, 3, 4, 3);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(159, 47);
            botonGuardar.TabIndex = 23;
            botonGuardar.Text = "Registrar";
            botonGuardar.UseVisualStyleBackColor = false;
            botonGuardar.Click += botonGuardar_Click;
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.Location = new Point(98, 353);
            footer.Margin = new Padding(4, 0, 4, 0);
            footer.Name = "footer";
            footer.Size = new Size(273, 15);
            footer.TabIndex = 24;
            footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            footer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // FrmRegistrarVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 377);
            Controls.Add(footer);
            Controls.Add(botonGuardar);
            Controls.Add(fechaIngresoVendedor);
            Controls.Add(fechaIngresoLbl);
            Controls.Add(fechaNacimientoVendedor);
            Controls.Add(fechaNacimientoLbl);
            Controls.Add(telefonoLbl);
            Controls.Add(telefonoVendedor);
            Controls.Add(nombreLbl);
            Controls.Add(nombreCompletoVendedor);
            Controls.Add(identificacionLbl);
            Controls.Add(identificacionVendedor);
            Controls.Add(idLbl);
            Controls.Add(idVendedor);
            Controls.Add(titulo);
            Name = "FrmRegistrarVendedor";
            Text = "AutoMarket  - Registrar Vendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label idLbl;
        private TextBox idVendedor;
        private Label identificacionLbl;
        private TextBox identificacionVendedor;
        private Label nombreLbl;
        private TextBox nombreCompletoVendedor;
        private Label telefonoLbl;
        private TextBox telefonoVendedor;
        private DateTimePicker fechaNacimientoVendedor;
        private Label fechaNacimientoLbl;
        private DateTimePicker fechaIngresoVendedor;
        private Label fechaIngresoLbl;
        private Button botonGuardar;
        private Label footer;
    }
}