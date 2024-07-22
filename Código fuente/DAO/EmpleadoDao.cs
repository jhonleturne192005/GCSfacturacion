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
    class EmpleadoDao
    {
        Conexion conexion;
        public EmpleadoDao()
        {
            conexion = new Conexion();
        }
        public int insertarEmpleado(string xmlEmpleado, string xmlUsuario)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@xml_empleado", xmlEmpleado),
                new SqlParameter("@xml_usuario", xmlUsuario),
            };

            return conexion.ejecutarDmlSp("sp_insertar_empleado", parametros);
        }

        public int modificarEmpleado(string xmlEmpleado, string xmlUsuario)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@xml_empleado", xmlEmpleado),
                new SqlParameter("@xml_usuario", xmlUsuario),
            };

            return conexion.ejecutarDmlSp("sp_modificar_empleado", parametros);
        }

        public int eliminarEmpleado(int id_empleado)
        {

            SqlParameter[] parametros =
            {
                new SqlParameter("@id_empleado", id_empleado),
            };

            return conexion.ejecutarDmlSp("sp_eliminar_empleado", parametros);
        }

        public DataTable listarEmpleados(int numero_pagina, int numero_elementos)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };

            return conexion.obtenerDatosSp("sp_paginacion_listar_empleados", parametros);
        }

        public DataTable buscarEmpleados(int numero_pagina, int numero_elementos, string xml_filtros_busqueda)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@xml_filtros_busqueda", xml_filtros_busqueda),
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };

            return conexion.obtenerDatosSp("sp_paginacion_buscar_empleado", parametros);
        }

        public DataTable getEmpleado(int id_empleado)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_empleado", id_empleado)
            };

            return conexion.obtenerDatosSp("sp_get_empleado", parametros);
        }

        public DataTable getEmpleadoPorCedula(string cedula)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@cedula_empleado", cedula)
            };

            return conexion.obtenerDatosSp("sp_get_empleado_por_cedula", parametros);
        }

        public DataTable getEmpleadoUsuario(int id_empleado)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_empleado", id_empleado)
            };

            return conexion.obtenerDatosSp("sp_get_empleado_usuario", parametros);
        }

        public DataTable getEmpleadoUsuarioPorIdUsuario(int id_usuario)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_usuario", id_usuario)
            };

            return conexion.obtenerDatosSp("sp_get_empleado_usuario_por_usuario", parametros);
        }
    }
}
