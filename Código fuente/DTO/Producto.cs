using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistemaFacturacion.DTO
{
    public class Producto
    {
        public int Id_producto { get; set; }
        public string Nombre_producto { get; set; }
        public decimal Precio_unitario { get; set; }
        public decimal Iva { get; set; }



        public string getXml() 
        {
            XElement xml_producto = new XElement("Producto");
            xml_producto.Add(new XElement("Id_producto", Id_producto));
            xml_producto.Add(new XElement("Nombre_producto", Nombre_producto));
            xml_producto.Add(new XElement("Precio_unitario", Precio_unitario));
            xml_producto.Add(new XElement("Iva", Iva));

            return xml_producto.ToString();
        }
    }
}
