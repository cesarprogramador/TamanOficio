using TamanOficio.personas;
using TamanOficio.tiposdeclase;
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
    public partial class ABMSocios : Form
    {
        ClassPersonas _socios;
        ClassCursos _cursos;
        DataSet _socio;
        string bandera;

        public ABMSocios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._socios.idpersona = "0";
            this._socios.apellido = this.txtBusApellidos.Text;
            this._socios.nombre = this.txtBusNombres.Text;
            this._socios.dni = this.txtBusDni.Text;
            this._socios.punto = this.cbBusPuntos.Text;
            this._socios.tipopersona = "Socio";
            // this._socios.especialidad = this.cbBusEspecialidad.Text;

            this.dgvSocios.DataSource = this._socios.BuscarPersonaSocios(this._socios, "Socios");
            this.dgvSocios.DataMember = "Socios";

            if (this.dgvSocios.Rows.Count > 0) this.dgvSocios.Columns[0].Visible = false;
        }

        private void ABMSocios_Load(object sender, EventArgs e)
        {
            this._socios = new ClassPersonas();
            this._cursos = new ClassCursos();

            this._socios.idpunto = "0";
            this._socios.nombrepunto = "";

            DataTable _puntos = this._socios.BuscarPuntos(this._socios);

            this.cbBusPuntos.DataSource = _puntos;
            this.cbBusPuntos.ValueMember = "idpunto";
            this.cbBusPuntos.DisplayMember = "nombrepunto";

            this.cbPuntos.DataSource = _puntos;
            this.cbPuntos.ValueMember = "idpunto";
            this.cbPuntos.DisplayMember = "nombrepunto";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.bandera = "N";
            this._socios.idpersona = "0";
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
            this.gbxDetalleCursos.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.bandera = "B";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
            this.gbxDetalleCursos.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.bandera = "";
            this._socios.idpersona = "0";
            this.gbxAcciones.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnPagarCuota.Enabled = false;
            this.gbxConfirmarAccion.Enabled = false;
            this.gbxBuscador.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._socios.apellido = this.txtApellido.Text;
            this._socios.nombre = this.txtNombre.Text;
            this._socios.fechanac = DateTime.Parse(this.txtFechaNac.Text).ToString("yyyy/MM/dd");
            this._socios.dni = this.txtDni.Text;
            this._socios.cuil = this.txtCuil.Text;
            this._socios.cel = this.txtCel.Text;
            this._socios.tel = this.txtTel.Text;
            this._socios.correo = this.txtEmail.Text;
            this._socios.calle = this.txtCalle.Text;
            this._socios.numero = this.txtNumero.Text;
            this._socios.piso = this.txtPiso.Text;
            this._socios.dpto = this.txtDpto.Text;
            this._socios.punto = this.cbPuntos.Text;
            this._socios.tipopersona = "Socio";
            //  this._socios.especialidad = this.cbEspecialidad.Text;
            this._socios.urlfoto = "...";
            this._socios.accion = this.bandera;
            this._socios.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._socios.idempleadoaccion = 1; //Viene del login
            this._socios.idpuntoaccion = 1; //Viene del login
            this._socios.idespecialidad = "1";

            this.dgvSocios.DataSource = this._socios.ABMPersona(this._socios, "accion");
            this.dgvSocios.DataMember = "accion";

            if (this.dgvSocios.Rows.Count > 0)
            {
                this.dgvSocios.Columns[0].Visible = false;
                MessageBox.Show("Acción realizada con exito. Indicar ahora a los cursos en los que se inscribira!!!", "Atención!!!");

                this.gbxDetalleCursos.Enabled = true;

                this.btnModificarInsc.Enabled = false;
                this.btnEliminarInsc.Enabled = false;

                this.btnCancelar_Click(sender, e);
            }
            else
            {
                if (this.dgvSocios.Rows.Count == 0 && (this.bandera=="B"))
                {
                    this.dgvSocios.Columns[0].Visible = false;
                    MessageBox.Show("Acción realizada con exito!!!", "Atención!!!");

                    this.gbxDetalleCursos.Enabled = true;

                    this.btnModificarInsc.Enabled = false;
                    this.btnEliminarInsc.Enabled = false;

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
            //this.cbBusEspecialidad.Text = "";
            this.cbBusPuntos.Text = "";
        }

        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvSocios.Rows.Count > 0)
                {
                    this._socios.idpersona = this.dgvSocios[0, this.dgvSocios.CurrentCell.RowIndex].Value.ToString();

                    this._socio = this._socios.BuscarPersonaSocios(this._socios, "Socio");

                    if (this._socio.Tables["Socio"].Rows.Count > 0)
                    {
                        this.txtApellido.Text = this._socio.Tables["Socio"].Rows[0][0].ToString();
                        this.txtNombre.Text = this._socio.Tables["Socio"].Rows[0][1].ToString();
                        this.txtFechaNac.Text = DateTime.Parse(this._socio.Tables["Socio"].Rows[0][2].ToString()).ToString("dd/MM/yyyy");
                        this.txtDni.Text = this._socio.Tables["Socio"].Rows[0][3].ToString();
                        this.txtCuil.Text = this._socio.Tables["Socio"].Rows[0][4].ToString();
                        this.txtCel.Text = this._socio.Tables["Socio"].Rows[0][5].ToString();
                        this.txtTel.Text = this._socio.Tables["Socio"].Rows[0][6].ToString();
                        this.txtEmail.Text = this._socio.Tables["Socio"].Rows[0][7].ToString();
                        this.txtCalle.Text = this._socio.Tables["Socio"].Rows[0][8].ToString();
                        this.txtNumero.Text = this._socio.Tables["Socio"].Rows[0][9].ToString();
                        this.txtPiso.Text = this._socio.Tables["Socio"].Rows[0][10].ToString();
                        this.txtDpto.Text = this._socio.Tables["Socio"].Rows[0][11].ToString();
                        //this.cbEspecialidad.Text = this._socio.Tables["Socio"].Rows[0][12].ToString();
                        this.cbPuntos.Text = this._socio.Tables["Socio"].Rows[0][13].ToString();
                        // this.pbxFoto.ImageLocation = this._socio.Tables["Socio"].Rows[0][2].ToString();

                        this.dgvCursos.DataSource = this._cursos.BuscarInscripcionesCursosSocios("0", this.txtDni.Text, "Inscripciones");
                        this.dgvCursos.DataMember = "Inscripciones";
                        
                        this.btnNuevoInsc.Enabled = true;

                        if (this.dgvCursos.Rows.Count > 0)
                        {//Si presenta inscripciones a cursos
                            this.dgvCursos.Columns[0].Visible = false;
                            this.dgvCursos.Columns[5].Visible = false;
                            this.dgvCursos.Columns[6].Visible = false;
                            this.btnModificarInsc.Enabled = true;
                            this.btnEliminarInsc.Enabled = true;
                            this.gbxDetalleCursos.Enabled = true;
                        }
                        else
                        {//No presenta inscripciones a cursos
                            this.btnModificarInsc.Enabled = false;
                            this.btnEliminarInsc.Enabled = false;
                            this.btnPagarCuota.Enabled = false;
                        }
                    }

                    this.gbxAcciones.Enabled = true;
                    this.btnNuevo.Enabled = true;
                    this.btnModificar.Enabled = true;
                    this.btnEliminar.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnNuevoInsc_Click(object sender, EventArgs e)
        {
            ABMInscripcionCursos ABMInsc = new ABMInscripcionCursos();

            ABMInsc._idcurso = "0";
            ABMInsc._dni = this.txtDni.Text;
            ABMInsc._idpunto = this.cbPuntos.SelectedValue.ToString();
            ABMInsc._punto = this.cbPuntos.Text;
            ABMInsc._bandera = "N";

            ABMInsc.ShowDialog();

            this.dgvCursos.DataSource = this._cursos.BuscarInscripcionesCursosSocios("0", this.txtDni.Text, "Inscripciones");
            this.dgvCursos.DataMember = "Inscripciones";

            if (this.dgvCursos.Rows.Count > 0) this.dgvCursos.Columns[0].Visible = false;
        }

        private void btnModificarInsc_Click(object sender, EventArgs e)
        {
            ABMInscripcionCursos ABMInsc = new ABMInscripcionCursos();

            ABMInsc._idcurso = this.dgvCursos[0, this.dgvCursos.CurrentCell.RowIndex].Value.ToString();
            ABMInsc._idpunto = this.cbPuntos.SelectedValue.ToString();
            ABMInsc._punto = this.cbPuntos.Text;
            ABMInsc._bandera = "M";

            ABMInsc.ShowDialog();

            this.dgvCursos.DataSource = this._cursos.BuscarInscripcionesCursosSocios("0", this.txtDni.Text, "Inscripciones");
            this.dgvCursos.DataMember = "Inscripciones";

            if (this.dgvCursos.Rows.Count > 0) this.dgvCursos.Columns[0].Visible = false;
        }

        private void btnEliminarInsc_Click(object sender, EventArgs e)
        {
            ABMInscripcionCursos ABMInsc = new ABMInscripcionCursos();

            ABMInsc._idcurso = this.dgvCursos[0, this.dgvCursos.CurrentCell.RowIndex].Value.ToString();
            ABMInsc._idpunto = this.cbPuntos.SelectedValue.ToString();
            ABMInsc._punto = this.cbPuntos.Text;
            ABMInsc._bandera = "B";

            ABMInsc.ShowDialog();

            this.dgvCursos.DataSource = this._cursos.BuscarInscripcionesCursosSocios("0", this.txtDni.Text, "Inscripciones");
            this.dgvCursos.DataMember = "Inscripciones";

            if (this.dgvCursos.Rows.Count > 0) this.dgvCursos.Columns[0].Visible = false;
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCursos.Rows.Count > 0)
            {
                this.btnModificarInsc.Enabled = true;
                this.btnEliminarInsc.Enabled = true;
                this.btnPagarCuota.Enabled = true;
            }
            else
            {
                this.btnModificarInsc.Enabled = false;
                this.btnEliminarInsc.Enabled = false;
                this.btnPagarCuota.Enabled = false;
            }
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            try
            {
                ABMCuotas _cuotas = new ABMCuotas();

                _cuotas._idcurso = this.dgvCursos[0, this.dgvCursos.CurrentCell.RowIndex].Value.ToString();
                _cuotas.ShowDialog();

                this.dgvCursos.DataSource = this._cursos.BuscarInscripcionesCursosSocios("0", this.txtDni.Text, "Inscripciones");
                this.dgvCursos.DataMember = "Inscripciones";

                if (this.dgvCursos.Rows.Count > 0)
                {
                    this.dgvCursos.Columns[0].Visible = false;
                    this.gbxDetalleCursos.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Tiene que seleccionar un curso sobre el cual se cobrar la cuota al alumno!!!", "Falta");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}