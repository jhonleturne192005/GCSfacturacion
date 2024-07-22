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
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public string Fecha { get; set; }
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



        public string getXml() {
            //Encabezado de la factura
            XElement xml_factura = new XElement("Factura");
            xml_factura.Add(new XElement("Id_cliente", Cliente.Id_cliente));
            xml_factura.Add(new XElement("Id_empleado", Empleado.Id_empleado));

            XElement xml_factura_detalle = new XElement("Factura_Detalle");
            //Cuerpo o detalle de la factura
            for (int i = 0; i < Factura_Detalle.Count; i++)
            {
                FacturaDetalle factura_detalle = Factura_Detalle[i];

                //Formar el xml del detalle de la factura
                XElement xml_detalle = new XElement("Detalle");
                xml_detalle.Add(new XElement("Id_producto", factura_detalle.Producto.Id_producto));
                xml_detalle.Add(new XElement("Cantidad", factura_detalle.Cantidad));

                xml_factura_detalle.Add(xml_detalle);
            }

            //Unificar el xml
            xml_factura.Add(xml_factura_detalle);
            return xml_factura.ToString();
        }
    }
}
