namespace TamanOficio
{
    partial class ABMGastos
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
            this.gbxConfirmarAccion = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.cbFactura = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoPagado = new System.Windows.Forms.TextBox();
            this.cbPuntos = new System.Windows.Forms.ComboBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaCarga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbxBuscador = new System.Windows.Forms.GroupBox();
            this.txtBusFechaFin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbBusPuntos = new System.Windows.Forms.ComboBox();
            this.cbBusProveedor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBusFechaIni = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxAcciones = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxConfirmarAccion.SuspendLayout();
            this.gbxBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxConfirmarAccion
            // 
            this.gbxConfirmarAccion.Controls.Add(this.label5);
            this.gbxConfirmarAccion.Controls.Add(this.txtObservacion);
            this.gbxConfirmarAccion.Controls.Add(this.label8);
            this.gbxConfirmarAccion.Controls.Add(this.txtNumFactura);
            this.gbxConfirmarAccion.Controls.Add(this.cbFactura);
            this.gbxConfirmarAccion.Controls.Add(this.label7);
            this.gbxConfirmarAccion.Controls.Add(this.label6);
            this.gbxConfirmarAccion.Controls.Add(this.txtMontoPagado);
            this.gbxConfirmarAccion.Controls.Add(this.cbPuntos);
            this.gbxConfirmarAccion.Controls.Add(this.cbProveedor);
            this.gbxConfirmarAccion.Controls.Add(this.label4);
            this.gbxConfirmarAccion.Controls.Add(this.label3);
            this.gbxConfirmarAccion.Controls.Add(this.txtFechaFactura);
            this.gbxConfirmarAccion.Controls.Add(this.label2);
            this.gbxConfirmarAccion.Controls.Add(this.txtFechaCarga);
            this.gbxConfirmarAccion.Controls.Add(this.label1);
            this.gbxConfirmarAccion.Location = new System.Drawing.Point(315, 56);
            this.gbxConfirmarAccion.Name = "gbxConfirmarAccion";
            this.gbxConfirmarAccion.Size = new System.Drawing.Size(327, 307);
            this.gbxConfirmarAccion.TabIndex = 2;
            this.gbxConfirmarAccion.TabStop = false;
            this.gbxConfirmarAccion.Text = "Detalle gasto seleccionado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Observación:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(114, 238);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(191, 50);
            this.txtObservacion.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nº de Factura:";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(114, 118);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(191, 20);
            this.txtNumFactura.TabIndex = 17;
            // 
            // cbFactura
            // 
            this.cbFactura.FormattingEnabled = true;
            this.cbFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "X"});
            this.cbFactura.Location = new System.Drawing.Point(114, 87);
            this.cbFactura.Name = "cbFactura";
            this.cbFactura.Size = new System.Drawing.Size(191, 21);
            this.cbFactura.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo de Factura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Monto Pagado $:";
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.Location = new System.Drawing.Point(114, 208);
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.Size = new System.Drawing.Size(191, 20);
            this.txtMontoPagado.TabIndex = 13;
            // 
            // cbPuntos
            // 
            this.cbPuntos.FormattingEnabled = true;
            this.cbPuntos.Location = new System.Drawing.Point(114, 178);
            this.cbPuntos.Name = "cbPuntos";
            this.cbPuntos.Size = new System.Drawing.Size(191, 21);
            this.cbPuntos.TabIndex = 9;
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(114, 148);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(191, 21);
            this.cbProveedor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Punto:";
            // 
            // txtFechaFactura
            // 
            this.txtFechaFactura.Location = new System.Drawing.Point(114, 57);
            this.txtFechaFactura.Name = "txtFechaFactura";
            this.txtFechaFactura.Size = new System.Drawing.Size(191, 20);
            this.txtFechaFactura.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Factura:";
            // 
            // txtFechaCarga
            // 
            this.txtFechaCarga.Location = new System.Drawing.Point(114, 27);
            this.txtFechaCarga.Name = "txtFechaCarga";
            this.txtFechaCarga.Size = new System.Drawing.Size(191, 20);
            this.txtFechaCarga.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Carga:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
           this.btnCancelar.Location = new System.Drawing.Point(196, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 42);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
           this.btnAceptar.Location = new System.Drawing.Point(56, 25);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 42);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.Controls.Add(this.txtBusFechaFin);
            this.gbxBuscador.Controls.Add(this.label9);
            this.gbxBuscador.Controls.Add(this.cbBusPuntos);
            this.gbxBuscador.Controls.Add(this.cbBusProveedor);
            this.gbxBuscador.Controls.Add(this.label10);
            this.gbxBuscador.Controls.Add(this.label11);
            this.gbxBuscador.Controls.Add(this.txtBusFechaIni);
            this.gbxBuscador.Controls.Add(this.label12);
            this.gbxBuscador.Controls.Add(this.dgvGastos);
            this.gbxBuscador.Controls.Add(this.btnLimpiar);
            this.gbxBuscador.Controls.Add(this.btnBuscar);
            this.gbxBuscador.Location = new System.Drawing.Point(12, 11);
            this.gbxBuscador.Name = "gbxBuscador";
            this.gbxBuscador.Size = new System.Drawing.Size(297, 481);
            this.gbxBuscador.TabIndex = 9;
            this.gbxBuscador.TabStop = false;
            this.gbxBuscador.Text = "Buscador";
            // 
            // txtBusFechaFin
            // 
            this.txtBusFechaFin.Location = new System.Drawing.Point(100, 48);
            this.txtBusFechaFin.Name = "txtBusFechaFin";
            this.txtBusFechaFin.Size = new System.Drawing.Size(191, 20);
            this.txtBusFechaFin.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Fecha Fin:";
            // 
            // cbBusPuntos
            // 
            this.cbBusPuntos.FormattingEnabled = true;
            this.cbBusPuntos.Location = new System.Drawing.Point(100, 107);
            this.cbBusPuntos.Name = "cbBusPuntos";
            this.cbBusPuntos.Size = new System.Drawing.Size(191, 21);
            this.cbBusPuntos.TabIndex = 24;
            // 
            // cbBusProveedor
            // 
            this.cbBusProveedor.FormattingEnabled = true;
            this.cbBusProveedor.Location = new System.Drawing.Point(100, 78);
            this.cbBusProveedor.Name = "cbBusProveedor";
            this.cbBusProveedor.Size = new System.Drawing.Size(191, 21);
            this.cbBusProveedor.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Proveedor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Punto:";
            // 
            // txtBusFechaIni
            // 
            this.txtBusFechaIni.Location = new System.Drawing.Point(100, 19);
            this.txtBusFechaIni.Name = "txtBusFechaIni";
            this.txtBusFechaIni.Size = new System.Drawing.Size(191, 20);
            this.txtBusFechaIni.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Fecha Inicio:";
            // 
            // dgvGastos
            // 
            this.dgvGastos.AllowUserToAddRows = false;
            this.dgvGastos.AllowUserToDeleteRows = false;
            this.dgvGastos.AllowUserToOrderColumns = true;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Location = new System.Drawing.Point(14, 189);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ReadOnly = true;
            this.dgvGastos.Size = new System.Drawing.Size(267, 274);
            this.dgvGastos.TabIndex = 12;
            this.dgvGastos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGastos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Location = new System.Drawing.Point(315, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 83);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // gbxAcciones
            // 
            this.gbxAcciones.Controls.Add(this.btnVolver);
            this.gbxAcciones.Controls.Add(this.btnEliminar);
            this.gbxAcciones.Controls.Add(this.btnNuevo);
            this.gbxAcciones.Controls.Add(this.btnModificar);
            this.gbxAcciones.Location = new System.Drawing.Point(648, 11);
            this.gbxAcciones.Name = "gbxAcciones";
            this.gbxAcciones.Size = new System.Drawing.Size(130, 481);
            this.gbxAcciones.TabIndex = 13;
            this.gbxAcciones.TabStop = false;
            this.gbxAcciones.Text = "Acciones";
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
           this.btnVolver.Location = new System.Drawing.Point(24, 413);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 41);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Location = new System.Drawing.Point(24, 196);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 39);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
           this.btnNuevo.Location = new System.Drawing.Point(24, 45);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 41);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Location = new System.Drawing.Point(16, 120);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 39);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
this.btnLimpiar.Location = new System.Drawing.Point(166, 138);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 42);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Location = new System.Drawing.Point(48, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 42);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ABMGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 504);
            this.Controls.Add(this.gbxAcciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBuscador);
            this.Controls.Add(this.gbxConfirmarAccion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM de Gastos";
            this.Load += new System.EventHandler(this.ABMGastos_Load);
            this.gbxConfirmarAccion.ResumeLayout(false);
            this.gbxConfirmarAccion.PerformLayout();
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbxAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConfirmarAccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontoPagado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbPuntos;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.ComboBox cbFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxBuscador;
        private System.Windows.Forms.ComboBox cbBusPuntos;
        private System.Windows.Forms.ComboBox cbBusProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBusFechaIni;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxAcciones;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtBusFechaFin;
        private System.Windows.Forms.Label label9;
    }
}