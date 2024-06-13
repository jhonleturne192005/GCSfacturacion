using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistemaFacturacion.DTO
{
    public class Factura
    {
        public int Id_factura { get; set; }
        public Cliente Id_cliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public List<FacturaDetalle> Factura_Detalle { get; set; }

        //Constructores

        public Factura() 
        {
            Factura_Detalle = new List<FacturaDetalle>();
        }


        //Funciones
        public void agregarDetalleFactura(int indice, FacturaDetalle detalle)
        {
            //Verificar sí el indice en el que se va a ingresar existe.
            //En caso de no hacerlo agregar le objeto a la lista
            if (Factura_Detalle.Count <= indice)
            {
                Factura_Detalle.Add(detalle);
            }
            else
            {                
                Factura_Detalle[indice] = detalle;
            }
        }
        public bool existeProductoFactura(int id_producto)
        {
            for (int i = 0; i < Factura_Detalle.Count; i++)
            {
                if (Factura_Detalle[i].Producto.Id_producto == id_producto) return true;
            }

            return false;
        }

        public void calcular()
        {
            this.Subtotal = 0;
            this.Total = 0;

            //Calcular los totales y subtotales con la lista de objetos registrados en la factura
            for (int i = 0; i < Factura_Detalle.Count; i++)
            {
                DTO.FacturaDetalle detalle = Factura_Detalle[i];
                Subtotal += detalle.Subtotal;
                Total += detalle.Total;
            }
        }

        //Transformaciones de objetos a xml
        public string getXml() { return XmlParser.parsearXml(this); }
        public static string getXml(List<Factura> lstFacturas) { return XmlParser.parsearXml(lstFacturas); }

    }
}
