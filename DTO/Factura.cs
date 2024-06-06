using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.DTO
{
    class Factura
    {
        public int Id_factura { get; set; }
        public string Id_cliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }

        List<FacturaDetalle> Lst_factura_detalle;


        public string getXml() { return XmlParser.parsearXml(this); }
        public static string getXml(List<Factura> lstFacturas) { return XmlParser.parsearXml(lstFacturas); }
    }
}
