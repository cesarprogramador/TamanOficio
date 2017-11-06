namespace TamanOficio
{
    partial class Principal
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
            this.dgvDetalleCaja = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBmGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBusNombreClase = new System.Windows.Forms.Button();
            this.btnBusTipoClase = new System.Windows.Forms.Button();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.btnCajaDia = new System.Windows.Forms.Button();
            this.txtBusDetalleMovimiento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbBusNombreClase = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbBusTipoClase = new System.Windows.Forms.ComboBox();
            this.cbBusPuntos = new System.Windows.Forms.ComboBox();
            this.cbBusTipoOperaciones = new System.Windows.Forms.ComboBox();
            this.cbBusTipoPersona = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusFechaFin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusFechaIni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.txtTotalIngreso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalEgreso = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalCaja = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCaja)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleCaja
            // 
            this.dgvDetalleCaja.AllowUserToAddRows = false;
            this.dgvDetalleCaja.AllowUserToDeleteRows = false;
            this.dgvDetalleCaja.AllowUserToOrderColumns = true;
            this.dgvDetalleCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCaja.Location = new System.Drawing.Point(12, 232);
            this.dgvDetalleCaja.Name = "dgvDetalleCaja";
            this.dgvDetalleCaja.ReadOnly = true;
            this.dgvDetalleCaja.Size = new System.Drawing.Size(926, 379);
            this.dgvDetalleCaja.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.aBMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 8);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(205, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupBaseToolStripMenuItem,
            this.recuperarBaseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cerrarSessionToolStripMenuItem,
            this.salirProgramaToolStripMenuItem});
            this.archivosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivosToolStripMenuItem.Text = "Archivo";
            // 
            // backupBaseToolStripMenuItem
            // 
            this.backupBaseToolStripMenuItem.Name = "backupBaseToolStripMenuItem";
            this.backupBaseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.backupBaseToolStripMenuItem.Text = "Backup base";
            // 
            // recuperarBaseToolStripMenuItem
            // 
            this.recuperarBaseToolStripMenuItem.Name = "recuperarBaseToolStripMenuItem";
            this.recuperarBaseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.recuperarBaseToolStripMenuItem.Text = "Recuperar base";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // cerrarSessionToolStripMenuItem
            // 
            this.cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            this.cerrarSessionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cerrarSessionToolStripMenuItem.Text = "Cerrar session";
            this.cerrarSessionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessionToolStripMenuItem_Click);
            // 
            // salirProgramaToolStripMenuItem
            // 
            this.salirProgramaToolStripMenuItem.Name = "salirProgramaToolStripMenuItem";
            this.salirProgramaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.salirProgramaToolStripMenuItem.Text = "Salir programa";
            this.salirProgramaToolStripMenuItem.Click += new System.EventHandler(this.salirProgramaToolStripMenuItem_Click);
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMEmpleadosToolStripMenuItem,
            this.aBMProfesoresToolStripMenuItem,
            this.aBMProveedoresToolStripMenuItem,
            this.aBMSociosToolStripMenuItem,
            this.aBmGastosToolStripMenuItem});
            this.aBMToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // aBMEmpleadosToolStripMenuItem
            // 
            this.aBMEmpleadosToolStripMenuItem.Name = "aBMEmpleadosToolStripMenuItem";
            this.aBMEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aBMEmpleadosToolStripMenuItem.Text = "ABM Empleados";
            this.aBMEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.aBMEmpleadosToolStripMenuItem_Click);
            // 
            // aBMProfesoresToolStripMenuItem
            // 
            this.aBMProfesoresToolStripMenuItem.Name = "aBMProfesoresToolStripMenuItem";
            this.aBMProfesoresToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aBMProfesoresToolStripMenuItem.Text = "ABM Profesores";
            this.aBMProfesoresToolStripMenuItem.Click += new System.EventHandler(this.aBMProfesoresToolStripMenuItem_Click);
            // 
            // aBMProveedoresToolStripMenuItem
            // 
            this.aBMProveedoresToolStripMenuItem.Name = "aBMProveedoresToolStripMenuItem";
            this.aBMProveedoresToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aBMProveedoresToolStripMenuItem.Text = "ABM Proveedores";
            this.aBMProveedoresToolStripMenuItem.Click += new System.EventHandler(this.aBMProveedoresToolStripMenuItem_Click);
            // 
            // aBMSociosToolStripMenuItem
            // 
            this.aBMSociosToolStripMenuItem.Name = "aBMSociosToolStripMenuItem";
            this.aBMSociosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aBMSociosToolStripMenuItem.Text = "ABM Socios";
            this.aBMSociosToolStripMenuItem.Click += new System.EventHandler(this.aBMSociosToolStripMenuItem_Click);
            // 
            // aBmGastosToolStripMenuItem
            // 
            this.aBmGastosToolStripMenuItem.Name = "aBmGastosToolStripMenuItem";
            this.aBmGastosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aBmGastosToolStripMenuItem.Text = "ABM Gastos";
            this.aBmGastosToolStripMenuItem.Click += new System.EventHandler(this.aBmGastosToolStripMenuItem_Click);
            // 
            // btnBusNombreClase
            // 
            this.btnBusNombreClase.ForeColor = System.Drawing.Color.Black;
            this.btnBusNombreClase.Location = new System.Drawing.Point(494, 120);
            this.btnBusNombreClase.Name = "btnBusNombreClase";
            this.btnBusNombreClase.Size = new System.Drawing.Size(30, 23);
            this.btnBusNombreClase.TabIndex = 55;
            this.btnBusNombreClase.Text = "...";
            this.btnBusNombreClase.UseVisualStyleBackColor = true;
            this.btnBusNombreClase.Click += new System.EventHandler(this.btnBusNombreClase_Click);
            // 
            // btnBusTipoClase
            // 
            this.btnBusTipoClase.ForeColor = System.Drawing.Color.Black;
            this.btnBusTipoClase.Location = new System.Drawing.Point(494, 93);
            this.btnBusTipoClase.Name = "btnBusTipoClase";
            this.btnBusTipoClase.Size = new System.Drawing.Size(30, 23);
            this.btnBusTipoClase.TabIndex = 54;
            this.btnBusTipoClase.Text = "...";
            this.btnBusTipoClase.UseVisualStyleBackColor = true;
            this.btnBusTipoClase.Click += new System.EventHandler(this.btnBusTipoClase_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVistaPrevia.ForeColor = System.Drawing.Color.Black;
            this.btnVistaPrevia.Location = new System.Drawing.Point(593, 184);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(105, 42);
            this.btnVistaPrevia.TabIndex = 53;
            this.btnVistaPrevia.Text = "Vista previa";
            this.btnVistaPrevia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVistaPrevia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // btnCajaDia
            // 
            this.btnCajaDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCajaDia.ForeColor = System.Drawing.Color.Black;
            this.btnCajaDia.Location = new System.Drawing.Point(445, 183);
            this.btnCajaDia.Name = "btnCajaDia";
            this.btnCajaDia.Size = new System.Drawing.Size(105, 42);
            this.btnCajaDia.TabIndex = 52;
            this.btnCajaDia.Text = "Caja del día";
            this.btnCajaDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCajaDia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCajaDia.UseVisualStyleBackColor = true;
            this.btnCajaDia.Click += new System.EventHandler(this.btnCajaDia_Click);
            // 
            // txtBusDetalleMovimiento
            // 
            this.txtBusDetalleMovimiento.Location = new System.Drawing.Point(118, 195);
            this.txtBusDetalleMovimiento.Name = "txtBusDetalleMovimiento";
            this.txtBusDetalleMovimiento.Size = new System.Drawing.Size(131, 20);
            this.txtBusDetalleMovimiento.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Detalle movimiento:";
            // 
            // cbBusNombreClase
            // 
            this.cbBusNombreClase.FormattingEnabled = true;
            this.cbBusNombreClase.Location = new System.Drawing.Point(357, 149);
            this.cbBusNombreClase.Name = "cbBusNombreClase";
            this.cbBusNombreClase.Size = new System.Drawing.Size(131, 21);
            this.cbBusNombreClase.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(268, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Tipo de persona:";
            // 
            // cbBusTipoClase
            // 
            this.cbBusTipoClase.FormattingEnabled = true;
            this.cbBusTipoClase.Location = new System.Drawing.Point(357, 122);
            this.cbBusTipoClase.Name = "cbBusTipoClase";
            this.cbBusTipoClase.Size = new System.Drawing.Size(131, 21);
            this.cbBusTipoClase.TabIndex = 45;
            // 
            // cbBusPuntos
            // 
            this.cbBusPuntos.FormattingEnabled = true;
            this.cbBusPuntos.Location = new System.Drawing.Point(357, 95);
            this.cbBusPuntos.Name = "cbBusPuntos";
            this.cbBusPuntos.Size = new System.Drawing.Size(131, 21);
            this.cbBusPuntos.TabIndex = 44;
            // 
            // cbBusTipoOperaciones
            // 
            this.cbBusTipoOperaciones.FormattingEnabled = true;
            this.cbBusTipoOperaciones.Items.AddRange(new object[] {
            "Caja del día",
            "Ingresos",
            "Egresos",
            "Cuotas Impagas"});
            this.cbBusTipoOperaciones.Location = new System.Drawing.Point(118, 64);
            this.cbBusTipoOperaciones.Name = "cbBusTipoOperaciones";
            this.cbBusTipoOperaciones.Size = new System.Drawing.Size(131, 21);
            this.cbBusTipoOperaciones.TabIndex = 43;
            this.cbBusTipoOperaciones.Text = "Caja del día";
            this.cbBusTipoOperaciones.SelectedValueChanged += new System.EventHandler(this.cbBusTipoOperaciones_SelectedValueChanged);
            // 
            // cbBusTipoPersona
            // 
            this.cbBusTipoPersona.FormattingEnabled = true;
            this.cbBusTipoPersona.Location = new System.Drawing.Point(357, 66);
            this.cbBusTipoPersona.Name = "cbBusTipoPersona";
            this.cbBusTipoPersona.Size = new System.Drawing.Size(131, 21);
            this.cbBusTipoPersona.TabIndex = 42;
            this.cbBusTipoPersona.Text = "Todos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(265, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Nombre de clase:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(281, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tipo de clase:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(317, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Punto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tipo de operación:";
            // 
            // txtBusNombre
            // 
            this.txtBusNombre.Location = new System.Drawing.Point(118, 169);
            this.txtBusNombre.Name = "txtBusNombre";
            this.txtBusNombre.Size = new System.Drawing.Size(131, 20);
            this.txtBusNombre.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(69, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nombre:";
            // 
            // txtBusApellido
            // 
            this.txtBusApellido.Location = new System.Drawing.Point(118, 143);
            this.txtBusApellido.Name = "txtBusApellido";
            this.txtBusApellido.Size = new System.Drawing.Size(131, 20);
            this.txtBusApellido.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Apellido:";
            // 
            // txtBusFechaFin
            // 
            this.txtBusFechaFin.Location = new System.Drawing.Point(118, 117);
            this.txtBusFechaFin.Name = "txtBusFechaFin";
            this.txtBusFechaFin.Size = new System.Drawing.Size(131, 20);
            this.txtBusFechaFin.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha fin:";
            // 
            // txtBusFechaIni
            // 
            this.txtBusFechaIni.Location = new System.Drawing.Point(118, 91);
            this.txtBusFechaIni.Name = "txtBusFechaIni";
            this.txtBusFechaIni.Size = new System.Drawing.Size(131, 20);
            this.txtBusFechaIni.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha inicio:";
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(242, 8);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(113, 16);
            this.lblTituloForm.TabIndex = 57;
            this.lblTituloForm.Text = "Ventana Principal";
            // 
            // txtTotalIngreso
            // 
            this.txtTotalIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIngreso.Location = new System.Drawing.Point(803, 622);
            this.txtTotalIngreso.Name = "txtTotalIngreso";
            this.txtTotalIngreso.Size = new System.Drawing.Size(131, 22);
            this.txtTotalIngreso.TabIndex = 59;
            this.txtTotalIngreso.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(719, 626);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Total Ingreso $:";
            // 
            // txtTotalEgreso
            // 
            this.txtTotalEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEgreso.Location = new System.Drawing.Point(803, 648);
            this.txtTotalEgreso.Name = "txtTotalEgreso";
            this.txtTotalEgreso.Size = new System.Drawing.Size(131, 22);
            this.txtTotalEgreso.TabIndex = 61;
            this.txtTotalEgreso.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(721, 652);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "Total Egreso $:";
            // 
            // txtTotalCaja
            // 
            this.txtTotalCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCaja.ForeColor = System.Drawing.Color.Red;
            this.txtTotalCaja.Location = new System.Drawing.Point(803, 681);
            this.txtTotalCaja.Name = "txtTotalCaja";
            this.txtTotalCaja.Size = new System.Drawing.Size(131, 22);
            this.txtTotalCaja.TabIndex = 63;
            this.txtTotalCaja.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(686, 685);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "Monto Total en Caja $:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(320, 184);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 42);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(225, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 573);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(946, 713);
            this.Controls.Add(this.txtTotalCaja);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotalEgreso);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotalIngreso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.btnBusNombreClase);
            this.Controls.Add(this.btnBusTipoClase);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.btnCajaDia);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusDetalleMovimiento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbBusNombreClase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbBusTipoClase);
            this.Controls.Add(this.cbBusPuntos);
            this.Controls.Add(this.cbBusTipoOperaciones);
            this.Controls.Add(this.cbBusTipoPersona);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBusNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBusApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBusFechaFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusFechaIni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetalleCaja);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCaja)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleCaja;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBmGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirProgramaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBusNombreClase;
        private System.Windows.Forms.Button btnBusTipoClase;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.Button btnCajaDia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusDetalleMovimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbBusNombreClase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbBusTipoClase;
        private System.Windows.Forms.ComboBox cbBusPuntos;
        private System.Windows.Forms.ComboBox cbBusTipoOperaciones;
        private System.Windows.Forms.ComboBox cbBusTipoPersona;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusFechaIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.TextBox txtTotalIngreso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalEgreso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalCaja;
        private System.Windows.Forms.Label label13;
    }
}