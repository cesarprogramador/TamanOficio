using TamanOficio.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamanOficio.tiposdeclases
{
    class ClassTiposDeClases
    {
        public string bandera { get; set; }
        public string idtipodeclase { get; set; }
        public string tipodeclase { get; set; }
       
        public string accion { get; set; }
        public string fechaaccion { get; set; }
        public int idempleadoaccion { get; set; }
        public int idpuntoaccion { get; set; }
        public string sql { get; set; }

        public DataSet ABMTipoDeClase(ClassTiposDeClases _tipoclase, string _tabla)
        {
            sql = "CALL sp_abmtiposdeclases(" + _tipoclase.idtipodeclase + ",'" + _tipoclase.tipodeclase + "','" + _tipoclase.accion + "','" + _tipoclase.fechaaccion + "','" + _tipoclase.idempleadoaccion + "','" + _tipoclase.idpuntoaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }

        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        public DataTable BuscarTiposDeClases(ClassTiposDeClases _tipoclase)
        {
            sql = "CALL sp_buscadortiposdeclases(" + _tipoclase.idtipodeclase + ",'" + _tipoclase.tipodeclase + "',0,100);";

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
