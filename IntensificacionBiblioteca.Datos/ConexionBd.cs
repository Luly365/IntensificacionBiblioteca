using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos
{
    public class ConexionBd
    {
        private readonly SqlConnection _cnSqlConeccion;
         public ConexionBd()
        {
            var cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
            _cnSqlConeccion = new SqlConnection(cadenaConexion);
        }   

        public SqlConnection AbrirConexion()
        {
            if (_cnSqlConeccion.State == ConnectionState.Closed)
            {
                _cnSqlConeccion.Open();
            }
            return _cnSqlConeccion;
        }

        public void  CerrarConexion()
        {
            if (_cnSqlConeccion.State==ConnectionState.Open)
            {
                _cnSqlConeccion.Close();
            }
           
        }


    }
}
