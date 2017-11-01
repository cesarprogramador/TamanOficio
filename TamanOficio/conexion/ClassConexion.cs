using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamanOficio.conexion
{
    class ClassConexion
    {
        MySqlConnectionStringBuilder _builder;
        MySqlConnection _conn;
        MySqlDataAdapter _mediador;
        DataSet _resp;
        DataTable _respcombo;
        bool _respacc;
        MySqlCommand _accsql;
        
        public ClassConexion()
        {
            _builder = new MySqlConnectionStringBuilder(); 
            
            _builder.Server = "localhost";
            _builder.UserID = "root";
            _builder.Password = "root";
            _builder.Database = "dbtamanoficio";
        }

        public DataSet AcccionSobreBaseDatos(string _sql,string _tabla)
        {
            try
            {
                _conn = new MySqlConnection(_builder.ToString());
                _mediador = new MySqlDataAdapter(_sql, _conn);
                _resp = new DataSet();

                _conn.Open();

                _mediador.Fill(_resp, _tabla);

                _conn.Close();
            }
            catch (Exception err)
            {
                _resp = null;
            }
            finally
            {
                _conn.Close();
            }

            return _resp;
        }

        public DataTable AcccionSobreBaseDatos(string _sql)
        {
            try
            {
                _conn = new MySqlConnection(_builder.ToString());
                _mediador = new MySqlDataAdapter(_sql, _conn);
                _respcombo = new DataTable();

                _conn.Open();

                _mediador.Fill(_respcombo);

                _conn.Close();
            }
            catch (Exception err)
            {
                _resp = null;
            }
            finally
            {
                _conn.Close();
            }

            return _respcombo;
        }
    }
}
