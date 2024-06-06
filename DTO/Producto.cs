using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.DTO
{
    public class Producto
    {
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal iva { get; set; }



        public string getXml() { return XmlParser.parsearXml(this); }
        public static string getXml(List<Producto> lstProductos) { return XmlParser.parsearXml(lstProductos); }
    }
}
