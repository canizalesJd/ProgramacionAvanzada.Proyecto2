/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Abril 2026
 */


namespace Servidor
{
    partial class FrmServidor
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
            detallesServidorLbl = new Label();
            botonEncender = new Button();
            botonApagar = new Button();
            clientesConectadosLbl = new Label();
            bitacoraLbl = new Label();
            botonLimpiarBitacora = new Button();
            botonAdministracion = new Button();
            bitacoraLv = new ListView();
            clientesLv = new ListView();
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
            titulo.Size = new Size(231, 29);
            titulo.TabIndex = 2;
            titulo.Text = "Servidor AutoMarket";
            // 
            // detallesServidorLbl
            // 
            detallesServidorLbl.AutoSize = true;
            detallesServidorLbl.Font = new Font("Microsoft Sans Serif", 12F);
            detallesServidorLbl.ForeColor = Color.SeaGreen;
            detallesServidorLbl.ImageAlign = ContentAlignment.BottomCenter;
            detallesServidorLbl.Location = new Point(15, 53);
            detallesServidorLbl.Margin = new Padding(4, 0, 4, 0);
            detallesServidorLbl.Name = "detallesServidorLbl";
            detallesServidorLbl.Size = new Size(322, 20);
            detallesServidorLbl.TabIndex = 19;
            detallesServidorLbl.Text = "IP: 127.0.0.1 | Puerto: 5000 | Máx Clientes: 5";
            detallesServidorLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonEncender
            // 
            botonEncender.BackColor = Color.LightGreen;
            botonEncender.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonEncender.Location = new Point(15, 91);
            botonEncender.Name = "botonEncender";
            botonEncender.Size = new Size(149, 37);
            botonEncender.TabIndex = 20;
            botonEncender.Text = "ENCENDER";
            botonEncender.UseVisualStyleBackColor = false;
            botonEncender.Click += botonEncender_Click;
            // 
            // botonApagar
            // 
            botonApagar.BackColor = Color.Tomato;
            botonApagar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonApagar.Location = new Point(170, 91);
            botonApagar.Name = "botonApagar";
            botonApagar.Size = new Size(161, 37);
            botonApagar.TabIndex = 21;
            botonApagar.Text = "APAGAR";
            botonApagar.UseVisualStyleBackColor = false;
            botonApagar.Click += botonApagar_Click;
            // 
            // clientesConectadosLbl
            // 
            clientesConectadosLbl.AutoSize = true;
            clientesConectadosLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientesConectadosLbl.ForeColor = Color.Black;
            clientesConectadosLbl.ImageAlign = ContentAlignment.BottomCenter;
            clientesConectadosLbl.Location = new Point(13, 143);
            clientesConectadosLbl.Margin = new Padding(4, 0, 4, 0);
            clientesConectadosLbl.Name = "clientesConectadosLbl";
            clientesConectadosLbl.Size = new Size(235, 20);
            clientesConectadosLbl.TabIndex = 23;
            clientesConectadosLbl.Text = "Clientes Conectados: 0 de 5";
            clientesConectadosLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bitacoraLbl
            // 
            bitacoraLbl.AccessibleRole = AccessibleRole.None;
            bitacoraLbl.AutoSize = true;
            bitacoraLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bitacoraLbl.ForeColor = Color.Black;
            bitacoraLbl.ImageAlign = ContentAlignment.BottomCenter;
            bitacoraLbl.Location = new Point(13, 288);
            bitacoraLbl.Margin = new Padding(4, 0, 4, 0);
            bitacoraLbl.Name = "bitacoraLbl";
            bitacoraLbl.Size = new Size(76, 20);
            bitacoraLbl.TabIndex = 25;
            bitacoraLbl.Text = "Bitacora";
            bitacoraLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonLimpiarBitacora
            // 
            botonLimpiarBitacora.BackColor = Color.Gray;
            botonLimpiarBitacora.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonLimpiarBitacora.Location = new Point(359, 280);
            botonLimpiarBitacora.Name = "botonLimpiarBitacora";
            botonLimpiarBitacora.Size = new Size(149, 37);
            botonLimpiarBitacora.TabIndex = 26;
            botonLimpiarBitacora.Text = "LIMPIAR";
            botonLimpiarBitacora.UseVisualStyleBackColor = false;
            botonLimpiarBitacora.Click += botonLimpiarBitacora_Click;
            // 
            // botonAdministracion
            // 
            botonAdministracion.BackColor = Color.CornflowerBlue;
            botonAdministracion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonAdministracion.Location = new Point(337, 91);
            botonAdministracion.Name = "botonAdministracion";
            botonAdministracion.Size = new Size(174, 37);
            botonAdministracion.TabIndex = 27;
            botonAdministracion.Text = "MENÚ ADMINISTRATIVO";
            botonAdministracion.UseVisualStyleBackColor = false;
            botonAdministracion.Click += botonAdministracion_Click;
            // 
            // bitacoraLv
            // 
            bitacoraLv.Location = new Point(15, 328);
            bitacoraLv.Name = "bitacoraLv";
            bitacoraLv.Size = new Size(493, 243);
            bitacoraLv.TabIndex = 28;
            bitacoraLv.UseCompatibleStateImageBehavior = false;
            bitacoraLv.View = View.List;
            // 
            // clientesLv
            // 
            clientesLv.Location = new Point(15, 166);
            clientesLv.Name = "clientesLv";
            clientesLv.Size = new Size(493, 98);
            clientesLv.TabIndex = 29;
            clientesLv.UseCompatibleStateImageBehavior = false;
            clientesLv.View = View.List;
            // 
            // FrmServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 583);
            Controls.Add(clientesLv);
            Controls.Add(bitacoraLv);
            Controls.Add(botonAdministracion);
            Controls.Add(botonLimpiarBitacora);
            Controls.Add(bitacoraLbl);
            Controls.Add(clientesConectadosLbl);
            Controls.Add(botonApagar);
            Controls.Add(botonEncender);
            Controls.Add(detallesServidorLbl);
            Controls.Add(titulo);
            Name = "FrmServidor";
            Text = "AutoMarket - Servidor";
            FormClosed += FrmServidor_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label detallesServidorLbl;
        private Button botonEncender;
        private Button botonApagar;
        private Label clientesConectadosLbl;
        private Label bitacoraLbl;
        private Button botonLimpiarBitacora;
        private Button botonAdministracion;
        private ListView bitacoraLv;
        private ListView clientesLv;
    }
}