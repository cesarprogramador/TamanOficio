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
    public partial class ABMInscripcionCursos : Form
    {
        public string _idcurso = "0";
        string _idcuota = "0";
        public string _dni = "0";
        public string _idpunto = "0";
        public string _punto = "";
        public string _bandera = "";
        ClassCursos _cursos;
        DataSet _resp;
       
        public ABMInscripcionCursos()
        {
            InitializeComponent();
        }

        private void ABMInscripcionCursos_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtDni.Text = _dni;
                this.txtPunto.Text = _punto;
                //Cargar Tipo de clase
                this._cursos = new ClassCursos();
                this._cursos.idtipodeclase = "0";
                this._cursos.tipodeclase = "";
                this._cursos.idpunto = this._idpunto;
                this.cbTipoClase.DataSource = this._cursos.BuscarTiposDeClases(this._cursos);
                this.cbTipoClase.ValueMember = "idtipodeclase";
                this.cbTipoClase.DisplayMember = "tipodeclase";
                this.txtFechaPago.Text = DateTime.Now.ToString("dd/MM/yyyy");

                if ((this._bandera == "M") || (this._bandera == "B"))
                {
                    this._resp = new DataSet();
                    this._resp = this._cursos.BuscarInscripcionesCursosSocios(this._idcurso, this._dni, "Inscripciones");

                    this.txtDni.Text = this._resp.Tables["Inscripciones"].Rows[0][1].ToString();
                    this.txtPunto.Text = this._resp.Tables["Inscripciones"].Rows[0][2].ToString();
                    this.cbTipoClase.Text = this._resp.Tables["Inscripciones"].Rows[0][3].ToString();
                    this.btnBusClases_Click(sender, e);
                    this.cbNombreClase.Text = this._resp.Tables["Inscripciones"].Rows[0][4].ToString();
                    this.txtMontoCuota.Text = this._resp.Tables["Inscripciones"].Rows[0][5].ToString();
                    this._idcuota = this._resp.Tables["Inscripciones"].Rows[0][6].ToString();
                    this.txtFechaPago.Text = DateTime.Parse(this._resp.Tables["Inscripciones"].Rows[0][7].ToString()).ToString("dd/MM/yyyy");
                }
            }
            catch (Exception err)
            {
            }
        }

        private void btnBusClases_Click(object sender, EventArgs e)
        {
            try
            {
                this.cbNombreClase.Enabled = true;

                this._cursos.idclase = "0";
                this._cursos.idtipodeclase = this.cbTipoClase.SelectedValue.ToString();
                this._cursos.tipodeclase = "";

                this.cbNombreClase.DataSource = this._cursos.BuscarNombresDeClases(this._cursos);
                this.cbNombreClase.ValueMember = "idclase";
                this.cbNombreClase.DisplayMember = "nombreclase";
            }
            catch (Exception err)
            {
                this.cbNombreClase.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._cursos.idcuota = this._idcuota;
            this._cursos.idcurso = this._idcurso;
            this._cursos.idclase = this.cbNombreClase.SelectedValue.ToString();
            this._cursos.dni = _dni;
            this._cursos.montocuota = Decimal.Parse(this.txtMontoCuota.Text);
            this._cursos.montopagado = 0;
            this._cursos.montosaldo = 0;
            this._cursos.idpunto = _idpunto;
            this._cursos.accion = this._bandera;
            this._cursos.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._cursos.idempleadoaccion = 1; //Viene del login
            this._cursos.idpuntoaccion = 1; //Viene del login
            this._cursos.fechapago = DateTime.Parse(this.txtFechaPago.Text).ToString("yyyy/MM/dd");

            this._resp = new DataSet();
            this._resp = this._cursos.ABMInscripcion(this._cursos, "accion");

            if (this._resp.Tables["accion"].Rows.Count < 0)
            {
                MessageBox.Show("Error en la ejecución de la acción en curso. Controle datos!!!", "Error!!!");
            }
            else
            {
                MessageBox.Show("Acción realizada!!!", "Atención!!!");

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}