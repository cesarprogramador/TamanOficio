using TamanOficio.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamanOficio.puntos
{
    class ClassPuntos
    {
        public string bandera { get; set; }
        public string idpunto { get; set; }
        public string nombrepunto { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string piso { get; set; }
        public string dpto { get; set; }
        
        public string accion { get; set; }
        public string fechaaccion { get; set; }
        public int idempleadoaccion { get; set; }
        public int idpuntoaccion { get; set; }
        public string sql { get; set; }

        public DataSet ABMPuntos(ClassPuntos _punto, string _tabla)
        {
            sql = "CALL sp_abmpunto(" + _punto.idpunto + ",'" + _punto.nombrepunto + "','" + _punto.calle + "','" + _punto.numero + "','" + _punto.piso + "','" + _punto.dpto + "','" + _punto.accion + "','" + _punto.fechaaccion + "','" + _punto.idempleadoaccion + "','" + _punto.idpuntoaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }

        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        public DataTable BuscarPuntos(ClassPuntos _punto)
        {
            sql = "CALL sp_buscadorpuntos(" + _punto.idpunto + ",'" + _punto.nombrepunto + "',0,100);";

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

