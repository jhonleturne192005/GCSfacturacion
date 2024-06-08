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
    class FacturaDao
    {
        Conexion conexion;
        public FacturaDao()
        {
            conexion = new Conexion();
        }

        public int insertarFactura(string xmlFactura)
        {
            SqlParameter parametro_salida = new SqlParameter("@estado", SqlDbType.TinyInt);
            parametro_salida.Direction = ParameterDirection.Output;
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@xml_factura", xmlFactura),
                parametro_salida,
            };
            return this.conexion.guardar(lst_parametros, "sp_insertar_factura");
        }

        public DataTable listarFactura(int numero_pagina, int numero_elementos)
        {
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };
            return this.conexion.listar(lst_parametros, "sp_paginacion_listar_facturas");
        }

        public DataTable buscarFactura(int numero_pagina, int numero_elementos, string texto_buscar)
        {
            List<SqlParameter> lst_parametros = new List<SqlParameter>()
            {
                new SqlParameter("@texto_buscar", texto_buscar),
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos)
            };
            return this.conexion.listar(lst_parametros, "sp_paginacion_buscar_facturas");
        }

        public DataSet visualizarFactura(int id_factura)
        {            
            return this.conexion.buscarMT(null, "sp_visualizar_factura", new SqlParameter("@id_factura", id_factura));
        }
    }

}
