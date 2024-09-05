using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaFacturacion.AccesoDatos;


namespace SistemaFacturacion.DAO
{
    public class PersonaDao
    {
        Conexion conexion;

        public PersonaDao()
        {
            conexion = new Conexion();
        }

        public DataTable getPersonaPorId(string id_persona)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_cliente", id_persona)
            };

            return conexion.obtenerDatosSp("sp_get_cliente", parametros);
        }
    }
}
