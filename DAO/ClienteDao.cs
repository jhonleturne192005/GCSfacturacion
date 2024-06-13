using SistemaFacturacion.AccesoDatos;
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
            SqlParameter[] parametros =
            {
                new SqlParameter("@xml_cliente", xmlCliente)         
            };

            return conexion.ejecutarDmlSp("sp_insertar_cliente", parametros);
        }

        public int modificarCliente(string xmlCliente)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@xml_cliente", xmlCliente),
            };

            return conexion.ejecutarDmlSp("sp_modificar_cliente", parametros);
        }

        public int eliminarCliente(string id_cliente)
        {            

            SqlParameter[] parametros =
            {
                new SqlParameter("@id_cliente", id_cliente),
            };

            return conexion.ejecutarDmlSp("sp_eliminar_cliente", parametros);            
        }

        public DataTable listarClientes(int numero_pagina, int numero_elementos)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };

            return conexion.obtenerDatosSp("sp_paginacion_listar_clientes", parametros);
        }

        public DataTable buscarClientes(int numero_pagina, int numero_elementos, string texto_buscar)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@texto_buscar", texto_buscar),
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };

            return conexion.obtenerDatosSp("sp_paginacion_buscar_cliente", parametros);
        }

        public DataTable getCliente(string id_cliente)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_cliente", id_cliente)              
            };

            return conexion.obtenerDatosSp("sp_get_cliente", parametros);            
        }

    }
}
