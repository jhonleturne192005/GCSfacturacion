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
    public class FacturaCtrl
    {
        FacturaDao facturaDao;
        public FacturaCtrl()
        {
            facturaDao = new FacturaDao();
        }
        public Respuesta insertarFactura(DTO.Factura factura)
        {
            string [] insercion_factura = facturaDao.insertarFactura(factura.getXml());

            string estado_insercion = insercion_factura[0];
            string id_factura = insercion_factura[1];

            string mensaje = string.Empty;
            bool completado = false;

            switch (estado_insercion)
            {
                case "0":
                    mensaje = "La factura fue insertada correctamente";
                    completado = true;
                    break;
                default:
                    mensaje = "se ha producido un error durante la inserción de la factura";
                    break;
            }

            return new Respuesta(completado, mensaje, id_factura);
        }

        public Respuesta eliminarFactura(int id_factura)
        {
            string[] insercion_factura = facturaDao.eliminarFactura(id_factura);

            string estado_insercion = insercion_factura[0];

            string mensaje = string.Empty;
            bool completado = false;

            switch (estado_insercion)
            {
                case "0":
                    mensaje = "La factura fue elimineada correctamente";
                    completado = true;
                    break;
                default:
                    mensaje = "se ha producido un error durante la eliminación de la factura";
                    break;
            }

            return new Respuesta(completado, mensaje);
        }

        public List<DTO.Factura> listarFacturas(int numero_pagina, int numero_elementos)
        {
            List<DTO.Factura> lstFacturas = new List<DTO.Factura>();

            DataTable dtFacturas = facturaDao.listarFacturas(numero_pagina, numero_elementos);
            for (int i = 0; i < dtFacturas.Rows.Count; i++)
            {
                DTO.Factura facturaDto = new DTO.Factura();
                DataRow drfactura = dtFacturas.Rows[i];

                facturaDto.Id_factura = int.Parse(drfactura[0].ToString());

                facturaDto.Cliente = new DTO.Cliente();
                facturaDto.Cliente.Id_cliente = int.Parse(drfactura[1].ToString());
                facturaDto.Cliente.Apellidos = drfactura[2].ToString();
                facturaDto.Cliente.Nombres = drfactura[3].ToString();

                facturaDto.Empleado = new DTO.Empleado();
                facturaDto.Empleado.Id_empleado = int.Parse(drfactura[4].ToString());
                facturaDto.Empleado.Apellidos = drfactura[5].ToString();
                facturaDto.Empleado.Nombres = drfactura[6].ToString();
               
                facturaDto.Fecha = drfactura[7].ToString();
                facturaDto.Subtotal = decimal.Parse(drfactura[8].ToString());
                facturaDto.Total = decimal.Parse(drfactura[9].ToString());

                lstFacturas.Add(facturaDto);
            }

            return lstFacturas;
        }
        public List<DTO.Factura> buscarFacturas(int numero_pagina, int numero_elementos, string texto_buscar)
        {
            List<DTO.Factura> lstFacturas = new List<DTO.Factura>();

            DataTable dtFacturas = facturaDao.buscarFactura(numero_pagina, numero_elementos, texto_buscar);
            for (int i = 0; i < dtFacturas.Rows.Count; i++)
            {
                DTO.Factura facturaDto = new DTO.Factura();
                DataRow drfactura = dtFacturas.Rows[i];

                facturaDto.Id_factura = int.Parse(drfactura[0].ToString());

                facturaDto.Cliente = new DTO.Cliente();
                facturaDto.Cliente.Id_cliente = int.Parse(drfactura[1].ToString());
                facturaDto.Cliente.Apellidos = drfactura[2].ToString();
                facturaDto.Cliente.Nombres = drfactura[3].ToString();

                facturaDto.Empleado = new DTO.Empleado();
                facturaDto.Empleado.Id_empleado = int.Parse(drfactura[4].ToString());
                facturaDto.Empleado.Apellidos = drfactura[5].ToString();
                facturaDto.Empleado.Nombres = drfactura[6].ToString();

                facturaDto.Fecha = drfactura[7].ToString();
                facturaDto.Subtotal = decimal.Parse(drfactura[8].ToString());
                facturaDto.Total = decimal.Parse(drfactura[9].ToString());

                lstFacturas.Add(facturaDto);
            }

            return lstFacturas;
        }

        public Opcion<string>[] getFiltrosBusqueda()
        {
            return new Opcion<string>[]
            {
               new Opcion<string>("No. Factura", "id_factura"),
               new Opcion<string>("CI. Cliente", "id_cliente"),
               new Opcion<string>("Cliente", "cliente")
            };
        }
    }
}
