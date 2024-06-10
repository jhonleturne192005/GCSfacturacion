using SistemaFacturacion.AccesoDatos;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SistemaFacturacion.DAO
{
    class FacturaDao
    {
        Conexion conexion;
        public FacturaDao()
        {
            conexion = new Conexion();
        }

        public string [] insertarFactura(string xmlFactura)
        {
            //Parámetros de salida:
            SqlParameter estado = new SqlParameter("@estado", SqlDbType.TinyInt);
            SqlParameter id_factura = new SqlParameter("@id_factura", SqlDbType.BigInt);                        

            estado.Direction = ParameterDirection.Output;
            id_factura.Direction = ParameterDirection.Output;

            SqlParameter[] parametros =
            {
                new SqlParameter("@xml_factura", xmlFactura),
                estado,
                id_factura
            };

            return conexion.ejecutarDmlSp("sp_insertar_factura", parametros, 2);
        }

        public DataTable listarFactura(int numero_pagina, int numero_elementos)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };

            return conexion.obtenerDatosSp("sp_paginacion_listar_facturas", parametros);
        }

        public DataTable listarDetalleFactura(int id_factura)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_factura", id_factura)
            };

            return conexion.obtenerDatosSp("sp_paginacion_listar_facturas", parametros);
        }

        public DataTable buscarFactura(int numero_pagina, int numero_elementos, string texto_buscar)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@texto_buscar", texto_buscar),
                new SqlParameter("@numero_pagina", numero_pagina),
                new SqlParameter("@numero_elementos", numero_elementos),
            };

            return conexion.obtenerDatosSp("sp_paginacion_buscar_facturas", parametros);
        }

        public XmlDocument getXmlFactura(int id_factura)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_factura", id_factura)
            };

            return conexion.obtenerXmlRp("sp_rp_get_factura", parametros);
        }
    }
}
