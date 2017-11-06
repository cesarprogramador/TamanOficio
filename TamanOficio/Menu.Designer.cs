namespace TamanOficio
{
    partial class Menu
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
            this.lblTituloForm = new System.Windows.Forms.Label();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(199, 9);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(113, 16);
            this.lblTituloForm.TabIndex = 58;
            this.lblTituloForm.Text = "Ventana Principal";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.aBMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(205, 24);
            this.menuStrip1.TabIndex = 59;
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
            this.aBMSociosToolStripMenuItem});
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(758, 262);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblTituloForm);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMSociosToolStripMenuItem;
    }
}