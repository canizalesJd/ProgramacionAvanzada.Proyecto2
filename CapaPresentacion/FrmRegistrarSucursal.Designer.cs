namespace CapaPresentacion
{
    partial class FrmRegistrarSucursal
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
            idLbl = new Label();
            idSucursal = new TextBox();
            titulo = new Label();
            nombreLbl = new Label();
            nombreSucursal = new TextBox();
            direccionLbl = new Label();
            direccionSucursal = new TextBox();
            telefonoLbl = new Label();
            telefonoSucursal = new TextBox();
            comboVendedorEncargado = new ComboBox();
            vendedorEncargadoLbl = new Label();
            sucursalActiva = new CheckBox();
            sucursalActivaLbL = new Label();
            botonGuardar = new Button();
            footer = new Label();
            SuspendLayout();
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLbl.ImageAlign = ContentAlignment.BottomCenter;
            idLbl.Location = new Point(21, 83);
            idLbl.Margin = new Padding(4, 0, 4, 0);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(25, 15);
            idLbl.TabIndex = 8;
            idLbl.Text = "ID  ";
            idLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idSucursal
            // 
            idSucursal.BorderStyle = BorderStyle.FixedSingle;
            idSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idSucursal.Location = new Point(24, 106);
            idSucursal.Margin = new Padding(4, 3, 4, 3);
            idSucursal.Name = "idSucursal";
            idSucursal.Size = new Size(146, 26);
            idSucursal.TabIndex = 7;
            idSucursal.Tag = "";
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(189, 26);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(210, 29);
            titulo.TabIndex = 9;
            titulo.Text = "Registrar Sucursal";
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreLbl.ImageAlign = ContentAlignment.BottomCenter;
            nombreLbl.Location = new Point(187, 83);
            nombreLbl.Margin = new Padding(4, 0, 4, 0);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(52, 15);
            nombreLbl.TabIndex = 12;
            nombreLbl.Text = "Nombre";
            nombreLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nombreSucursal
            // 
            nombreSucursal.BorderStyle = BorderStyle.FixedSingle;
            nombreSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreSucursal.Location = new Point(187, 106);
            nombreSucursal.Margin = new Padding(4, 3, 4, 3);
            nombreSucursal.Name = "nombreSucursal";
            nombreSucursal.Size = new Size(177, 26);
            nombreSucursal.TabIndex = 11;
            nombreSucursal.Tag = "";
            // 
            // direccionLbl
            // 
            direccionLbl.AutoSize = true;
            direccionLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionLbl.ImageAlign = ContentAlignment.BottomCenter;
            direccionLbl.Location = new Point(22, 146);
            direccionLbl.Margin = new Padding(4, 0, 4, 0);
            direccionLbl.Name = "direccionLbl";
            direccionLbl.Size = new Size(59, 15);
            direccionLbl.TabIndex = 14;
            direccionLbl.Text = "Dirección";
            direccionLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // direccionSucursal
            // 
            direccionSucursal.BorderStyle = BorderStyle.FixedSingle;
            direccionSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionSucursal.Location = new Point(24, 169);
            direccionSucursal.Margin = new Padding(4, 3, 4, 3);
            direccionSucursal.Name = "direccionSucursal";
            direccionSucursal.Size = new Size(534, 26);
            direccionSucursal.TabIndex = 13;
            direccionSucursal.Tag = "";
            // 
            // telefonoLbl
            // 
            telefonoLbl.AutoSize = true;
            telefonoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoLbl.ImageAlign = ContentAlignment.BottomCenter;
            telefonoLbl.Location = new Point(378, 83);
            telefonoLbl.Margin = new Padding(4, 0, 4, 0);
            telefonoLbl.Name = "telefonoLbl";
            telefonoLbl.Size = new Size(55, 15);
            telefonoLbl.TabIndex = 16;
            telefonoLbl.Text = "Telefono";
            telefonoLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // telefonoSucursal
            // 
            telefonoSucursal.BorderStyle = BorderStyle.FixedSingle;
            telefonoSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoSucursal.Location = new Point(378, 106);
            telefonoSucursal.Margin = new Padding(4, 3, 4, 3);
            telefonoSucursal.Name = "telefonoSucursal";
            telefonoSucursal.Size = new Size(180, 26);
            telefonoSucursal.TabIndex = 15;
            telefonoSucursal.Tag = "";
            // 
            // comboVendedorEncargado
            // 
            comboVendedorEncargado.FormattingEnabled = true;
            comboVendedorEncargado.Location = new Point(26, 233);
            comboVendedorEncargado.Name = "comboVendedorEncargado";
            comboVendedorEncargado.Size = new Size(407, 23);
            comboVendedorEncargado.Sorted = true;
            comboVendedorEncargado.TabIndex = 17;
            comboVendedorEncargado.Text = "Seleccione un vendedor encargado";
            // 
            // vendedorEncargadoLbl
            // 
            vendedorEncargadoLbl.AutoSize = true;
            vendedorEncargadoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vendedorEncargadoLbl.ImageAlign = ContentAlignment.BottomCenter;
            vendedorEncargadoLbl.Location = new Point(24, 209);
            vendedorEncargadoLbl.Margin = new Padding(4, 0, 4, 0);
            vendedorEncargadoLbl.Name = "vendedorEncargadoLbl";
            vendedorEncargadoLbl.Size = new Size(123, 15);
            vendedorEncargadoLbl.TabIndex = 18;
            vendedorEncargadoLbl.Text = "Vendedor Encargado";
            vendedorEncargadoLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sucursalActiva
            // 
            sucursalActiva.AutoSize = true;
            sucursalActiva.Checked = true;
            sucursalActiva.CheckState = CheckState.Checked;
            sucursalActiva.Location = new Point(540, 237);
            sucursalActiva.Name = "sucursalActiva";
            sucursalActiva.Size = new Size(15, 14);
            sucursalActiva.TabIndex = 20;
            sucursalActiva.UseVisualStyleBackColor = true;
            // 
            // sucursalActivaLbL
            // 
            sucursalActivaLbL.AutoSize = true;
            sucursalActivaLbL.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sucursalActivaLbL.ImageAlign = ContentAlignment.BottomCenter;
            sucursalActivaLbL.Location = new Point(448, 235);
            sucursalActivaLbL.Margin = new Padding(4, 0, 4, 0);
            sucursalActivaLbL.Name = "sucursalActivaLbL";
            sucursalActivaLbL.Size = new Size(89, 15);
            sucursalActivaLbL.TabIndex = 19;
            sucursalActivaLbL.Text = "Sucursal activa";
            sucursalActivaLbL.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonGuardar
            // 
            botonGuardar.AutoSize = true;
            botonGuardar.BackColor = SystemColors.ButtonShadow;
            botonGuardar.Location = new Point(396, 293);
            botonGuardar.Margin = new Padding(4, 3, 4, 3);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(159, 47);
            botonGuardar.TabIndex = 21;
            botonGuardar.Text = "Registrar";
            botonGuardar.UseVisualStyleBackColor = false;
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.Location = new Point(174, 389);
            footer.Margin = new Padding(4, 0, 4, 0);
            footer.Name = "footer";
            footer.Size = new Size(273, 15);
            footer.TabIndex = 22;
            footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            footer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // FrmRegistrarSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 413);
            Controls.Add(footer);
            Controls.Add(botonGuardar);
            Controls.Add(sucursalActiva);
            Controls.Add(sucursalActivaLbL);
            Controls.Add(vendedorEncargadoLbl);
            Controls.Add(comboVendedorEncargado);
            Controls.Add(telefonoLbl);
            Controls.Add(telefonoSucursal);
            Controls.Add(direccionLbl);
            Controls.Add(direccionSucursal);
            Controls.Add(nombreLbl);
            Controls.Add(nombreSucursal);
            Controls.Add(titulo);
            Controls.Add(idLbl);
            Controls.Add(idSucursal);
            Name = "FrmRegistrarSucursal";
            Text = "AutoMarket - Registrar Sucursal";
            Load += this.FrmRegistrarSucursal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLbl;
        private TextBox idSucursal;
        private Label titulo;
        private Label nombreLbl;
        private TextBox nombreSucursal;
        private Label direccionLbl;
        private TextBox direccionSucursal;
        private Label telefonoLbl;
        private TextBox telefonoSucursal;
        private ComboBox comboVendedorEncargado;
        private Label vendedorEncargadoLbl;
        private CheckBox sucursalActiva;
        private Label sucursalActivaLbL;
        private Button botonGuardar;
        private Label footer;
    }
}