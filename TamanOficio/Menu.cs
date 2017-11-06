using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TamanOficio.personas;

namespace TamanOficio
{
    public partial class Menu : Form
    {
        ClassPersonas _loginper;
        string ruta = "";

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this._loginper = new ClassPersonas();

            Login formlogin = new Login();

            formlogin.ShowDialog();

            this._loginper.idpersona = formlogin.idpersona;
            this._loginper.apellido = formlogin.apellido;
            this._loginper.nombre = formlogin.nombre;
            this._loginper.tipopersona = formlogin.tipopersona;
            this._loginper.idpunto = "0";
            this._loginper.punto = formlogin.punto;

            this.lblTituloForm.Text = "Movimientos - Usuario: " + this._loginper.apellido + ", " + this._loginper.nombre + " - Cargo: " + this._loginper.tipopersona;
        }

        private void salirProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Menu_Load(sender, e);
        }

        private void aBMEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEmpleados formempleado = new ABMEmpleados();
            formempleado.Show();
        }

        private void aBMProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProfesores formprofesor = new ABMProfesores();
            formprofesor.Show();
        }

        private void aBMProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProveedores formproveedor = new ABMProveedores();
            formproveedor.Show();
        }

        private void aBMSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMSocios formsocio = new ABMSocios();
            formsocio.Show();
        }
    }
}
