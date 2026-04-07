namespace CapaPresentacion
{
    partial class FrmCliente
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
            idCliente = new TextBox();
            identificacionClienteLbl = new Label();
            identificacionCliente = new TextBox();
            nombreCompletoLbl = new Label();
            nombreCompleto = new TextBox();
            fechaNacimientoLbl = new Label();
            fechaNacimiento = new DateTimePicker();
            fechaRegistro = new DateTimePicker();
            fechaRegistroLbl = new Label();
            botonGuardar = new Button();
            footer = new Label();
            clienteActivoLbL = new Label();
            clienteActivo = new CheckBox();
            botonCancelar = new Button();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(189, 21);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(193, 29);
            titulo.TabIndex = 1;
            titulo.Text = "Registrar Cliente";
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLbl.ImageAlign = ContentAlignment.BottomCenter;
            idLbl.Location = new Point(10, 67);
            idLbl.Margin = new Padding(4, 0, 4, 0);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(25, 15);
            idLbl.TabIndex = 6;
            idLbl.Text = "ID  ";
            idLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idCliente
            // 
            idCliente.BorderStyle = BorderStyle.FixedSingle;
            idCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idCliente.Location = new Point(13, 90);
            idCliente.Margin = new Padding(4, 3, 4, 3);
            idCliente.Name = "idCliente";
            idCliente.Size = new Size(146, 26);
            idCliente.TabIndex = 5;
            idCliente.Tag = "";
            // 
            // identificacionClienteLbl
            // 
            identificacionClienteLbl.AutoSize = true;
            identificacionClienteLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            identificacionClienteLbl.ImageAlign = ContentAlignment.BottomCenter;
            identificacionClienteLbl.Location = new Point(170, 67);
            identificacionClienteLbl.Margin = new Padding(4, 0, 4, 0);
            identificacionClienteLbl.Name = "identificacionClienteLbl";
            identificacionClienteLbl.Size = new Size(85, 15);
            identificacionClienteLbl.TabIndex = 8;
            identificacionClienteLbl.Text = "Identificación  ";
            identificacionClienteLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // identificacionCliente
            // 
            identificacionCliente.BorderStyle = BorderStyle.FixedSingle;
            identificacionCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            identificacionCliente.Location = new Point(173, 90);
            identificacionCliente.Margin = new Padding(4, 3, 4, 3);
            identificacionCliente.Name = "identificacionCliente";
            identificacionCliente.Size = new Size(177, 26);
            identificacionCliente.TabIndex = 7;
            identificacionCliente.Tag = "";
            // 
            // nombreCompletoLbl
            // 
            nombreCompletoLbl.AutoSize = true;
            nombreCompletoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreCompletoLbl.ImageAlign = ContentAlignment.BottomCenter;
            nombreCompletoLbl.Location = new Point(366, 67);
            nombreCompletoLbl.Margin = new Padding(4, 0, 4, 0);
            nombreCompletoLbl.Name = "nombreCompletoLbl";
            nombreCompletoLbl.Size = new Size(108, 15);
            nombreCompletoLbl.TabIndex = 10;
            nombreCompletoLbl.Text = "Nombre Completo";
            nombreCompletoLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nombreCompleto
            // 
            nombreCompleto.BorderStyle = BorderStyle.FixedSingle;
            nombreCompleto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreCompleto.Location = new Point(369, 90);
            nombreCompleto.Margin = new Padding(4, 3, 4, 3);
            nombreCompleto.Name = "nombreCompleto";
            nombreCompleto.Size = new Size(177, 26);
            nombreCompleto.TabIndex = 9;
            nombreCompleto.Tag = "";
            // 
            // fechaNacimientoLbl
            // 
            fechaNacimientoLbl.AutoSize = true;
            fechaNacimientoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaNacimientoLbl.ImageAlign = ContentAlignment.BottomCenter;
            fechaNacimientoLbl.Location = new Point(13, 145);
            fechaNacimientoLbl.Margin = new Padding(4, 0, 4, 0);
            fechaNacimientoLbl.Name = "fechaNacimientoLbl";
            fechaNacimientoLbl.Size = new Size(107, 15);
            fechaNacimientoLbl.TabIndex = 11;
            fechaNacimientoLbl.Text = "Fecha Nacimiento";
            fechaNacimientoLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.CustomFormat = "dd/MM/yyyy";
            fechaNacimiento.Format = DateTimePickerFormat.Custom;
            fechaNacimiento.Location = new Point(13, 169);
            fechaNacimiento.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            fechaNacimiento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.Size = new Size(253, 23);
            fechaNacimiento.TabIndex = 12;
            // 
            // fechaRegistro
            // 
            fechaRegistro.CustomFormat = "dd/MM/yyyy";
            fechaRegistro.Format = DateTimePickerFormat.Custom;
            fechaRegistro.Location = new Point(293, 169);
            fechaRegistro.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            fechaRegistro.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            fechaRegistro.Name = "fechaRegistro";
            fechaRegistro.Size = new Size(253, 23);
            fechaRegistro.TabIndex = 14;
            // 
            // fechaRegistroLbl
            // 
            fechaRegistroLbl.AutoSize = true;
            fechaRegistroLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaRegistroLbl.ImageAlign = ContentAlignment.BottomCenter;
            fechaRegistroLbl.Location = new Point(293, 145);
            fechaRegistroLbl.Margin = new Padding(4, 0, 4, 0);
            fechaRegistroLbl.Name = "fechaRegistroLbl";
            fechaRegistroLbl.Size = new Size(90, 15);
            fechaRegistroLbl.TabIndex = 13;
            fechaRegistroLbl.Text = "Fecha Registro";
            fechaRegistroLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonGuardar
            // 
            botonGuardar.AutoSize = true;
            botonGuardar.BackColor = SystemColors.ActiveCaption;
            botonGuardar.Location = new Point(293, 276);
            botonGuardar.Margin = new Padding(4, 3, 4, 3);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(253, 47);
            botonGuardar.TabIndex = 15;
            botonGuardar.Text = "Registrar";
            botonGuardar.UseVisualStyleBackColor = false;
            botonGuardar.Click += BotonGuardar_Click;
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.Location = new Point(154, 360);
            footer.Margin = new Padding(4, 0, 4, 0);
            footer.Name = "footer";
            footer.Size = new Size(273, 15);
            footer.TabIndex = 16;
            footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            footer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // clienteActivoLbL
            // 
            clienteActivoLbL.AutoSize = true;
            clienteActivoLbL.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clienteActivoLbL.ImageAlign = ContentAlignment.BottomCenter;
            clienteActivoLbL.Location = new Point(13, 222);
            clienteActivoLbL.Margin = new Padding(4, 0, 4, 0);
            clienteActivoLbL.Name = "clienteActivoLbL";
            clienteActivoLbL.Size = new Size(85, 15);
            clienteActivoLbL.TabIndex = 17;
            clienteActivoLbL.Text = "Cliente Activo  ";
            clienteActivoLbL.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clienteActivo
            // 
            clienteActivo.AutoSize = true;
            clienteActivo.Checked = true;
            clienteActivo.CheckState = CheckState.Checked;
            clienteActivo.Location = new Point(105, 224);
            clienteActivo.Name = "clienteActivo";
            clienteActivo.Size = new Size(15, 14);
            clienteActivo.TabIndex = 18;
            clienteActivo.UseVisualStyleBackColor = true;
            // 
            // botonCancelar
            // 
            botonCancelar.Anchor = AnchorStyles.Right;
            botonCancelar.BackColor = Color.IndianRed;
            botonCancelar.Location = new Point(13, 276);
            botonCancelar.Margin = new Padding(4, 3, 4, 3);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(116, 47);
            botonCancelar.TabIndex = 19;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = false;
            botonCancelar.Click += BotonCancelar_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 384);
            Controls.Add(botonCancelar);
            Controls.Add(clienteActivo);
            Controls.Add(clienteActivoLbL);
            Controls.Add(footer);
            Controls.Add(botonGuardar);
            Controls.Add(fechaRegistro);
            Controls.Add(fechaRegistroLbl);
            Controls.Add(fechaNacimiento);
            Controls.Add(fechaNacimientoLbl);
            Controls.Add(nombreCompletoLbl);
            Controls.Add(nombreCompleto);
            Controls.Add(identificacionClienteLbl);
            Controls.Add(identificacionCliente);
            Controls.Add(idLbl);
            Controls.Add(idCliente);
            Controls.Add(titulo);
            Name = "FrmCliente";
            Text = "AutoMarket - Registrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label idLbl;
        private TextBox idCliente;
        private Label identificacionClienteLbl;
        private TextBox identificacionCliente;
        private Label nombreCompletoLbl;
        private TextBox nombreCompleto;
        private Label fechaNacimientoLbl;
        private DateTimePicker fechaNacimiento;
        private DateTimePicker fechaRegistro;
        private Label fechaRegistroLbl;
        private Button botonGuardar;
        private Label footer;
        private Label clienteActivoLbL;
        private CheckBox clienteActivo;
        private Button botonCancelar;
    }
}