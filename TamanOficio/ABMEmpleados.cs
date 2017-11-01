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
    public partial class ABMEmpleados : Form
    {
        ClassPersonas _empleado;
        DataSet _emp;
        string bandera;

        public ABMEmpleados()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._empleado.idpersona = "0";
            this._empleado.apellido = this.txtBusApellidos.Text;
            this._empleado.nombre = this.txtBusNombres.Text;
            this._empleado.dni = this.txtBusDni.Text;
            this._empleado.punto = this.cbBusPuntos.Text;
            this._empleado.tipopersona = this.cbBusEmpleadoTipo.Text;

            this.dgvEmpleados.DataSource = this._empleado.BuscarPersonaEmpleados(this._empleado, "Empleados");
            this.dgvEmpleados.DataMember = "Empleados";

            if (this.dgvEmpleados.Rows.Count > 0) this.dgvEmpleados.Columns[0].Visible = false;
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvEmpleados.Rows.Count > 0)
            {
                this._empleado.idpersona = this.dgvEmpleados[0, this.dgvEmpleados.CurrentCell.RowIndex].Value.ToString();

                this._emp = this._empleado.BuscarPersonaEmpleados(this._empleado, "Empleado");

                if (this._emp.Tables["Empleado"].Rows.Count > 0)
                {
                    this.txtApellido.Text = this._emp.Tables["Empleado"].Rows[0][0].ToString();
                    this.txtNombre.Text = this._emp.Tables["Empleado"].Rows[0][1].ToString();
                    this.txtFechaNac.Text = DateTime.Parse(this._emp.Tables["Empleado"].Rows[0][2].ToString()).ToString("dd/MM/yyyy");
                    this.txtDni.Text = this._emp.Tables["Empleado"].Rows[0][3].ToString();
                    this.txtCuil.Text = this._emp.Tables["Empleado"].Rows[0][4].ToString();
                    this.txtCel.Text = this._emp.Tables["Empleado"].Rows[0][5].ToString();
                    this.txtTel.Text = this._emp.Tables["Empleado"].Rows[0][6].ToString();
                    this.txtEmail.Text = this._emp.Tables["Empleado"].Rows[0][7].ToString();
                    this.txtCalle.Text = this._emp.Tables["Empleado"].Rows[0][8].ToString();
                    this.txtNumero.Text = this._emp.Tables["Empleado"].Rows[0][9].ToString();
                    this.txtPiso.Text = this._emp.Tables["Empleado"].Rows[0][10].ToString();
                    this.txtDpto.Text = this._emp.Tables["Empleado"].Rows[0][11].ToString();
                    this.cbTipoEmpleado.Text = this._emp.Tables["Empleado"].Rows[0][12].ToString();
                    this.cbPunto.Text = this._emp.Tables["Empleado"].Rows[0][13].ToString();
                    // this.pbxFoto.ImageLocation = this._emp.Tables["Empleado"].Rows[0][2].ToString();
                }

                this.gbxAcciones.Enabled = true;
                this.btnNuevo.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }

        private void ABMEmpleados_Load(object sender, EventArgs e)
        {
            this._empleado = new ClassPersonas();

            this._empleado.idpunto = "0";
            this._empleado.nombrepunto = "";

            DataTable _puntos = this._empleado.BuscarPuntos(this._empleado);

            this.cbBusPuntos.DataSource = _puntos;
            this.cbBusPuntos.ValueMember = "idpunto";
            this.cbBusPuntos.DisplayMember = "nombrepunto";

            this.cbPunto.DataSource = _puntos;
            this.cbPunto.ValueMember = "idpunto";
            this.cbPunto.DisplayMember = "nombrepunto";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.bandera = "N";
            this._empleado.idpersona = "0";
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
            this._empleado.idpersona = "0";
            this.gbxAcciones.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.gbxConfirmarAccion.Enabled = false;
            this.gbxBuscador.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._empleado.apellido = this.txtApellido.Text;
            this._empleado.nombre = this.txtNombre.Text;
            this._empleado.fechanac = DateTime.Parse(this.txtFechaNac.Text).ToString("yyyy/MM/dd");
            this._empleado.dni = this.txtDni.Text;
            this._empleado.cuil = this.txtCuil.Text;
            this._empleado.cel = this.txtCel.Text;
            this._empleado.tel = this.txtTel.Text;
            this._empleado.correo = this.txtEmail.Text;
            this._empleado.calle = this.txtCalle.Text;
            this._empleado.numero = this.txtNumero.Text;
            this._empleado.piso = this.txtPiso.Text;
            this._empleado.dpto = this.txtDpto.Text;
            this._empleado.punto = this.cbPunto.Text;
            this._empleado.tipopersona = this.cbTipoEmpleado.Text;
            this._empleado.urlfoto = "...";
            this._empleado.accion = this.bandera;
            this._empleado.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._empleado.idempleadoaccion = 1; //Viene del login
            this._empleado.idpuntoaccion = 1; //Viene del login
            this._empleado.idespecialidad = "1";

            this.dgvEmpleados.DataSource = this._empleado.ABMPersona(this._empleado, "accion");
            this.dgvEmpleados.DataMember = "accion";

            if (this.dgvEmpleados.Rows.Count > 0)
            {
                this.dgvEmpleados.Columns[0].Visible = false;
                MessageBox.Show("Acción realizada con exito", "Atención!!!");

                this.btnCancelar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error en la ejecución de la acción en curso. Controle datos!!!", "Error!!!");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBusApellidos.Text = "";
            this.txtBusNombres.Text = "";
            this.txtBusDni.Text = "";
            this.cbBusEmpleadoTipo.Text = "";
            this.cbBusPuntos.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
