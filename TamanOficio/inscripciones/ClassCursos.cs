using TamanOficio.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamanOficio.tiposdeclase
{
    class ClassCursos
    {
        public string bandera { get; set; }
        public string idcurso { get; set; }
        public string idclase { get; set; }
        public string idtipodeclase { get; set; }
        public string idpunto { get; set; }
        public string tipodeclase { get; set; }
        public string nombreclase { get; set; }
        public string dni { get; set; }

        public int numcuota { get; set; }
        public string idcuota { get; set; }
        public string fechapago { get; set; }
        public string fecharealpago { get; set; }
        public string fechaproximopago { get; set; }
        public decimal montocuota { get; set; }
        public decimal montopagado { get; set; }
        public decimal montosaldo { get; set; }
       
        public string accion { get; set; }
        public string fechaaccion { get; set; }
        public int idempleadoaccion { get; set; }
        public int idpuntoaccion { get; set; }
        public string sql { get; set; }

        public DataTable BuscarNombresDeClases(ClassCursos _curso)
        {
            sql = "CALL sp_buscadorclases(" + _curso.idclase + ",'" + _curso.idtipodeclase + "','" + _curso.nombreclase + "',0,100);";

            return this.RealizarAccion(sql);
        }

        public DataTable BuscarTiposDeClases(ClassCursos _curso)
        {
            sql = "CALL sp_buscadortiposdeclasesporpunto(" + _curso.idpunto + ",0,100);";

            return this.RealizarAccion(sql);
        }
       
        private DataTable RealizarAccion(string _sql)
        {
            ClassConexion _cnx = new ClassConexion();

            DataTable _resp = new DataTable();

            _resp = _cnx.AcccionSobreBaseDatos(sql);

            return _resp;
        }

       public DataSet ABMInscripcion(ClassCursos _curso, string _tabla)
       {
           sql = "CALL sp_abminscripcionsocio(" + _curso.idcuota + "," + _curso.idcurso + "," + _curso.idclase + ",'" + _curso.dni + "'," + _curso.idpunto + ",'" + _curso.montocuota + "','" + _curso.montopagado + "','" + _curso.montosaldo + "','" + _curso.fechapago + "','" + _curso.accion + "','" + _curso.fechaaccion + "','" + _curso.idempleadoaccion + "','" + _curso.idpuntoaccion + "');";

           return this.RealizarAccion(sql, _tabla);
       }

        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        public DataSet BuscarInscripcionesCursosSocios(string _idcurso,string _dni, string _tabla)
        {
            sql = "CALL sp_buscadorinscripciones("+_idcurso+",'" + _dni + "',0,100);";

            return this.RealizarAccion(sql, _tabla);
        }

        public DataSet BuscarDatosSocioInscripto(string _idcurso, string _accion,string _tabla)
        {
            if (_accion == "S")
            {//Trae los datos del socio
                sql = "CALL sp_buscadorcuotas(" + _idcurso + ",'" + _accion + "');";
            }
            else
            {//Trae historial de cuotas
                sql = "CALL sp_buscadorcuotas(" + _idcurso + ",'" + _accion + "');";
            }
            return this.RealizarAccion(sql, _tabla);
        }

        public DataSet ABMCuotasSocios(ClassCursos _cuota, string _tabla)
        {
            sql = "CALL sp_abmcuotasocio(" + _cuota.idcuota + "," + _cuota.idcurso + ",'" + _cuota.fecharealpago + "','" + _cuota.fechaproximopago + "','" + _cuota.montocuota + "'," + _cuota.montopagado + ",'" + _cuota.montosaldo + "'," + _cuota.numcuota + ",'" + _cuota.accion + "','" + _cuota.fechaaccion + "','" + _cuota.idempleadoaccion + "','" + _cuota.idpuntoaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }
    }
}
