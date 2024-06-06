using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
{
    class Conexion
    {
        SqlConnection con;
        public SqlConnection ConexionSQL { get { return con; } }

        public Conexion()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=" + DatosConexion.server + 
                ";DataBase=" + DatosConexion.base_datos + 
                ";User id=" + DatosConexion.usuario + 
                ";Password=" + DatosConexion.clave;
        }

        public void AbrirConexion()
        {
            if (con != null && con.State != ConnectionState.Open)
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
