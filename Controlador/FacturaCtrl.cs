using SistemaFacturacion.DAO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controlador
{
    class FacturaCtrl
    {
        FacturaDao facturaDao;
        public FacturaCtrl()
        {
            facturaDao = new FacturaDao();
        }
        public Respuesta insertarFactura(DTO.Factura factura)
        {
            int estado_insercion = facturaDao.insertarFactura(factura.getXml());

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado_insercion)
            {
                case 0:
                    mensaje = "La factura fue insertada correctamente";
                    completado = true;
                    break;
                default:
                    mensaje = "se ha producido un error durante la inserción de la factura";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }
        public List<DTO.Factura> listarFacturas(int numero_pagina, int numero_elementos)
        {
            List<DTO.Factura> lstFacturas = new List<DTO.Factura>();

            DataTable dtFacturas = facturaDao.listarFactura(numero_pagina, numero_elementos);
            for (int i = 0; i < dtFacturas.Rows.Count; i++)
            {
                DTO.Factura facturaDto = new DTO.Factura();
                DataRow drfactura = dtFacturas.Rows[i];

                facturaDto.Id_factura = int.Parse(drfactura[0].ToString());

                facturaDto.Id_cliente = new DTO.Cliente();
                facturaDto.Id_cliente.Id_cliente = drfactura[1].ToString();
                facturaDto.Id_cliente.Apellidos = drfactura[2].ToString();
                facturaDto.Id_cliente.Nombres = drfactura[3].ToString();

                facturaDto.Subtotal = decimal.Parse(drfactura[4].ToString());
                facturaDto.Total = decimal.Parse(drfactura[5].ToString());
            }

            return lstFacturas;
        }        
    }
}
