using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.DAO
{
    class ClienteDao
    {
        Conexion conexion;

        public ClienteDao()
        {
            this.conexion = new Conexion();
        }

        public int insertarCliente(string xmlCliente)
        {
            SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
            parametro_salida.Direction = ParameterDirection.Output;
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@xml_cliente", xmlCliente),
                parametro_salida,
            };
            return this.conexion.guardar(lst_parametros, "sp_insertar_cliente");
        }

        public int modificarCliente(string xmlCliente)
        {
            SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
            parametro_salida.Direction = ParameterDirection.Output;
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@xml_cliente", xmlCliente),
                parametro_salida,
            };
            return this.conexion.actualizar(lst_parametros, "sp_modificar_cliente");
        }

        public int eliminarCliente(string id_cliente)
        {
            SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
            parametro_salida.Direction = ParameterDirection.Output;
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@id_cliente", id_cliente),
                parametro_salida,
            };
            return this.conexion.eliminar(lst_parametros, "sp_eliminar_cliente");
        }

        public DataTable listarClientes(int numero_pagina, int numero_elementos)
        {
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };
            return this.conexion.listar(lst_parametros, "sp_paginacion_listar_clientes");
        }

        public DataTable buscarClientes(int numero_pagina, int numero_elementos, string texto_buscar)
        {
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@texto_buscar", texto_buscar),
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos)
            };
            return this.conexion.listar(lst_parametros, "sp_paginacion_buscar_cliente");
        }

        public DataTable getCliente(string id_cliente)
        {
            return this.conexion.buscar(null, "sp_get_cliente", new SqlParameter("@id_cliente", id_cliente));
        }

    }
}
