using TamanOficio.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamanOficio.gastos
{
    class ClassGastos
    {
        public string bandera { get; set; }
        public string idgasto { get; set; }
        public string numerofactura { get; set; }
        public string tipofactura { get; set; }
        public string idproveedor { get; set; }
        public string nombreproveedor { get; set; }
        public decimal montopagado { get; set; }
        public string fecharealcarga { get; set; }
        public string fechainigasto { get; set; }
        public string fechafingasto { get; set; }
        public string fechagasto { get; set; }
        public string observacion { get; set; }
        public string idpunto { get; set; }
        public string nombrepunto { get; set; }
       
        public string accion { get; set; }
        public string fechaaccion { get; set; }
        public int idempleadoaccion { get; set; }
        public int idpuntoaccion { get; set; }
        public string sql { get; set; }

        public DataSet BuscarGastos(ClassGastos _gasto, string _tabla)
        {  
            sql = "CALL sp_buscadorgastos(" + _gasto.idgasto + ",'" + _gasto.fechainigasto + "','" + _gasto.fechafingasto + "','" + _gasto.nombreproveedor + "','" + _gasto.nombrepunto + "',0,100);";

            return this.RealizarAccion(sql, _tabla);
        }

        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        public DataSet ABMGasto(ClassGastos _gasto, string _tabla)
        {
            sql = "CALL sp_abmgasto(" + _gasto.idgasto + ",'" + _gasto.fecharealcarga + "','" + _gasto.fechagasto + "','" + _gasto.tipofactura + "','" + _gasto.numerofactura + "','" + _gasto.idproveedor + "','" + _gasto.idpunto + "','" + _gasto.montopagado + "','" + _gasto.observacion + "','" + _gasto.accion + "','" + _gasto.fechaaccion + "','" + _gasto.idempleadoaccion + "','" + _gasto.idpuntoaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }
    }
}
