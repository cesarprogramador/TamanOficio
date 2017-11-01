using TamanOficio.personas;
using TamanOficio.gastos;
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
    public partial class ABMGastos : Form
    {
        ClassPersonas _proveedores;
        ClassGastos _gastos;
        DataSet _Gastos;
        string bandera;

        public ABMGastos()
        {
            InitializeComponent();
        }

        private void ABMGastos_Load(object sender, EventArgs e)
        {
            this._gastos = new ClassGastos();
            
            this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;

            this._proveedores = new ClassPersonas();

            this._proveedores.idpunto = "0";
            this._proveedores.nombrepunto = "";

            DataTable _puntos = this._proveedores.BuscarPuntos(this._proveedores);

            this.cbBusPuntos.DataSource = _puntos;
            this.cbBusPuntos.ValueMember = "idpunto";
            this.cbBusPuntos.DisplayMember = "nombrepunto";

            this.cbPuntos.DataSource = _puntos;
            this.cbPuntos.ValueMember = "idpunto";
            this.cbPuntos.DisplayMember = "nombrepunto";

            this._proveedores.idpersona = "0";
            this._proveedores.nombre = "";

            DataTable _proveedor = this._proveedores.BuscarPersonaProveedores(this._proveedores);

            this.cbBusProveedor.DataSource = _proveedor;
            this.cbBusProveedor.ValueMember = "idpersona";
            this.cbBusProveedor.DisplayMember = "Nombre";

            this.cbProveedor.DataSource = _proveedor;
            this.cbProveedor.ValueMember = "idpersona";
            this.cbProveedor.DisplayMember = "Nombre";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;
            this.cbBusProveedor.Text = "";
            this.cbBusPuntos.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._gastos.idgasto = "0";
            this._gastos.fechainigasto = DateTime.Parse(this.txtBusFechaIni.Text).ToString("yyyy/MM/dd");
            this._gastos.fechafingasto = DateTime.Parse(this.txtBusFechaFin.Text).ToString("yyyy/MM/dd"); 
            this._gastos.nombreproveedor = this.cbBusProveedor.Text;
            this._gastos.nombrepunto = this.cbBusPuntos.Text;
            
            this.dgvGastos.DataSource = this._gastos.BuscarGastos(this._gastos, "Gastos");
            this.dgvGastos.DataMember = "Gastos";

            if (this.dgvGastos.Rows.Count > 0) this.dgvGastos.Columns[0].Visible = false;
        }

        private void dgvGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvGastos.Rows.Count > 0)
                {
                    this._gastos.idgasto = this.dgvGastos[0, this.dgvGastos.CurrentCell.RowIndex].Value.ToString();

                    this._Gastos = new DataSet();
                    
                    this._Gastos = this._gastos.BuscarGastos(this._gastos, "Gasto");

                    if (this._Gastos.Tables["Gasto"].Rows.Count > 0)
                    {
                        this.txtFechaCarga.Text = this._Gastos.Tables["Gasto"].Rows[0][1].ToString();
                        this.txtFechaFactura.Text = this._Gastos.Tables["Gasto"].Rows[0][2].ToString();
                        this.cbFactura.Text = this._Gastos.Tables["Gasto"].Rows[0][3].ToString();
                        this.txtNumFactura.Text = this._Gastos.Tables["Gasto"].Rows[0][4].ToString();
                        this.cbProveedor.Text = this._Gastos.Tables["Gasto"].Rows[0][5].ToString();
                        this.cbPuntos.Text = this._Gastos.Tables["Gasto"].Rows[0][6].ToString();
                        this.txtMontoPagado.Text = this._Gastos.Tables["Gasto"].Rows[0][7].ToString();
                        this.txtObservacion.Text = this._Gastos.Tables["Gasto"].Rows[0][8].ToString();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.bandera = "N";
            this._gastos.idgasto = "0";
            this.txtFechaCarga.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            this.txtFechaCarga.Enabled = false;

            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.bandera = "M";
            this.txtFechaCarga.Enabled = false;
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
            this._gastos.idgasto = "0";
            this.gbxAcciones.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.gbxConfirmarAccion.Enabled = false;
            this.gbxBuscador.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._gastos.fecharealcarga = DateTime.Parse(this.txtFechaCarga.Text).ToString("yyyy/MM/dd hh:mm:ss");
            this._gastos.fechagasto = DateTime.Parse(this.txtFechaFactura.Text).ToString("yyyy/MM/dd");
            this._gastos.tipofactura = this.cbFactura.Text;
            this._gastos.numerofactura = this.txtNumFactura.Text;
            this._gastos.idproveedor = this.cbProveedor.SelectedValue.ToString();
            this._gastos.idpunto = this.cbPuntos.SelectedValue.ToString();
            this._gastos.montopagado = Decimal.Parse(this.txtMontoPagado.Text);
            this._gastos.observacion = this.txtObservacion.Text;
                        
            this._gastos.accion = this.bandera;
            this._gastos.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._gastos.idempleadoaccion = 1; //Viene del login
            this._gastos.idpuntoaccion = 1; //Viene del login

            this.dgvGastos.DataSource = this._gastos.ABMGasto(this._gastos, "accion");
            this.dgvGastos.DataMember = "accion";

            if (this.dgvGastos.Rows.Count > 0)
            {
                this.dgvGastos.Columns[0].Visible = false;
                MessageBox.Show("Acción realizada con exito", "Atención!!!");

                this.btnCancelar_Click(sender, e);
            }
            else
            {
                if (this._gastos.accion == "B")
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
    }
}
