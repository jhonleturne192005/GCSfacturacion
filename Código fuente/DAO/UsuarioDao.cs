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
    class UsuarioDao
    {
        Conexion conexion;
        public UsuarioDao()
        {
            conexion = new Conexion();
        }
        public string [] loginGetUsuario(string nombre_usuario, string contrasenia)
        {
            //Parámetros de salida:
            SqlParameter parametro_estado = new SqlParameter("@estado", SqlDbType.TinyInt);
            SqlParameter id_empleado = new SqlParameter("@id_usuario", SqlDbType.NChar, 10);

            parametro_estado.Direction = ParameterDirection.Output;
            id_empleado.Direction = ParameterDirection.Output;

            SqlParameter[] parametros =
            {
                new SqlParameter("@nombre_usuario", nombre_usuario),
                new SqlParameter("@contrasenia", contrasenia),
                parametro_estado,
                id_empleado
            };

            //Obtener las variables de salida de la ejecución del procedimiento almacenado
            string [] outputs = conexion.ejecutarConsultaOutputs("sp_login_get_usuario", parametros, 2);
            return outputs;
        }

        public DataTable getUsuario(int id_usuario)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_usuario", id_usuario),
            };

            return conexion.obtenerDatosSp("sp_get_usuario", parametros);
        }

        public int modificarContrasenia(string nombre_usuario, string contrasenia_actual, string contrasenia_nueva)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@nombre_usuario", nombre_usuario),
                new SqlParameter("@contrasenia_actual", contrasenia_actual),
                new SqlParameter("@contrasenia_nueva", contrasenia_nueva),
            };

            return conexion.ejecutarDmlSp("sp_modificar_usuario_contrasenia", parametros);
        }

        public int modificarContraseniaPorAdmin(int id_usuario_edita, string nombre_usuario, string contrasenia_nueva)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_usuario_edita", id_usuario_edita),
                new SqlParameter("@nombre_usuario", nombre_usuario),
                new SqlParameter("@contrasenia_nueva", contrasenia_nueva),
            };

            return conexion.ejecutarDmlSp("sp_modificar_usuario_contrasenia_por_admin", parametros);
        }
    }
}
