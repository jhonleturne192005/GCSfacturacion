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

        public DataTable listarProductos(int numero_pagina, int numero_elementos)
        {
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos)
            };
            return this.conexion.listar(lst_parametros, "sp_paginacion_listar_productos");
        }

        public DataTable getProducto(int id_producto)
        {
            return this.conexion.buscar(null, "sp_get_producto", new SqlParameter("@id_producto", id_producto));
        }

        public DataTable buscarProducto(string texto_buscar)
        {
            return this.conexion.buscar(null, "sp_buscar_producto", new SqlParameter("@texto_buscar", texto_buscar));
        }

        public DataTable buscarProducto(string texto_buscar,int numero_pagina, int numero_elementos)
        {
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@texto_buscar", texto_buscar),
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos)
            };
            return this.conexion.listar(lst_parametros, "sp_paginacion_buscar_producto");
        }

        public int insertarProducto(string xmlProducto)
        {
            SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
            parametro_salida.Direction = ParameterDirection.Output;
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@xml_producto", xmlProducto),
                parametro_salida,
            };
            return this.conexion.guardar(lst_parametros, "sp_insertar_producto");
        }

        public int actualizarProducto(string xmlProducto)
        {
            //MessageBox.Show(xmlProducto);
            //SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
            //parametro_salida.Direction = ParameterDirection.Output;
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@xml_producto", xmlProducto),
                //parametro_salida,
            };
            return this.conexion.actualizar(lst_parametros, "sp_modificar_producto");
        }

        public int eliminarProducto(int id_producto)
        {
            SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
            parametro_salida.Direction = ParameterDirection.Output;
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@id_producto", id_producto),
                parametro_salida,
            };
            return this.conexion.eliminar(lst_parametros, "sp_eliminar_producto");
        }


    }
}
