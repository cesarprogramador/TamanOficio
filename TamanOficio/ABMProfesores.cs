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
    public partial class ABMProfesores : Form
    {
        ClassPersonas _profesores;
        DataSet _emp;
        string bandera;

        public ABMProfesores()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._profesores.idpersona = "0";
            this._profesores.apellido = this.txtBusApellidos.Text;
            this._profesores.nombre = this.txtBusNombres.Text;
            this._profesores.dni = this.txtBusDni.Text;
            this._profesores.punto = this.cbBusPuntos.Text;
            this._profesores.tipopersona = "Profesor";
            this._profesores.especialidad = this.cbBusEspecialidad.Text;

            this.dgvProfesores.DataSource = this._profesores.BuscarPersonaProfesores(this._profesores, "Empleados");
            this.dgvProfesores.DataMember = "Empleados";

            if (this.dgvProfesores.Rows.Count > 0) this.dgvProfesores.Columns[0].Visible = false;
        }

        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProfesores.Rows.Count > 0)
            {
                this._profesores.idpersona = this.dgvProfesores[0, this.dgvProfesores.CurrentCell.RowIndex].Value.ToString();

                this._emp = this._profesores.BuscarPersonaProfesores(this._profesores, "Empleado");

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
                    this.cbEspecialidad.Text = this._emp.Tables["Empleado"].Rows[0][12].ToString();
                    this.cbPunto.Text = this._emp.Tables["Empleado"].Rows[0][13].ToString();
                    // this.pbxFoto.ImageLocation = this._emp.Tables["Empleado"].Rows[0][15].ToString();
                }

                this.gbxAcciones.Enabled = true;
                this.btnNuevo.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }

        private void ABMProfesores_Load(object sender, EventArgs e)
        {
            this._profesores = new ClassPersonas();

            this._profesores.idpunto = "0";
            this._profesores.nombrepunto = "";

            DataTable _puntos = this._profesores.BuscarPuntos(this._profesores);

            this.cbBusPuntos.DataSource = _puntos;
            this.cbBusPuntos.ValueMember = "idpunto";
            this.cbBusPuntos.DisplayMember = "nombrepunto";

            this.cbPunto.DataSource = _puntos;
            this.cbPunto.ValueMember = "idpunto";
            this.cbPunto.DisplayMember = "nombrepunto";

            this._profesores.idespecialidad = "0";
            this._profesores.especialidad = "";

            DataTable _especialidad = this._profesores.BuscarEspecialidad(this._profesores);

            this.cbBusEspecialidad.DataSource = _especialidad;
            this.cbBusEspecialidad.ValueMember = "idespecialidad";
            this.cbBusEspecialidad.DisplayMember = "especialidad";

            this.cbEspecialidad.DataSource = _especialidad;
            this.cbEspecialidad.ValueMember = "idespecialidad";
            this.cbEspecialidad.DisplayMember = "especialidad";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.bandera = "N";
            this._profesores.idpersona = "0";
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
            this._profesores.idpersona = "0";
            this.gbxAcciones.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.gbxConfirmarAccion.Enabled = false;
            this.gbxBuscador.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._profesores.apellido = this.txtApellido.Text;
            this._profesores.nombre = this.txtNombre.Text;
            this._profesores.fechanac = DateTime.Parse(this.txtFechaNac.Text).ToString("yyyy/MM/dd");
            this._profesores.dni = this.txtDni.Text;
            this._profesores.cuil = this.txtCuil.Text;
            this._profesores.cel = this.txtCel.Text;
            this._profesores.tel = this.txtTel.Text;
            this._profesores.correo = this.txtEmail.Text;
            this._profesores.calle = this.txtCalle.Text;
            this._profesores.numero = this.txtNumero.Text;
            this._profesores.piso = this.txtPiso.Text;
            this._profesores.dpto = this.txtDpto.Text;
            this._profesores.punto = this.cbPunto.Text;
            this._profesores.tipopersona = "Profesor";
            this._profesores.idespecialidad = this.cbEspecialidad.SelectedValue.ToString();
            this._profesores.urlfoto = "...";
            this._profesores.accion = this.bandera;
            this._profesores.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._profesores.idempleadoaccion = 1; //Viene del login
            this._profesores.idpuntoaccion = 1; //Viene del login

            this.dgvProfesores.DataSource = this._profesores.ABMPersona(this._profesores, "accion");
            this.dgvProfesores.DataMember = "accion";

            if (this.dgvProfesores.Rows.Count > 0)
            {
                this.dgvProfesores.Columns[0].Visible = false;
                MessageBox.Show("Acción realizada con exito", "Atención!!!");

                this.btnCancelar_Click(sender, e);
            }
            else
            {
                if (this._profesores.accion == "B")
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
            this.txtBusApellidos.Text = "";
            this.txtBusNombres.Text = "";
            this.txtBusDni.Text = "";
            this.cbBusEspecialidad.Text = "";
            this.cbBusPuntos.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}