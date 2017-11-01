using TamanOficio.cajadeldia;
using TamanOficio.personas;
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
    public partial class Principal : Form
    {
        ClassPersonas _loginper;
        ClassCursos _cursos;
        ClassCajaDelDia _caja;
        StreamWriter arch;
        string ruta = "";

        public Principal()
        {
            InitializeComponent();
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

        private void aBMSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMSocios formsocio = new ABMSocios();
            formsocio.Show();
        }

        private void salirProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
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

            this.lblTituloForm.Text = "Movimientos - Usuario: " + this._loginper.apellido + ", " + this._loginper.nombre + " - Cargo: " + this._loginper.tipopersona + " - Punto: " + this._loginper.punto;

            this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;

            DataTable _puntos = this._loginper.BuscarPuntos(this._loginper);

            this.cbBusPuntos.DataSource = _puntos;
            this.cbBusPuntos.ValueMember = "idpunto";
            this.cbBusPuntos.DisplayMember = "nombrepunto";
            this.cbBusPuntos.Text = "";

            this._cursos = new ClassCursos();
            this._cursos.idpunto = "0";
            this._cursos.tipodeclase = "";

            this.cbBusTipoClase.DataSource = this._cursos.BuscarTiposDeClases(this._cursos);
            this.cbBusTipoClase.ValueMember = "idtipodeclase";
            this.cbBusTipoClase.DisplayMember = "tipodeclase";
            this.cbBusTipoClase.Text = "";

            this.cbBusNombreClase.Enabled = false;
        }

        private void btnBusTipoClase_Click(object sender, EventArgs e)
        {
            this._cursos.idpunto = this.cbBusPuntos.SelectedValue.ToString();
            this._cursos.tipodeclase = "";
            this.cbBusTipoClase.Text = "";
            this.cbBusTipoClase.DataSource = this._cursos.BuscarTiposDeClases(this._cursos);
            this.cbBusTipoClase.ValueMember = "idtipodeclase";
            this.cbBusTipoClase.DisplayMember = "tipodeclase";
            this.cbBusTipoClase.Enabled = true;
        }

        private void btnBusNombreClase_Click(object sender, EventArgs e)
        {
            try
            {
                this.cbBusNombreClase.Enabled = true;

                this._cursos.idclase = "0";
                this._cursos.idtipodeclase = this.cbBusTipoClase.SelectedValue.ToString();
                this._cursos.tipodeclase = "";
                this.cbBusNombreClase.Text = "";
                this.cbBusNombreClase.DataSource = this._cursos.BuscarNombresDeClases(this._cursos);
                this.cbBusNombreClase.ValueMember = "idclase";
                this.cbBusNombreClase.DisplayMember = "nombreclase";
            }
            catch (Exception err)
            {
                this.cbBusNombreClase.Enabled = false;
            }
        }

        private void Limpiar()
        {
            this.cbBusTipoPersona.Text = "Todos";
            this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;
            this.txtBusApellido.Text = "";
            this.txtBusNombre.Text = "";
            this.txtBusDetalleMovimiento.Text = "";

            this.cbBusTipoOperaciones.Text = "Caja del día";
            this.cbBusPuntos.Text = "";

            this._cursos.idpunto = "0";
            this._cursos.tipodeclase = "";

            this.cbBusTipoClase.DataSource = this._cursos.BuscarTiposDeClases(this._cursos);
            this.cbBusTipoClase.ValueMember = "idtipodeclase";
            this.cbBusTipoClase.DisplayMember = "tipodeclase";
            this.cbBusTipoClase.Text = "";

            this.cbBusNombreClase.DataSource = null;
            this.cbBusNombreClase.Enabled = false;
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Principal_Load(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._caja = new ClassCajaDelDia();

            this._caja.tipooperacion = this.cbBusTipoOperaciones.Text;
            this._caja.fechainicio = this.txtBusFechaIni.Text;
            this._caja.fechafin = this.txtBusFechaFin.Text;

            switch (this.cbBusTipoOperaciones.Text)
            {
                case "Caja del día":
                    this._caja.tipopersona = "";
                    this._caja.apellidos = this.txtBusApellido.Text;
                    this._caja.nombres = this.txtBusNombre.Text;
                    this._caja.detallemovimiento = this.txtBusDetalleMovimiento.Text;
                    this._caja.punto = this.cbBusPuntos.Text;
                    this._caja.nombreclase = this.cbBusNombreClase.Text;
                    this._caja.tipoclase = this.cbBusTipoClase.Text;
                    break;
                case "Ingresos":
                    if (this.cbBusTipoPersona.Text == "Todos los ingresos")
                    {
                        this._caja.tipopersona = "";
                        this._caja.apellidos = "";
                        this._caja.nombres = "";
                    }
                    else
                    {//Empleado o Socios
                        this._caja.tipopersona = this.cbBusTipoPersona.Text;
                        this._caja.apellidos = this.txtBusApellido.Text;
                        this._caja.nombres = this.txtBusNombre.Text;
                    }

                    this._caja.detallemovimiento = this.txtBusDetalleMovimiento.Text;
                    this._caja.punto = this.cbBusPuntos.Text;
                    this._caja.tipoclase = this.cbBusTipoClase.Text;
                    this._caja.nombreclase = this.cbBusNombreClase.Text;
                    break;
                case "Egresos":
                    if (this.cbBusTipoPersona.Text == "Todos los egresos")
                    {
                        this._caja.tipopersona = "";
                        this._caja.apellidos = "";
                        this._caja.nombres = "";
                    }
                    else
                    {//Empleado, proveedores o profesores
                        this._caja.tipopersona = this.cbBusTipoPersona.Text;
                        this._caja.apellidos = this.txtBusApellido.Text;
                        this._caja.nombres = this.txtBusNombre.Text;
                    }

                    this._caja.detallemovimiento = this.txtBusDetalleMovimiento.Text;
                    this._caja.punto = this.cbBusPuntos.Text;
                    this._caja.tipoclase = "";
                    this._caja.nombreclase = "";
                    break;
                case "Cuotas Impagas":
                    this._caja.tipopersona = "";
                    this._caja.apellidos = this.txtBusApellido.Text;
                    this._caja.nombres = this.txtBusNombre.Text;
                    this._caja.detallemovimiento = "";
                    this._caja.punto = this.cbBusPuntos.Text;
                    this._caja.nombreclase = this.cbBusNombreClase.Text;
                    this._caja.tipoclase = this.cbBusTipoClase.Text;
                    break;
            }

            this.dgvDetalleCaja.DataSource = this._caja.BuscarCajaDelDia(this._caja, "CajaDia");
            this.dgvDetalleCaja.DataMember = "CajaDia";

            if (this.dgvDetalleCaja.Rows.Count > 0)
            {
                if (this.cbBusTipoOperaciones.Text == "Cuotas Impagas") 
                {
                    this.dgvDetalleCaja.Columns[0].Visible = false;
                    this.dgvDetalleCaja.Columns[9].Visible = false;
                }
                else
                {
                    this.dgvDetalleCaja.Columns[0].Visible = false;
                    this.dgvDetalleCaja.Columns[8].Visible = false;
                    this.dgvDetalleCaja.Columns[9].Visible = false;
                }
                this.ObtenerTotales();
            }
        }

        private void ObtenerTotales()
        {
            decimal totalingreso = 0;
            decimal totalegreso = 0;
            decimal totalcaja = 0;

            for (int fil = 0; fil < this.dgvDetalleCaja.Rows.Count; fil++)
            {
                if (this.cbBusTipoOperaciones.Text == "Cuotas Impagas")
                {
                    totalegreso = totalegreso + decimal.Parse(this.dgvDetalleCaja[8, fil].Value.ToString());
                }
                else
                {
                    totalingreso = totalingreso + decimal.Parse(this.dgvDetalleCaja[6, fil].Value.ToString());
                    totalegreso = totalegreso + decimal.Parse(this.dgvDetalleCaja[7, fil].Value.ToString());
                }
            }

            this.txtTotalIngreso.Text = totalingreso.ToString();
            this.txtTotalEgreso.Text = totalegreso.ToString();
            totalcaja = totalingreso - totalegreso;
            this.txtTotalCaja.Text = totalcaja.ToString();
        }

        private void cbBusTipoOperaciones_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cbBusTipoPersona.Items.Clear();

            switch (this.cbBusTipoOperaciones.Text)
            {
                case "Caja del día":
                    this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    this.txtBusFechaIni.Enabled = false;
                    this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;
                    this.txtBusFechaFin.Enabled = false;

                    this.txtBusApellido.Text = "";
                    this.txtBusApellido.Enabled = true;
                    
                    this.txtBusNombre.Text = "";
                    this.txtBusNombre.Enabled = true;
                    
                    this.txtBusDetalleMovimiento.Text = "";
                    this.txtBusDetalleMovimiento.Enabled = true;

                    this.cbBusTipoPersona.Text = "Todos";
                    this.cbBusTipoPersona.Enabled = false;

                    this.cbBusPuntos.Text = "";
                    this.cbBusPuntos.Enabled = true;
                    this._cursos.idpunto = "0";
                   
                    this.cbBusTipoClase.Text="";
                    this.cbBusTipoClase.Enabled = true;
                    this.btnBusTipoClase.Enabled = true;

                    this.cbBusNombreClase.Text = "";
                    this.cbBusNombreClase.DataSource = null;
                    this.cbBusNombreClase.Enabled = true;
                    this.btnBusNombreClase.Enabled = true;
                    break;
                case "Ingresos":
                    this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    this.txtBusFechaIni.Enabled = true;
                    this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;
                    this.txtBusFechaFin.Enabled = true;
                    
                    this.txtBusApellido.Text = "";
                    this.txtBusApellido.Enabled = true;

                    this.txtBusNombre.Text = "";
                    this.txtBusNombre.Enabled = true;
                    
                    this.txtBusDetalleMovimiento.Text = "";
                    this.txtBusDetalleMovimiento.Enabled = true;

                    this.cbBusTipoPersona.Items.Add("Todos los ingresos");
                    this.cbBusTipoPersona.Items.Add("Empleados");
                    this.cbBusTipoPersona.Items.Add("Socios");
                    this.cbBusTipoPersona.Enabled = true;

                    this.cbBusPuntos.Text = "";
                    this._cursos.idpunto = "0";
                    this.cbBusPuntos.Enabled = true;

                    this.cbBusTipoClase.Text = "";
                    this.cbBusTipoClase.Enabled = false;

                    this.cbBusNombreClase.DataSource = null;
                    this.cbBusNombreClase.Enabled = false;
                    break;
                case "Egresos":
                    this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    this.txtBusFechaIni.Enabled = true;
                    this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;
                    this.txtBusFechaFin.Enabled = true;
                    
                    this.txtBusApellido.Text = "";
                    this.txtBusApellido.Enabled = true;

                    this.txtBusNombre.Text = "";
                    this.txtBusNombre.Enabled = true;
                    
                    this.txtBusDetalleMovimiento.Text = "";
                    this.txtBusDetalleMovimiento.Enabled = true;

                    this.cbBusTipoPersona.Items.Add("Todos los egresos");
                    this.cbBusTipoPersona.Items.Add("Empleados");
                    this.cbBusTipoPersona.Items.Add("Proveedores");
                    this.cbBusTipoPersona.Items.Add("Profesores");
                    this.cbBusTipoPersona.Enabled = true;

                    this.cbBusPuntos.Text = "";
                    this._cursos.idpunto = "0";
                    this.cbBusPuntos.Enabled = true;
                    
                    this.cbBusTipoClase.Text = "";
                    this.cbBusTipoClase.Enabled = false;
                    this.btnBusTipoClase.Enabled = false;

                    this.btnBusNombreClase.Enabled = false;
                    this.cbBusNombreClase.DataSource = null;
                    this.cbBusNombreClase.Enabled = false;
                    break;
            }
        }

        private void aBMProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProveedores formproveedor = new ABMProveedores();
            formproveedor.Show();
        }

        private void aBmGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMGastos formgastos = new ABMGastos();
            formgastos.Show();
        }

        private void btnCajaDia_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.btnBuscar_Click(sender, e);
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDetalleCaja.Rows.Count > 0)
                {
                    this.ruta = Path.GetFullPath("informe.html");

                    this.arch = new StreamWriter(this.ruta);

                    this.arch.WriteLine("<!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.01 Transitional//EN'");
                    this.arch.WriteLine("'http://www.w3.org/TR/html4/loose.dtd'>");
                    this.arch.WriteLine("<html>");
                    this.arch.WriteLine("<head>");
                    this.arch.WriteLine("<title>Presupuesto</title>");
                    this.arch.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=iso-8859-1'>");
                    this.arch.WriteLine("<style type='text/css'>");
                    this.arch.WriteLine("<!--");
                    this.arch.WriteLine(".Estilo7 {");
                    this.arch.WriteLine("font-size: 10px;");
                    this.arch.WriteLine("font-weight: bold;");
                    this.arch.WriteLine("}");
                    this.arch.WriteLine(".Estilo8 {font-size: 14px; color:#FFF;}");
                    this.arch.WriteLine(".Estilo10 {font-size: 13px}");
                    this.arch.WriteLine(".Estilo11 {font-size: 12px; font-weight: bold; }");
                    this.arch.WriteLine(".Estilo12 {font-size: 14px}");
                    this.arch.WriteLine("-->");
                    this.arch.WriteLine("</style>");
                    this.arch.WriteLine("</head>");
                    this.arch.WriteLine("<body>");
                    this.arch.WriteLine("<table width='100%' border='0' cellpadding='0' cellspacing='0'>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<th scope='col'>&nbsp;</th>");
                    this.arch.WriteLine("<th colspan='2' scope='col'>&nbsp;</th>");
                    this.arch.WriteLine("<th width='194' scope='col'><div align='left' class='Estilo10'>Fecha: " + DateTime.Now.ToString("dd/MM/yyyy") + "</div></th>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<th colspan='4' scope='col'><span class='Estilo12'>Informe de Caja</span></th>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<th colspan='4' scope='col'><span class='Estilo12'>" + (this.cbBusTipoOperaciones.Text == "Caja del día" ? "Caja del d&iacute;a" : this.cbBusTipoOperaciones.Text) + "</span></th>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<th width='25' scope='col'>&nbsp;</th>");
                    this.arch.WriteLine("<th width='94' scope='col'>&nbsp;</th>");
                    this.arch.WriteLine("<th width='347' scope='col'>&nbsp;</th>");
                    this.arch.WriteLine("<td>&nbsp;</td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");
                    this.arch.WriteLine("<td colspan='4'>");
                    this.arch.WriteLine("<table width='100%' border='0' cellpadding='0' cellspacing='0'>");

                    this.arch.WriteLine("<tr class='Estilo10'>");
                    this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>FECHA</span></th>");
                    this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>PUNTO</span></th>");
                    this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>DETALLE</span></th>");

                    if (this.cbBusTipoOperaciones.Text == "Caja del día") this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>PERSONA </span></th>");
                    if (this.cbBusTipoOperaciones.Text == "Ingresos" || this.cbBusTipoOperaciones.Text == "Cuotas Impagas") this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>SOCIO </span></th>");
                    if (this.cbBusTipoOperaciones.Text == "Egresos") this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>PROVEEDOR </span></th>");

                    if (this.cbBusTipoOperaciones.Text == "Cuotas Impagas")
                    {
                        this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>CLASE/TIPO <span></th>");
                        this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>CUOTA </span></th>");
                        this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>SALDO </span></th>");
                        this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>DEUDA </span></th>");
                    }
                    else
                    {
                        this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>INGRESO</span></th>");
                        this.arch.WriteLine("<th  bgcolor='#000000' scope='col'><span class='Estilo8'>EGRESO</span></th>");
                    }

                    this.arch.WriteLine("</tr>");

                    for (int fil = 0; fil < this.dgvDetalleCaja.Rows.Count; fil++)
                    {
                        this.arch.WriteLine("<tr>");
                        this.arch.WriteLine("<td><div align='center' class='Estilo10'>" + DateTime.Parse(this.dgvDetalleCaja[1, fil].Value.ToString()).ToString("dd/MM/yyyy") + "</div></td>");
                        this.arch.WriteLine("<td><div align='center' class='Estilo10'>&nbsp;" + this.dgvDetalleCaja[2, fil].Value.ToString() + "</div></td>");
                        this.arch.WriteLine("<td><div align='center' class='Estilo10'>&nbsp;" + this.dgvDetalleCaja[3, fil].Value.ToString() + "</div></td>");
                        this.arch.WriteLine("<td><div align='center' class='Estilo10'>&nbsp;" + this.dgvDetalleCaja[4, fil].Value.ToString() + "</div></td>");

                        if (this.cbBusTipoOperaciones.Text == "Cuotas Impagas")
                        {
                            this.arch.WriteLine("<td><div align='center' class='Estilo10'>&nbsp;" + this.dgvDetalleCaja[5, fil].Value.ToString() + "</div></td>");
                            this.arch.WriteLine("<td><div align='center' class='Estilo10'>&nbsp;" + this.dgvDetalleCaja[6, fil].Value.ToString() + "</div></td>");
                            this.arch.WriteLine("<td><div align='center' class='Estilo10'>&nbsp;" + this.dgvDetalleCaja[7, fil].Value.ToString() + "</div></td>");
                            this.arch.WriteLine("<td><div align='center' class='Estilo10'>&nbsp;" + this.dgvDetalleCaja[8, fil].Value.ToString() + "</div></td>");
                        }
                        else
                        {
                            this.arch.WriteLine("<td><div align='center' class='Estilo10'>&nbsp;" + this.dgvDetalleCaja[6, fil].Value.ToString() + "</div></td>");
                            this.arch.WriteLine("<td><div align='center' class='Estilo10'>&nbsp;" + this.dgvDetalleCaja[7, fil].Value.ToString() + "</div></td>");
                        }

                        this.arch.WriteLine("</tr>");
                    }

                    this.arch.WriteLine("<tr>");

                    if (this.cbBusTipoOperaciones.Text == "Cuotas Impagas") this.arch.WriteLine("<td bgcolor='#000000' colspan='8'>&nbsp;</td>");
                    else this.arch.WriteLine("<td bgcolor='#000000' colspan='6'>&nbsp;</td>");

                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");

                    if (this.cbBusTipoOperaciones.Text == "Cuotas Impagas") this.arch.WriteLine("<td colspan='7'><div align='center' class='Estilo10'>");
                    else this.arch.WriteLine("<td colspan='5'><div align='center' class='Estilo10'>");

                    this.arch.WriteLine("<div align='right' class='Estilo7'>TOTAL INGRESO $:</div>");
                    this.arch.WriteLine("</div></td>");
                    this.arch.WriteLine("<td><div align='center' class='Estilo10'><strong>" + this.txtTotalIngreso.Text + "</strong></div></td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");

                    if (this.cbBusTipoOperaciones.Text == "Cuotas Impagas") this.arch.WriteLine("<td colspan='7'><div align='center' class='Estilo10'>");
                    else this.arch.WriteLine("<td colspan='5'><div align='center' class='Estilo10'>");

                    this.arch.WriteLine("<div align='right' class='Estilo7'>TOTAL EGRESO $:</div>");
                    this.arch.WriteLine("</div></td>");
                    this.arch.WriteLine("<td><div align='center' class='Estilo10'><strong>" + this.txtTotalEgreso.Text + "</strong></div></td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("<tr>");

                    if (this.cbBusTipoOperaciones.Text == "Cuotas Impagas") this.arch.WriteLine("<td colspan='7'><div align='center' class='Estilo10'>");
                    else this.arch.WriteLine("<td colspan='5'><div align='center' class='Estilo10'>");

                    this.arch.WriteLine("<div align='right' class='Estilo7'>TOTAL $:</div>");
                    this.arch.WriteLine("</div></td>");
                    this.arch.WriteLine("<td><div align='center' class='Estilo10'><strong>" + this.txtTotalCaja.Text + "</strong></div></td>");
                    this.arch.WriteLine("</tr>");
                    this.arch.WriteLine("</table>");
                    this.arch.WriteLine("</td>");
                    this.arch.WriteLine("</tr>");
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