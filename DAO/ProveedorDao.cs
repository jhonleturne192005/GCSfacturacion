using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFacturacion.AccesoDatos;
using System.Data;
using System.Data.SqlClient;

namespace SistemaFacturacion.DAO
{
    public class ProveedorDao
    {
        Conexion conexion;
        public ProveedorDao()
        {
            this.conexion = new Conexion();
        }

        public int insertarProveedor(string xmlProveedor)
        {
            SqlParameter[] parameter =
            {
                new SqlParameter("@xml_proveedor", xmlProveedor)

            };

            return conexion.ejecutarDmlSp("sp_insertar_proveedor", parameter);
        }

        public int modificarProveedor(string xmlProveedor)
        {
            SqlParameter[] parameter =
            {
                new SqlParameter("@xml_proveedor", xmlProveedor)

            };

            return conexion.ejecutarDmlSp("sp_modificar_proveedor", parameter);
        }
        public DataTable listarProveedores(int numero_pagina, int numero_elementos)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };

            return conexion.obtenerDatosSp("sp_paginacion_listar_proveedor", parametros);
        }

        public DataTable buscarProveedor(int numero_pagina, int numero_elementos, string xml_filtros_busqueda)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@xml_filtros_busqueda", xml_filtros_busqueda),
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };

            return conexion.obtenerDatosSp("sp_paginacion_buscar_proveedor", parametros);
        }

        public DataTable getProveedorPorId(int id_proveedor)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_proveedor", id_proveedor)
            };

            return conexion.obtenerDatosSp("sp_get_proveedor", parametros);
        }

        public DataTable getProveedorPorCedula(string cedula)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@cedula", cedula)
            };

            return conexion.obtenerDatosSp("sp_get_proveedor_por_cedula", parametros);
        }

        public int eliminarProveedor(int id_cliente)
        {

            SqlParameter[] parametros =
            {
                new SqlParameter("@id_proveedor", id_cliente),
            };

            return conexion.ejecutarDmlSp("sp_eliminar_proveedor", parametros);
        }

        //public int eliminarCliente(int id_proveedor)
        //{
        //    SqlParameter[] parametros =
        //    {
        //        new SqlParameter("@id_cliente", id_proveedor),
        //    };
        //    return conexion.ejecutarDmlSp("sp_eliminar_cliente", parametros);
        //}


    }
}
