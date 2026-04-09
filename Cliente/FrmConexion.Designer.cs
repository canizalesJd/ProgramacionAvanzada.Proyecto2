/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */

namespace Cliente
{
    partial class FrmConexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titulo = new Label();
            detallesServidorLbl = new Label();
            idClienteLbl = new Label();
            idCliente = new TextBox();
            botonDesconectar = new Button();
            botonConectar = new Button();
            estadoLbl = new Label();
            opcionesLbl = new Label();
            botonGestionVentas = new Button();
            botonConsultar = new Button();
            grupoOpciones = new GroupBox();
            lblBienvenida = new Label();
            grupoOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(13, 9);
            titulo.Margin = new Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(282, 29);
            titulo.TabIndex = 3;
            titulo.Text = "Conectarse a AutoMarket";
            // 
            // detallesServidorLbl
            // 
            detallesServidorLbl.AutoSize = true;
            detallesServidorLbl.Font = new Font("Microsoft Sans Serif", 12F);
            detallesServidorLbl.ForeColor = Color.SeaGreen;
            detallesServidorLbl.ImageAlign = ContentAlignment.BottomCenter;
            detallesServidorLbl.Location = new Point(10, 50);
            detallesServidorLbl.Margin = new Padding(4, 0, 4, 0);
            detallesServidorLbl.Name = "detallesServidorLbl";
            detallesServidorLbl.Size = new Size(253, 20);
            detallesServidorLbl.TabIndex = 20;
            detallesServidorLbl.Text = "Servidor: 127.0.0.1  |  Puerto: 5000";
            detallesServidorLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idClienteLbl
            // 
            idClienteLbl.AutoSize = true;
            idClienteLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idClienteLbl.ImageAlign = ContentAlignment.BottomCenter;
            idClienteLbl.Location = new Point(9, 83);
            idClienteLbl.Margin = new Padding(4, 0, 4, 0);
            idClienteLbl.Name = "idClienteLbl";
            idClienteLbl.Size = new Size(181, 20);
            idClienteLbl.TabIndex = 22;
            idClienteLbl.Text = "Identificación del Cliente";
            idClienteLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idCliente
            // 
            idCliente.BorderStyle = BorderStyle.FixedSingle;
            idCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idCliente.Location = new Point(13, 106);
            idCliente.Margin = new Padding(4, 3, 4, 3);
            idCliente.Name = "idCliente";
            idCliente.Size = new Size(316, 26);
            idCliente.TabIndex = 21;
            idCliente.Tag = "";
            // 
            // botonDesconectar
            // 
            botonDesconectar.BackColor = Color.Tomato;
            botonDesconectar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonDesconectar.Location = new Point(170, 148);
            botonDesconectar.Name = "botonDesconectar";
            botonDesconectar.Size = new Size(161, 37);
            botonDesconectar.TabIndex = 24;
            botonDesconectar.Text = "DESCONECTAR";
            botonDesconectar.UseVisualStyleBackColor = false;
            botonDesconectar.Click += botonDesconectar_Click;
            // 
            // botonConectar
            // 
            botonConectar.BackColor = Color.LightGreen;
            botonConectar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonConectar.Location = new Point(12, 148);
            botonConectar.Name = "botonConectar";
            botonConectar.Size = new Size(149, 37);
            botonConectar.TabIndex = 23;
            botonConectar.Text = "CONECTAR";
            botonConectar.UseVisualStyleBackColor = false;
            botonConectar.Click += botonConectar_Click;
            // 
            // estadoLbl
            // 
            estadoLbl.Anchor = AnchorStyles.Left;
            estadoLbl.AutoSize = true;
            estadoLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            estadoLbl.ForeColor = Color.Red;
            estadoLbl.ImageAlign = ContentAlignment.BottomCenter;
            estadoLbl.Location = new Point(12, 205);
            estadoLbl.Margin = new Padding(4, 0, 4, 0);
            estadoLbl.Name = "estadoLbl";
            estadoLbl.Size = new Size(210, 18);
            estadoLbl.TabIndex = 25;
            estadoLbl.Text = "Estado: DESCONECTADO";
            estadoLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // opcionesLbl
            // 
            opcionesLbl.Anchor = AnchorStyles.Left;
            opcionesLbl.AutoSize = true;
            opcionesLbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            opcionesLbl.ForeColor = Color.DarkBlue;
            opcionesLbl.ImageAlign = ContentAlignment.BottomCenter;
            opcionesLbl.Location = new Point(5, 19);
            opcionesLbl.Margin = new Padding(4, 0, 4, 0);
            opcionesLbl.Name = "opcionesLbl";
            opcionesLbl.Size = new Size(318, 16);
            opcionesLbl.TabIndex = 26;
            opcionesLbl.Text = "Opciones (disponibles después de conectar)";
            opcionesLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonGestionVentas
            // 
            botonGestionVentas.BackColor = Color.Gainsboro;
            botonGestionVentas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonGestionVentas.Location = new Point(4, 61);
            botonGestionVentas.Name = "botonGestionVentas";
            botonGestionVentas.Size = new Size(315, 37);
            botonGestionVentas.TabIndex = 27;
            botonGestionVentas.Text = "GESTIÓN DE VENTAS";
            botonGestionVentas.UseVisualStyleBackColor = false;
            // 
            // botonConsultar
            // 
            botonConsultar.BackColor = Color.Silver;
            botonConsultar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonConsultar.Location = new Point(5, 112);
            botonConsultar.Name = "botonConsultar";
            botonConsultar.Size = new Size(315, 37);
            botonConsultar.TabIndex = 28;
            botonConsultar.Text = "CONSULTA DE INFORMACIÓN";
            botonConsultar.UseVisualStyleBackColor = false;
            // 
            // grupoOpciones
            // 
            grupoOpciones.Controls.Add(opcionesLbl);
            grupoOpciones.Controls.Add(botonConsultar);
            grupoOpciones.Controls.Add(botonGestionVentas);
            grupoOpciones.Location = new Point(12, 283);
            grupoOpciones.Name = "grupoOpciones";
            grupoOpciones.Size = new Size(334, 177);
            grupoOpciones.TabIndex = 29;
            grupoOpciones.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBienvenida.Location = new Point(13, 239);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(327, 19);
            lblBienvenida.TabIndex = 30;
            lblBienvenida.Text = "Por favor, ingrese su identificación para conectarse";
            // 
            // FrmConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 472);
            Controls.Add(lblBienvenida);
            Controls.Add(grupoOpciones);
            Controls.Add(estadoLbl);
            Controls.Add(botonDesconectar);
            Controls.Add(botonConectar);
            Controls.Add(idClienteLbl);
            Controls.Add(idCliente);
            Controls.Add(detallesServidorLbl);
            Controls.Add(titulo);
            Name = "FrmConexion";
            Text = "AutoMarket - Conectarse";
            FormClosed += FrmConexion_FormClosed;
            grupoOpciones.ResumeLayout(false);
            grupoOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label detallesServidorLbl;
        private Label idClienteLbl;
        private TextBox idCliente;
        private Button botonDesconectar;
        private Button botonConectar;
        private Label estadoLbl;
        private Label opcionesLbl;
        private Button botonGestionVentas;
        private Button botonConsultar;
        private GroupBox grupoOpciones;
        private Label lblBienvenida;
    }
}
