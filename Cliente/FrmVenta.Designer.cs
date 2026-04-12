namespace Cliente
{
    partial class FrmVenta
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
            sucursalLbl = new Label();
            comboSucursal = new ComboBox();
            vehiculoLbl = new Label();
            comboVehiculo = new ComboBox();
            precioLbl = new Label();
            precio = new TextBox();
            footer = new Label();
            botonCancelar = new Button();
            botonGuardar = new Button();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(78, 23);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(178, 29);
            titulo.TabIndex = 11;
            titulo.Text = "Registrar Venta";
            // 
            // sucursalLbl
            // 
            sucursalLbl.AutoSize = true;
            sucursalLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sucursalLbl.ImageAlign = ContentAlignment.BottomCenter;
            sucursalLbl.Location = new Point(15, 68);
            sucursalLbl.Margin = new Padding(4, 0, 4, 0);
            sucursalLbl.Name = "sucursalLbl";
            sucursalLbl.Size = new Size(55, 15);
            sucursalLbl.TabIndex = 35;
            sucursalLbl.Text = "Sucursal";
            sucursalLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboSucursal
            // 
            comboSucursal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboSucursal.FormattingEnabled = true;
            comboSucursal.Location = new Point(17, 88);
            comboSucursal.Name = "comboSucursal";
            comboSucursal.Size = new Size(292, 23);
            comboSucursal.Sorted = true;
            comboSucursal.TabIndex = 34;
            comboSucursal.Text = " Seleccione una sucursal";
            comboSucursal.SelectedIndexChanged += comboSucursal_SelectedIndexChanged;
            // 
            // vehiculoLbl
            // 
            vehiculoLbl.AutoSize = true;
            vehiculoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vehiculoLbl.ImageAlign = ContentAlignment.BottomCenter;
            vehiculoLbl.Location = new Point(13, 125);
            vehiculoLbl.Margin = new Padding(4, 0, 4, 0);
            vehiculoLbl.Name = "vehiculoLbl";
            vehiculoLbl.Size = new Size(54, 15);
            vehiculoLbl.TabIndex = 37;
            vehiculoLbl.Text = "Vehículo";
            vehiculoLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboVehiculo
            // 
            comboVehiculo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboVehiculo.FormattingEnabled = true;
            comboVehiculo.Location = new Point(15, 143);
            comboVehiculo.Name = "comboVehiculo";
            comboVehiculo.Size = new Size(294, 23);
            comboVehiculo.Sorted = true;
            comboVehiculo.TabIndex = 36;
            comboVehiculo.Text = " Seleccione un vehículo";
            comboVehiculo.SelectedIndexChanged += comboVehiculo_SelectedIndexChanged;
            // 
            // precioLbl
            // 
            precioLbl.AutoSize = true;
            precioLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precioLbl.ImageAlign = ContentAlignment.BottomCenter;
            precioLbl.Location = new Point(13, 181);
            precioLbl.Margin = new Padding(4, 0, 4, 0);
            precioLbl.Name = "precioLbl";
            precioLbl.Size = new Size(42, 15);
            precioLbl.TabIndex = 43;
            precioLbl.Text = "Precio";
            precioLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // precio
            // 
            precio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            precio.BorderStyle = BorderStyle.FixedSingle;
            precio.Enabled = false;
            precio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precio.Location = new Point(17, 199);
            precio.Margin = new Padding(4, 3, 4, 3);
            precio.Name = "precio";
            precio.Size = new Size(292, 26);
            precio.TabIndex = 42;
            precio.Tag = "";
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.Location = new Point(36, 336);
            footer.Margin = new Padding(4, 0, 4, 0);
            footer.Name = "footer";
            footer.Size = new Size(273, 15);
            footer.TabIndex = 44;
            footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            footer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // botonCancelar
            // 
            botonCancelar.Anchor = AnchorStyles.Right;
            botonCancelar.BackColor = Color.IndianRed;
            botonCancelar.Location = new Point(17, 245);
            botonCancelar.Margin = new Padding(4, 3, 4, 3);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(127, 47);
            botonCancelar.TabIndex = 46;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = false;
            // 
            // botonGuardar
            // 
            botonGuardar.AutoSize = true;
            botonGuardar.BackColor = SystemColors.ActiveCaption;
            botonGuardar.Location = new Point(152, 245);
            botonGuardar.Margin = new Padding(4, 3, 4, 3);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(157, 47);
            botonGuardar.TabIndex = 45;
            botonGuardar.Text = "Registrar";
            botonGuardar.UseVisualStyleBackColor = false;
            botonGuardar.Click += botonGuardar_Click;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 360);
            Controls.Add(botonCancelar);
            Controls.Add(botonGuardar);
            Controls.Add(footer);
            Controls.Add(precioLbl);
            Controls.Add(precio);
            Controls.Add(vehiculoLbl);
            Controls.Add(comboVehiculo);
            Controls.Add(sucursalLbl);
            Controls.Add(comboSucursal);
            Controls.Add(titulo);
            Name = "FrmVenta";
            Text = "AutoMarket - Registrar Venta ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label sucursalLbl;
        private ComboBox comboSucursal;
        private Label vehiculoLbl;
        private ComboBox comboVehiculo;
        private Label precioLbl;
        private TextBox precio;
        private Label footer;
        private Button botonCancelar;
        private Button botonGuardar;
    }
}