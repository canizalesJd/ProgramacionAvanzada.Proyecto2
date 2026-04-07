namespace CapaPresentacion
{
    partial class FrmVehiculoXSucursal
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
            comboVehiculo = new ComboBox();
            comboSucursal = new ComboBox();
            cantidad = new TextBox();
            vehiculoLbl = new Label();
            sucursalLbl = new Label();
            cantidadLbl = new Label();
            botonCancelar = new Button();
            botonGuardar = new Button();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(100, 9);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(333, 29);
            titulo.TabIndex = 11;
            titulo.Text = "Asociar Vehículo por Sucursal";
            // 
            // footer
            // 
            footer.Anchor = AnchorStyles.Bottom;
            footer.AutoSize = true;
            footer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            footer.Location = new Point(136, 311);
            footer.Margin = new Padding(4, 0, 4, 0);
            footer.Name = "footer";
            footer.Size = new Size(273, 15);
            footer.TabIndex = 28;
            footer.Text = "AutoMarket ©  - Todos los Derechos Resevados  ";
            footer.TextAlign = ContentAlignment.BottomCenter;
            // 
            // comboVehiculo
            // 
            comboVehiculo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboVehiculo.FormattingEnabled = true;
            comboVehiculo.Location = new Point(13, 76);
            comboVehiculo.Name = "comboVehiculo";
            comboVehiculo.Size = new Size(519, 23);
            comboVehiculo.Sorted = true;
            comboVehiculo.TabIndex = 29;
            comboVehiculo.Text = " Seleccione un vehículo";
            // 
            // comboSucursal
            // 
            comboSucursal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboSucursal.FormattingEnabled = true;
            comboSucursal.Location = new Point(11, 134);
            comboSucursal.Name = "comboSucursal";
            comboSucursal.Size = new Size(519, 23);
            comboSucursal.Sorted = true;
            comboSucursal.TabIndex = 30;
            comboSucursal.Text = " Seleccione una sucursal";
            // 
            // cantidad
            // 
            cantidad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cantidad.BorderStyle = BorderStyle.FixedSingle;
            cantidad.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cantidad.Location = new Point(12, 193);
            cantidad.Margin = new Padding(4, 3, 4, 3);
            cantidad.Name = "cantidad";
            cantidad.Size = new Size(516, 26);
            cantidad.TabIndex = 31;
            cantidad.Tag = "";
            // 
            // vehiculoLbl
            // 
            vehiculoLbl.AutoSize = true;
            vehiculoLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vehiculoLbl.ImageAlign = ContentAlignment.BottomCenter;
            vehiculoLbl.Location = new Point(10, 58);
            vehiculoLbl.Margin = new Padding(4, 0, 4, 0);
            vehiculoLbl.Name = "vehiculoLbl";
            vehiculoLbl.Size = new Size(54, 15);
            vehiculoLbl.TabIndex = 32;
            vehiculoLbl.Text = "Vehículo";
            vehiculoLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sucursalLbl
            // 
            sucursalLbl.AutoSize = true;
            sucursalLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sucursalLbl.ImageAlign = ContentAlignment.BottomCenter;
            sucursalLbl.Location = new Point(9, 114);
            sucursalLbl.Margin = new Padding(4, 0, 4, 0);
            sucursalLbl.Name = "sucursalLbl";
            sucursalLbl.Size = new Size(55, 15);
            sucursalLbl.TabIndex = 33;
            sucursalLbl.Text = "Sucursal";
            sucursalLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cantidadLbl
            // 
            cantidadLbl.AutoSize = true;
            cantidadLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cantidadLbl.ImageAlign = ContentAlignment.BottomCenter;
            cantidadLbl.Location = new Point(10, 175);
            cantidadLbl.Margin = new Padding(4, 0, 4, 0);
            cantidadLbl.Name = "cantidadLbl";
            cantidadLbl.Size = new Size(56, 15);
            cantidadLbl.TabIndex = 34;
            cantidadLbl.Text = "Cantidad";
            cantidadLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonCancelar
            // 
            botonCancelar.Anchor = AnchorStyles.Left;
            botonCancelar.BackColor = Color.IndianRed;
            botonCancelar.Location = new Point(11, 243);
            botonCancelar.Margin = new Padding(4, 3, 4, 3);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(167, 47);
            botonCancelar.TabIndex = 35;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = false;
            botonCancelar.Click += BotonCancelar_Click;
            // 
            // botonGuardar
            // 
            botonGuardar.Anchor = AnchorStyles.Left;
            botonGuardar.AutoSize = true;
            botonGuardar.BackColor = SystemColors.ActiveCaption;
            botonGuardar.Location = new Point(186, 243);
            botonGuardar.Margin = new Padding(4, 3, 4, 3);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(346, 47);
            botonGuardar.TabIndex = 36;
            botonGuardar.Text = "Registrar";
            botonGuardar.UseVisualStyleBackColor = false;
            botonGuardar.Click += BotonGuardar_Click;
            // 
            // FrmVehiculoXSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 335);
            Controls.Add(botonGuardar);
            Controls.Add(botonCancelar);
            Controls.Add(cantidadLbl);
            Controls.Add(sucursalLbl);
            Controls.Add(vehiculoLbl);
            Controls.Add(cantidad);
            Controls.Add(comboSucursal);
            Controls.Add(comboVehiculo);
            Controls.Add(footer);
            Controls.Add(titulo);
            Name = "FrmVehiculoXSucursal";
            Text = "AutoMarket -  Asociar Vehículo por Sucursal";
            Load += FrmVehiculoXSucursal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label footer;
        private ComboBox comboVehiculo;
        private ComboBox comboSucursal;
        private TextBox cantidad;
        private Label vehiculoLbl;
        private Label sucursalLbl;
        private Label cantidadLbl;
        private Button botonCancelar;
        private Button botonGuardar;
    }
}