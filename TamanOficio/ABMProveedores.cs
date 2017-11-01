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
    public partial class ABMProveedores : Form
    {
        ClassPersonas _proveedores;
        DataSet _emp;
        string bandera;

        public ABMProveedores()
        {
            InitializeComponent();
        }

        private void ABMProveedores_Load(object sender, EventArgs e)
        {
            this._proveedores = new ClassPersonas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.bandera = "N";
            this._proveedores.idpersona = "0";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.bandera = "M";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.bandera = "B";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.bandera = "";
            this._proveedores.idpersona = "0";
            this.gbxAcciones.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.gbxConfirmarAccion.Enabled = false;
            this.gbxBuscador.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._proveedores.nombre = this.txtNombre.Text;
            this._proveedores.fechanac = DateTime.Now.ToString("yyyy/MM/dd");
            this._proveedores.cuit = this.txtCuit.Text;
            this._proveedores.cel = this.txtCel.Text;
            this._proveedores.tel = this.txtTel.Text;
            this._proveedores.correo = this.txtEmail.Text;
            this._proveedores.calle = this.txtCalle.Text;
            this._proveedores.numero = this.txtNumero.Text;
            this._proveedores.piso = this.txtPiso.Text;
            this._proveedores.dpto = this.txtDpto.Text;
            this._proveedores.apellidocotacto = this.txtApellidoContacto.Text;
            this._proveedores.nombrecontacto = this.txtNombreContacto.Text;
            this._proveedores.celcontacto = this.txtCelContacto.Text;
            this._proveedores.telcontacto = this.txtTelContacto.Text;
            this._proveedores.emailcontacto = this.txtEmailContacto.Text;
            this._proveedores.tipopersona = "Proveedor";
            this._proveedores.idespecialidad = "1";
            
            this._proveedores.accion = this.bandera;
            this._proveedores.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._proveedores.idempleadoaccion = 1; //Viene del login
            this._proveedores.idpuntoaccion = 1; //Viene del login

            this.dgvProveedores.DataSource = this._proveedores.ABMPersona(this._proveedores, "accion");
            this.dgvProveedores.DataMember = "accion";

            if (this.dgvProveedores.Rows.Count > 0)
            {
                this.dgvProveedores.Columns[0].Visible = false;
                MessageBox.Show("Acción realizada con exito", "Atención!!!");

                this.btnCancelar_Click(sender, e);
            }
            else
            {
                if (this._proveedores.accion == "B")
                {
                    MessageBox.Show("Acción realizada con exito", "Atención!!!");

                    this.btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error en la ejecución de la acción en curso. Controle datos!!!", "Error!!!");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBusNombres.Text = "";
            this.txtBusCuit.Text = "";
            this.txtBusApellidoContacto.Text = "";
            this.txtBusNombreContacto.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._proveedores.idpersona = "0";
            this._proveedores.nombre = this.txtBusNombres.Text;
            this._proveedores.cuit = this.txtBusCuit.Text;
            this._proveedores.apellidocotacto = this.txtBusApellidoContacto.Text;
            this._proveedores.tipopersona = "Proveedor";
            this._proveedores.nombrecontacto = this.txtBusNombreContacto.Text;

            this.dgvProveedores.DataSource = this._proveedores.BuscarPersonaProveedores(this._proveedores, "Proveedor");
            this.dgvProveedores.DataMember = "Proveedor";

            if (this.dgvProveedores.Rows.Count > 0) this.dgvProveedores.Columns[0].Visible = false;
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProveedores.Rows.Count > 0)
            {
                this._proveedores.idpersona = this.dgvProveedores[0, this.dgvProveedores.CurrentCell.RowIndex].Value.ToString();

                this._emp = this._proveedores.BuscarPersonaProveedores(this._proveedores, "Proveedor");

                if (this._emp.Tables["Proveedor"].Rows.Count > 0)
                {
                    this.txtNombre.Text = this._emp.Tables["Proveedor"].Rows[0][0].ToString();
                    this.txtCuit.Text = this._emp.Tables["Proveedor"].Rows[0][1].ToString();
                    this.txtCel.Text = this._emp.Tables["Proveedor"].Rows[0][2].ToString();
                    this.txtTel.Text = this._emp.Tables["Proveedor"].Rows[0][3].ToString();
                    this.txtEmail.Text = this._emp.Tables["Proveedor"].Rows[0][4].ToString();
                    this.txtCalle.Text = this._emp.Tables["Proveedor"].Rows[0][5].ToString();
                    this.txtNumero.Text = this._emp.Tables["Proveedor"].Rows[0][6].ToString();
                    this.txtPiso.Text = this._emp.Tables["Proveedor"].Rows[0][7].ToString();
                    this.txtDpto.Text = this._emp.Tables["Proveedor"].Rows[0][8].ToString();

                    this.txtApellidoContacto.Text = this._emp.Tables["Proveedor"].Rows[0][9].ToString();
                    this.txtNombreContacto.Text = this._emp.Tables["Proveedor"].Rows[0][10].ToString();
                    this.txtCelContacto.Text = this._emp.Tables["Proveedor"].Rows[0][11].ToString();
                    this.txtTelContacto.Text = this._emp.Tables["Proveedor"].Rows[0][12].ToString();
                    this.txtEmailContacto.Text = this._emp.Tables["Proveedor"].Rows[0][13].ToString();
                }

                this.gbxAcciones.Enabled = true;
                this.btnNuevo.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
