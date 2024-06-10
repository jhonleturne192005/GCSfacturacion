using SistemaFacturacion.AccesoDatos;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.DAO
{
    class ProductoDao
    {
        Conexion conexion;
        public ProductoDao()
        {
            conexion = new Conexion();
        }

        public int insertarProducto(string xmlProducto)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@xml_producto", xmlProducto)
            };

            return conexion.ejecutarDmlSp("sp_insertar_producto", parametros);
        }


        public int modificarProducto(string xmlProducto)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@xml_producto", xmlProducto)
            };

            return conexion.ejecutarDmlSp("sp_modificar_producto", parametros);
        }


        public int eliminarProducto(int id_producto)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_producto", id_producto)
            };

            return conexion.ejecutarDmlSp("sp_eliminar_producto", parametros);
        }


        public DataTable listarProductos(int numero_pagina, int numero_elementos)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };

            return conexion.obtenerDatosSp("sp_paginacion_listar_productos", parametros);
        }

        public DataTable getProducto(int id_producto)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_producto", id_producto)                
            };

            return conexion.obtenerDatosSp("sp_get_producto", parametros);
        }

        public DataTable buscarProducto(string texto_buscar)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@texto_buscar", texto_buscar)
            };

            return conexion.obtenerDatosSp("sp_buscar_producto", parametros);            
        }


        public DataTable buscarProducto(string texto_buscar,int numero_pagina, int numero_elementos)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@texto_buscar", texto_buscar),
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };

            return conexion.obtenerDatosSp("sp_paginacion_buscar_producto", parametros);
        }
    }
}
