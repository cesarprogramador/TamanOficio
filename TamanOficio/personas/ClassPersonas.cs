using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TamanOficio.conexion;

namespace TamanOficio.personas
{
    class ClassPersonas
    {
        public string bandera{get;set;}
        public string idpersona{get;set;}
        public string apellido{get;set;}
        public string nombre{get;set;}
        public string dni{get;set;}
        public string correo{get;set;}
        public string cuit { get; set; }
        public string cuil { get; set; }
        public string cel{get;set;}
        public string tel{get;set;}
        public string urlfoto{get;set;}
        public string fechanac{get;set;}
        public string usuario{get;set;}
        public string pass{get;set;}
        public string punto{get;set;}
        public string calle{get;set;}
        public string numero{get;set;}
        public string piso{get;set;}
        public string dpto{get;set;}
        public string tipopersona{get;set;}
        public string apellidocotacto { get; set; }
        public string nombrecontacto{get;set;}
        public string telcontacto{get;set;}
        public string celcontacto{get;set;}
        public string emailcontacto{get;set;}
        public string idpunto { get; set; }
        public string nombrepunto { get; set; }
        public string idespecialidad { get; set; }
        public string especialidad { get; set; }

        public string accion{get;set;}
        public string fechaaccion{get;set;}
        public int idempleadoaccion{get;set;}
        public int idpuntoaccion { get; set; }
        public string sql { get; set; }

        public DataSet LoginPersona(string _usu,string _pass, string _tabla)
        {
            sql = "CALL sp_login('" + _usu + "','" + _pass + "');";

            return this.RealizarAccion(sql, _tabla);
        }

        public DataSet BuscarPersonaEmpleados(ClassPersonas _empleado, string _tabla)
        {
            sql = "CALL sp_buscadorempleados(" + _empleado.idpersona + ",'" + _empleado.apellido + "','" + _empleado.nombre + "','" + _empleado.dni + "','" + _empleado.punto + "','" + _empleado.tipopersona + "',0,100);";

            return this.RealizarAccion(sql, _tabla);
        }

        public DataSet BuscarPersonaProfesores(ClassPersonas _empleado, string _tabla)
        {
            sql = "CALL sp_buscadorprofesores(" + _empleado.idpersona + ",'" + _empleado.apellido + "','" + _empleado.nombre + "','" + _empleado.dni + "','" + _empleado.punto + "','" + _empleado.tipopersona + "',0,100);";

            return this.RealizarAccion(sql, _tabla);
        }

        public DataSet BuscarPersonaSocios(ClassPersonas _empleado, string _tabla)
        {
            sql = "CALL sp_buscadorsocios(" + _empleado.idpersona + ",'" + _empleado.apellido + "','" + _empleado.nombre + "','" + _empleado.dni + "','" + _empleado.punto + "','" + _empleado.tipopersona + "',0,100);";

            return this.RealizarAccion(sql, _tabla);
        }

        public DataSet ABMPersona(ClassPersonas _empleado,string _tabla)
        {
            sql = "CALL sp_abmpersona(" + _empleado.idpersona + ",'" + _empleado.apellido + "','" + _empleado.nombre + "','" + _empleado.fechanac + "','" + _empleado.dni + "','" + _empleado.cuil + "','" + _empleado.cel + "','" + _empleado.tel + "','" + _empleado.correo + "','" + _empleado.calle + "','" + _empleado.numero + "','" + _empleado.piso + "','" + _empleado.dpto + "','" + _empleado.punto + "','" + _empleado.tipopersona + "','" + _empleado.urlfoto + "','" + _empleado.apellidocotacto + "','" + _empleado.nombrecontacto + "','" + _empleado.celcontacto + "','" + _empleado.telcontacto + "','" + _empleado.emailcontacto + "','" + _empleado.cuit + "','" + _empleado.idespecialidad + "','" + _empleado.accion + "','" + _empleado.fechaaccion + "','" + _empleado.idempleadoaccion + "','" + _empleado.idpuntoaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }

        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        public DataTable BuscarPuntos(ClassPersonas _empleado)
        {
            sql = "CALL sp_buscadorpuntos(" + _empleado.idpunto + ",'" + _empleado.nombrepunto + "',0,100);";

            return this.RealizarAccion(sql);
        }

        public DataTable BuscarEspecialidad(ClassPersonas _empleado)
        {
            sql = "CALL sp_buscadorespecialidades(" + _empleado.idespecialidad + ",'" + _empleado.especialidad + "',0,100);";

            return this.RealizarAccion(sql);
        }

        public DataSet BuscarPersonaProveedores(ClassPersonas _proveedor,string _tabla)
        {
            sql = "CALL sp_buscadorproveedores(" + _proveedor.idpersona + ",'" + _proveedor.nombre + "','" + _proveedor.cuit + "','" + _proveedor.apellidocotacto + "','" + _proveedor.nombrecontacto + "',0,100);";

            return this.RealizarAccion(sql,_tabla);
        }

        public DataTable BuscarPersonaProveedores(ClassPersonas _proveedor)
        {
            sql = "CALL sp_buscadorproveedores(" + _proveedor.idpersona + ",'" + _proveedor.nombre + "','','','',0,100);";

            return this.RealizarAccion(sql);
        }

        public DataTable BuscarPersonaEmpleados(ClassPersonas _empleado)
        {
            sql = "CALL sp_buscadorempleados(" + _empleado.idpersona + ",'" + _empleado.apellido + "','" + _empleado.nombre + "','" + _empleado.dni + "','" + _empleado.punto + "','" + _empleado.tipopersona + "',0,100);";

            return this.RealizarAccion(sql);
        }

        private DataTable RealizarAccion(string _sql)
        {
            ClassConexion _cnx = new ClassConexion();

            DataTable _resp = new DataTable();

            _resp = _cnx.AcccionSobreBaseDatos(sql);

            return _resp;
        }
    }
}
