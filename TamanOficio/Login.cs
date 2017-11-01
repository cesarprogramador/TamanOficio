using TamanOficio.personas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamanOficio
{
    public partial class Login : Form
    {
        DataSet _emp;
        ClassPersonas _login;
        public string idpersona = "0";
        public string apellido = "";
        public string nombre = "";
        public string tipopersona = "";
        public string punto = "";
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.idpersona=="0") Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((this.txtUsuario.Text.Length > 0) && (this.txtPassword.Text.Length > 0))
            {
                this._login = new ClassPersonas();

                this._emp = new DataSet();

                this._emp = this._login.LoginPersona(this.txtUsuario.Text,this.txtPassword.Text, "Login");

                if (this._emp.Tables["Login"].Rows.Count > 0)
                {
                    this.idpersona = this._emp.Tables["Login"].Rows[0][0].ToString();
                    this.apellido = this._emp.Tables["Login"].Rows[0][1].ToString();
                    this.nombre = this._emp.Tables["Login"].Rows[0][2].ToString();
                    this.tipopersona = this._emp.Tables["Login"].Rows[0][3].ToString();
                    this.punto = this._emp.Tables["Login"].Rows[0][4].ToString();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Los datos no se corresponde con ningún usuario!!!");
                }
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== 13) this.btnIngresar_Click(sender,e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) this.btnIngresar_Click(sender, e);
        }
    }
}
