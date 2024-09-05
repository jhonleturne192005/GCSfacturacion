using SistemaFacturacion.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.DAO
{
    class TipoUsuarioDao
    {
        Conexion conexion;
        public TipoUsuarioDao()
        {
            conexion = new Conexion();
        }

        public DataTable ListarTipoUsuarios()
        {           
            return conexion.obtenerDatosSp("sp_listar_tipo_usuarios", null);
        }
    }
}
