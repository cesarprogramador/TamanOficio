using TamanOficio.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamanOficio.cajadeldia
{
    class ClassCajaDelDia
    {
        public int idcajadeldia { get; set; }
        public string tipooperacion { get; set; }
        public string fechainicio { get; set; }
        public string fechafin { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string detallemovimiento { get; set; }
        public string tipopersona { get; set; }
        public string punto { get; set; }
        public string tipoclase { get; set; }
        public string nombreclase { get; set; }

        public string accion { get; set; }
        public string sql { get; set; }

        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        public DataSet BuscarCajaDelDia(ClassCajaDelDia _caja, string _tabla)
        {
            sql = "CALL sp_buscadorcajadeldia('" + _caja.tipooperacion + "','" + DateTime.Parse(_caja.fechainicio).ToString("yyyy/MM/dd") + " 00:00:00','" + DateTime.Parse(_caja.fechafin).ToString("yyyy/MM/dd") + " 00:00:00','" + _caja.apellidos + "','" + _caja.nombres + "','" + _caja.detallemovimiento + "','" + _caja.tipopersona + "','" + _caja.punto + "','" + _caja.nombreclase + "','" + _caja.tipoclase + "',0,100);";
            
            return this.RealizarAccion(sql, _tabla);
        }
    }
}
