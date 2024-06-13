using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
{
    class csConexion
    {
        SqlConnection con;
        public SqlConnection ConexionSQL { get { return con; } }

        public csConexion()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=" + csDatosConexion.server + 
                ";DataBase=" + csDatosConexion.base_datos + 
                ";User id=" + csDatosConexion.usuario + 
                ";Password=" + csDatosConexion.clave;
        }

        public void AbrirConexion()
        {
            if (con.State != ConnectionState.Open)
            {                
                con.Open();
            }
        }

        public void CerrarConexion()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
