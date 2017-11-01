namespace TamanOficio
{
    partial class ABMCuotas
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
            this.gbxHistorialCuotas = new System.Windows.Forms.GroupBox();
            this.dgvHistorialCuotas = new System.Windows.Forms.DataGridView();
            this.gbxDetalleAlumno = new System.Windows.Forms.GroupBox();
            this.txtMontoCuotaTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreClase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoClase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxOperaciones = new System.Windows.Forms.GroupBox();
            this.txtMontoDeuda = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAlumnoPaga = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDebePagar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNumCuota = new System.Windows.Forms.TextBox();
            this.txtMontoSaldo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMontoCuota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFechaRealPago = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVerFactura = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbxHistorialCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCuotas)).BeginInit();
            this.gbxDetalleAlumno.SuspendLayout();
            this.gbxOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHistorialCuotas
            // 
            this.gbxHistorialCuotas.Controls.Add(this.dgvHistorialCuotas);
            this.gbxHistorialCuotas.Location = new System.Drawing.Point(12, 12);
            this.gbxHistorialCuotas.Name = "gbxHistorialCuotas";
            this.gbxHistorialCuotas.Size = new System.Drawing.Size(557, 367);
            this.gbxHistorialCuotas.TabIndex = 0;
            this.gbxHistorialCuotas.TabStop = false;
            this.gbxHistorialCuotas.Text = "Historial de Cuostas";
            // 
            // dgvHistorialCuotas
            // 
            this.dgvHistorialCuotas.AllowUserToAddRows = false;
            this.dgvHistorialCuotas.AllowUserToDeleteRows = false;
            this.dgvHistorialCuotas.AllowUserToOrderColumns = true;
            this.dgvHistorialCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCuotas.Location = new System.Drawing.Point(18, 19);
            this.dgvHistorialCuotas.Name = "dgvHistorialCuotas";
            this.dgvHistorialCuotas.ReadOnly = true;
            this.dgvHistorialCuotas.Size = new System.Drawing.Size(519, 330);
            this.dgvHistorialCuotas.TabIndex = 27;
            this.dgvHistorialCuotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialCuotas_CellClick);
            // 
            // gbxDetalleAlumno
            // 
            this.gbxDetalleAlumno.Controls.Add(this.txtMontoCuotaTotal);
            this.gbxDetalleAlumno.Controls.Add(this.label8);
            this.gbxDetalleAlumno.Controls.Add(this.txtNombreClase);
            this.gbxDetalleAlumno.Controls.Add(this.label7);
            this.gbxDetalleAlumno.Controls.Add(this.txtTipoClase);
            this.gbxDetalleAlumno.Controls.Add(this.label6);
            this.gbxDetalleAlumno.Controls.Add(this.txtPunto);
            this.gbxDetalleAlumno.Controls.Add(this.label5);
            this.gbxDetalleAlumno.Controls.Add(this.txtEmail);
            this.gbxDetalleAlumno.Controls.Add(this.label4);
            this.gbxDetalleAlumno.Controls.Add(this.txtDni);
            this.gbxDetalleAlumno.Controls.Add(this.label3);
            this.gbxDetalleAlumno.Controls.Add(this.txtNombre);
            this.gbxDetalleAlumno.Controls.Add(this.label2);
            this.gbxDetalleAlumno.Controls.Add(this.txtApellido);
            this.gbxDetalleAlumno.Controls.Add(this.label1);
            this.gbxDetalleAlumno.Location = new System.Drawing.Point(575, 12);
            this.gbxDetalleAlumno.Name = "gbxDetalleAlumno";
            this.gbxDetalleAlumno.Size = new System.Drawing.Size(502, 130);
            this.gbxDetalleAlumno.TabIndex = 1;
            this.gbxDetalleAlumno.TabStop = false;
            this.gbxDetalleAlumno.Text = "Detalle del alumno seleccionado";
            // 
            // txtMontoCuotaTotal
            // 
            this.txtMontoCuotaTotal.Location = new System.Drawing.Point(338, 97);
            this.txtMontoCuotaTotal.Name = "txtMontoCuotaTotal";
            this.txtMontoCuotaTotal.Size = new System.Drawing.Size(133, 20);
            this.txtMontoCuotaTotal.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Monto de cuota $:";
            // 
            // txtNombreClase
            // 
            this.txtNombreClase.Location = new System.Drawing.Point(338, 71);
            this.txtNombreClase.Name = "txtNombreClase";
            this.txtNombreClase.Size = new System.Drawing.Size(133, 20);
            this.txtNombreClase.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre de clase:";
            // 
            // txtTipoClase
            // 
            this.txtTipoClase.Location = new System.Drawing.Point(338, 45);
            this.txtTipoClase.Name = "txtTipoClase";
            this.txtTipoClase.Size = new System.Drawing.Size(133, 20);
            this.txtTipoClase.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de clase:";
            // 
            // txtPunto
            // 
            this.txtPunto.Location = new System.Drawing.Point(338, 19);
            this.txtPunto.Name = "txtPunto";
            this.txtPunto.Size = new System.Drawing.Size(133, 20);
            this.txtPunto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Punto:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(87, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(133, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(87, 71);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(133, 20);
            this.txtDni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI Alumno:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(87, 19);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(133, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido:";
            // 
            // gbxOperaciones
            // 
            this.gbxOperaciones.Controls.Add(this.btnVerFactura);
            this.gbxOperaciones.Controls.Add(this.btnAceptar);
            this.gbxOperaciones.Controls.Add(this.txtMontoDeuda);
            this.gbxOperaciones.Controls.Add(this.label13);
            this.gbxOperaciones.Controls.Add(this.txtAlumnoPaga);
            this.gbxOperaciones.Controls.Add(this.label14);
            this.gbxOperaciones.Controls.Add(this.txtDebePagar);
            this.gbxOperaciones.Controls.Add(this.label15);
            this.gbxOperaciones.Controls.Add(this.txtNumCuota);
            this.gbxOperaciones.Controls.Add(this.txtMontoSaldo);
            this.gbxOperaciones.Controls.Add(this.label12);
            this.gbxOperaciones.Controls.Add(this.txtMontoCuota);
            this.gbxOperaciones.Controls.Add(this.label11);
            this.gbxOperaciones.Controls.Add(this.txtFechaRealPago);
            this.gbxOperaciones.Controls.Add(this.label10);
            this.gbxOperaciones.Controls.Add(this.txtFechaPago);
            this.gbxOperaciones.Controls.Add(this.label9);
            this.gbxOperaciones.Location = new System.Drawing.Point(575, 157);
            this.gbxOperaciones.Name = "gbxOperaciones";
            this.gbxOperaciones.Size = new System.Drawing.Size(502, 222);
            this.gbxOperaciones.TabIndex = 2;
            this.gbxOperaciones.TabStop = false;
            this.gbxOperaciones.Text = "Detalle del alumno seleccionado";
            // 
            // txtMontoDeuda
            // 
            this.txtMontoDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoDeuda.Location = new System.Drawing.Point(358, 120);
            this.txtMontoDeuda.Name = "txtMontoDeuda";
            this.txtMontoDeuda.Size = new System.Drawing.Size(133, 22);
            this.txtMontoDeuda.TabIndex = 23;
            this.txtMontoDeuda.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(247, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Deuda alumno $:";
            // 
            // txtAlumnoPaga
            // 
            this.txtAlumnoPaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlumnoPaga.Location = new System.Drawing.Point(358, 89);
            this.txtAlumnoPaga.Name = "txtAlumnoPaga";
            this.txtAlumnoPaga.Size = new System.Drawing.Size(133, 22);
            this.txtAlumnoPaga.TabIndex = 21;
            this.txtAlumnoPaga.Text = "0.00";
            this.txtAlumnoPaga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlumnoPaga_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(255, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Alumno paga $:";
            // 
            // txtDebePagar
            // 
            this.txtDebePagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebePagar.Location = new System.Drawing.Point(358, 59);
            this.txtDebePagar.Name = "txtDebePagar";
            this.txtDebePagar.Size = new System.Drawing.Size(133, 22);
            this.txtDebePagar.TabIndex = 19;
            this.txtDebePagar.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(262, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Debe pagar $:";
            // 
            // txtNumCuota
            // 
            this.txtNumCuota.Enabled = false;
            this.txtNumCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCuota.Location = new System.Drawing.Point(358, 23);
            this.txtNumCuota.Name = "txtNumCuota";
            this.txtNumCuota.Size = new System.Drawing.Size(133, 24);
            this.txtNumCuota.TabIndex = 17;
            // 
            // txtMontoSaldo
            // 
            this.txtMontoSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoSaldo.Location = new System.Drawing.Point(106, 116);
            this.txtMontoSaldo.Name = "txtMontoSaldo";
            this.txtMontoSaldo.Size = new System.Drawing.Size(133, 20);
            this.txtMontoSaldo.TabIndex = 9;
            this.txtMontoSaldo.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Monto saldo $:";
            // 
            // txtMontoCuota
            // 
            this.txtMontoCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCuota.Location = new System.Drawing.Point(106, 87);
            this.txtMontoCuota.Name = "txtMontoCuota";
            this.txtMontoCuota.Size = new System.Drawing.Size(133, 20);
            this.txtMontoCuota.TabIndex = 7;
            this.txtMontoCuota.Text = "0.00";
            this.txtMontoCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoCuota_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Monto cuota $:";
            // 
            // txtFechaRealPago
            // 
            this.txtFechaRealPago.Enabled = false;
            this.txtFechaRealPago.Location = new System.Drawing.Point(106, 59);
            this.txtFechaRealPago.Name = "txtFechaRealPago";
            this.txtFechaRealPago.Size = new System.Drawing.Size(133, 20);
            this.txtFechaRealPago.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Fecha del pago:";
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(106, 31);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(133, 20);
            this.txtFechaPago.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fecha de carga:";
            // 
            // btnVerFactura
            // 
            this.btnVerFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerFactura.Name = "btnVerFactura";
            this.btnVerFactura.Size = new System.Drawing.Size(96, 41);
            this.btnVerFactura.TabIndex = 27;
            this.btnVerFactura.Text = "Ver factura";
            this.btnVerFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerFactura.UseVisualStyleBackColor = true;
            this.btnVerFactura.Click += new System.EventHandler(this.btnVerFactura_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Location = new System.Drawing.Point(323, 163);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 41);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Cobrar cuota";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ABMCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 393);
            this.Controls.Add(this.gbxOperaciones);
            this.Controls.Add(this.gbxDetalleAlumno);
            this.Controls.Add(this.gbxHistorialCuotas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMCuotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Cuotas";
            this.Load += new System.EventHandler(this.ABMCuotas_Load);
            this.gbxHistorialCuotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCuotas)).EndInit();
            this.gbxDetalleAlumno.ResumeLayout(false);
            this.gbxDetalleAlumno.PerformLayout();
            this.gbxOperaciones.ResumeLayout(false);
            this.gbxOperaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHistorialCuotas;
        private System.Windows.Forms.DataGridView dgvHistorialCuotas;
        private System.Windows.Forms.GroupBox gbxDetalleAlumno;
        private System.Windows.Forms.TextBox txtMontoCuotaTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreClase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipoClase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxOperaciones;
        private System.Windows.Forms.TextBox txtMontoDeuda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAlumnoPaga;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDebePagar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNumCuota;
        private System.Windows.Forms.TextBox txtMontoSaldo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMontoCuota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFechaRealPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVerFactura;
        private System.Windows.Forms.Button btnAceptar;
    }
}