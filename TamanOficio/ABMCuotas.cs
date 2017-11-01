using TamanOficio.tiposdeclase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamanOficio
{
    public partial class ABMCuotas : Form
    {
        public string _idcurso = "";
        ClassCursos _inscrialu;
        DataSet _cuotas;
        decimal _deuda = 0;
        StreamWriter arch;
        string ruta = "";

        public ABMCuotas()
        {
            InitializeComponent();
        }

        private void ABMCuotas_Load(object sender, EventArgs e)
        {
            this._inscrialu = new ClassCursos();

            this._cuotas = this._inscrialu.BuscarDatosSocioInscripto(this._idcurso, "S", "Socio");

            if (this._cuotas.Tables["Socio"].Rows.Count > 0)
            {
                this.txtApellido.Text = this._cuotas.Tables["Socio"].Rows[0][0].ToString();
                this.txtNombre.Text = this._cuotas.Tables["Socio"].Rows[0][1].ToString();
                this.txtDni.Text = this._cuotas.Tables["Socio"].Rows[0][2].ToString();
                this.txtEmail.Text = this._cuotas.Tables["Socio"].Rows[0][3].ToString();
                this.txtPunto.Text = this._cuotas.Tables["Socio"].Rows[0][4].ToString();
                this.txtTipoClase.Text = this._cuotas.Tables["Socio"].Rows[0][5].ToString();
                this.txtNombreClase.Text = this._cuotas.Tables["Socio"].Rows[0][6].ToString();
                this.txtMontoCuotaTotal.Text = this._cuotas.Tables["Socio"].Rows[0][7].ToString();

                this.dgvHistorialCuotas.DataSource = this._inscrialu.BuscarDatosSocioInscripto(this._idcurso, "C", "CuotasSocio");
                this.dgvHistorialCuotas.DataMember = "CuotasSocio";

                if (this.dgvHistorialCuotas.Rows.Count > 0)
                {
                    //Idcurso
                    this.dgvHistorialCuotas.Columns[0].Visible = false;
                    //Fecha real pago
                    this.dgvHistorialCuotas.Columns[2].Visible = false;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._inscrialu.idcuota = this.dgvHistorialCuotas[0, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();
            this._inscrialu.numcuota = int.Parse(this.dgvHistorialCuotas[1, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString()) + 1;
            this._inscrialu.idcurso = this._idcurso;
            this._inscrialu.fecharealpago = DateTime.Now.ToString("yyyy/MM/dd");
            this._inscrialu.fechaproximopago = DateTime.Parse(this.txtFechaPago.Text).AddMonths(1).ToString("yyyy/MM/dd");
            this._inscrialu.montocuota = Decimal.Parse(this.txtMontoCuota.Text);
            this._inscrialu.montopagado = Decimal.Parse(this.txtAlumnoPaga.Text);
            this._inscrialu.montosaldo = Decimal.Parse(this.txtMontoDeuda.Text);

            this._inscrialu.accion = "N";
            this._inscrialu.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._inscrialu.idempleadoaccion = 1; //Viene del login
            this._inscrialu.idpuntoaccion = 1; //Viene del login

            this.dgvHistorialCuotas.DataSource = this._inscrialu.ABMCuotasSocios(this._inscrialu, "CuotasSocio");
            this.dgvHistorialCuotas.DataMember = "CuotasSocio";

            if (this.dgvHistorialCuotas.Rows.Count > 0)
            {
                //Idcurso
                this.dgvHistorialCuotas.Columns[0].Visible = false;
                //Fecha real pago
                this.dgvHistorialCuotas.Columns[2].Visible = false;

                MessageBox.Show("Acción realizada con exito!!!", "Atención!!!");
            }
        }

        private void txtAlumnoPaga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this._deuda = decimal.Parse(this.txtDebePagar.Text) - decimal.Parse(this.txtAlumnoPaga.Text);
                this.txtMontoDeuda.Text = this._deuda.ToString();
                this.btnAceptar.Enabled = true;
                this.btnAceptar.Focus();
            }
        }

        private void dgvHistorialCuotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvHistorialCuotas.Rows.Count > 0)
            {
                this.txtNumCuota.Text = "Cuota Nº" + this.dgvHistorialCuotas[1, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();
                this.txtFechaPago.Text = DateTime.Parse(this.dgvHistorialCuotas[2, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString()).ToString("dd/MM/yyyy");
                this.txtFechaRealPago.Text = this.dgvHistorialCuotas[3, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();
                this.txtMontoCuota.Text = this.dgvHistorialCuotas[4, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();
                this.txtAlumnoPaga.Text = this.dgvHistorialCuotas[5, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();
                this.txtMontoSaldo.Text = this.dgvHistorialCuotas[6, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();

                if (this.txtAlumnoPaga.Text.Length <= 0) this.txtAlumnoPaga.Text = "0.00";

                this._deuda = decimal.Parse(this.txtMontoCuota.Text) + decimal.Parse(this.txtMontoSaldo.Text);
                this.txtDebePagar.Text = this._deuda.ToString();

                this._deuda = decimal.Parse(this.txtDebePagar.Text) - decimal.Parse(this.txtAlumnoPaga.Text);
                this.txtMontoDeuda.Text = this._deuda.ToString();

                this.btnAceptar.Enabled = true;
            }
        }

        private void txtMontoCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this._deuda = decimal.Parse(this.txtMontoCuota.Text) + decimal.Parse(this.txtMontoSaldo.Text);
                this.txtDebePagar.Text = this._deuda.ToString();
                this.txtAlumnoPaga.Focus();
            }
        }

        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvHistorialCuotas.Rows.Count > 0)
                {
                    this.ruta = Path.GetFullPath("comprobante.html");

                    this.arch = new StreamWriter(this.ruta);

                    this.arch.WriteLine("<!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.01 Transitional//EN' 'http://www.w3.org/TR/html4/loose.dtd'>");
                    this.arch.WriteLine("<html>");
                    this.arch.WriteLine("<head>");
                    this.arch.WriteLine("<title>Comprobante Pago de Cuota</title>");
                    this.arch.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=iso-8859-1'>");
                    this.arch.WriteLine("<style type='text/css'>");
                    this.arch.WriteLine("<!--");
                    this.arch.WriteLine(".Estilo7 {");
                    this.arch.WriteLine("font-size: 10px;");
                    this.arch.WriteLine("font-weight: bold;");
                    this.arch.WriteLine("}");
                    this.arch.WriteLine(".Estilo8 {font-size: 10px}");
                    this.arch.WriteLine(".Estilo10 {font-size: 12px}");
                    this.arch.WriteLine(".Estilo11 {font-size: 12px; font-weight: bold; }");
                    this.arch.WriteLine(".Estilo12 {font-size: 14px}");
                    this.arch.WriteLine("-->");
                    this.arch.WriteLine("</style>");
                    this.arch.WriteLine("</head>");

                    this.arch.WriteLine("<body>");
                    this.arch.WriteLine("<table width='658' border='0' cellpadding='0' cellspacing='0'>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<th width='25' scope='col'>&nbsp;</th>");
                    this.arch.WriteLine("<th colspan='2' scope='col'><div align='right' class='Estilo10'>");
                    this.arch.WriteLine("<div align='center' class='Estilo12'></div>");
                    this.arch.WriteLine("</div></th>");
                    this.arch.WriteLine("<th width='194' scope='col'><div align='left' class='Estilo10'>Fecha: " + DateTime.Now.ToString("dd/MM/yyyy") + "</div></th>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<th colspan='4' scope='col'><span class='Estilo10'><span class='Estilo12'>Pago de cuota</span></span><span class='Estilo10'></span></th>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<th colspan='4' scope='col'><div align='center'><span class='Estilo10'>ATP Center</span></div>      </th>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<th width='25' scope='col'>&nbsp;</th>");
                    this.arch.WriteLine("<th width='94' scope='col'>&nbsp;</th>");
                    this.arch.WriteLine("<th width='347' scope='col'>&nbsp;</th>");
                    this.arch.WriteLine("<td>&nbsp;</td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<td colspan='4'>&nbsp;</td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<td colspan='4'><table width='660' border='1' cellpadding='0' cellspacing='0'>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<td width='87'><div align='right' class='Estilo10'><strong>Se&ntilde;or(es):</strong></div></td>");
                    this.arch.WriteLine("        <td width='568'><span class='Estilo10'>" + this.txtApellido.Text + ", " + this.txtNombre.Text + "</span></td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<td><div align='right' class='Estilo10'><strong>Nombre de clase:</strong></div></td>");
                    this.arch.WriteLine("<td><span class='Estilo10'>" + this.txtNombreClase.Text + "</span></td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<td><div align='right' class='Estilo10'><strong>Valor cuota:</strong></div></td>");
                    this.arch.WriteLine("<td><span class='Estilo10'>" + this.txtMontoCuota.Text + "</span></td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<td><div align='right' class='Estilo10'><strong>Punto Gym:</strong></div></td>");
                    this.arch.WriteLine("<td><span class='Estilo10'>" + this.txtPunto.Text + "</span></td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("</table></td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<td colspan='4'>&nbsp;</td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<td colspan='4'>");
                    this.arch.WriteLine("<table width='660' border='1' cellpadding='0' cellspacing='0'>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<th width='48' scope='col'><span class='Estilo8'>CANT.</span></th>");
                    this.arch.WriteLine("<th width='391' scope='col'><span class='Estilo8'>DETALLE</span></th>");
                    this.arch.WriteLine("<th width='109' scope='col'><span class='Estilo8'>P. UNITARIO </span></th>");
                    this.arch.WriteLine("<th width='84' scope='col'><span class='Estilo8'>IMPORTE</span></th>");
                    this.arch.WriteLine("</tr>");

                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine(" <td><div align='center' class='Estilo10'>1</div></td>");
                    this.arch.WriteLine(" <td><div align='center' class='Estilo10'>Se realizo el pago de la " + this.txtNumCuota.Text.Replace("º", "&deg;") + "</div></td>");
                    this.arch.WriteLine("  <td><div align='center' class='Estilo10'>" + this.txtAlumnoPaga.Text + "</div></td>");
                    this.arch.WriteLine("  <td><div align='center' class='Estilo10'>" + this.txtAlumnoPaga.Text + "</div></td>");
                    this.arch.WriteLine(" </tr>");

                    this.arch.WriteLine("</table>");
                    this.arch.WriteLine("	</td>");
                    this.arch.WriteLine("  </tr>");
                    this.arch.WriteLine(" <tr>");
                    this.arch.WriteLine("   <td colspan='4'>&nbsp;</td>");
                    this.arch.WriteLine(" </tr>");
                    this.arch.WriteLine(" <tr>");
                    this.arch.WriteLine("   <td colspan='4'>");
                    this.arch.WriteLine("	<table width='660' border='1' cellpadding='0' cellspacing='0'>");
                    this.arch.WriteLine(" <tr>");
                    this.arch.WriteLine("   <td colspan='2' rowspan='2'><div align='center' class='Estilo11'>Documento no valido como factura</div></td>");
                    this.arch.WriteLine("   <td><div align='right' class='Estilo7'>Subtotal $: </div></td>");
                    this.arch.WriteLine("   <td><div align='center' class='Estilo8'>" + this.txtAlumnoPaga.Text + "</div></td>");
                    this.arch.WriteLine(" </tr>");
                    this.arch.WriteLine(" <tr>");
                    this.arch.WriteLine("   <td><div align='right' class='Estilo8'><strong>Total $: </strong></div></td>");
                    this.arch.WriteLine("   <td><div align='center' class='Estilo8'>" + this.txtAlumnoPaga.Text + "</div></td>");
                    this.arch.WriteLine("  </tr>");
                    this.arch.WriteLine("</table>");
                    this.arch.WriteLine("</td>");
                    this.arch.WriteLine(" </tr>");
                    this.arch.WriteLine("</table>");
                    this.arch.WriteLine("</body>");
                    this.arch.WriteLine("</html>");

                    this.arch.Close();

                    System.Diagnostics.Process.Start(this.ruta);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
