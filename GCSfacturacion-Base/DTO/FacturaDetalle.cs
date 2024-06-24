using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistemaFacturacion.DTO
{
    public class FacturaDetalle
    {
        public int Id_factura_detalle { get; set; }
        public int Id_factura { get; set; }
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total{ get; set; }

        public FacturaDetalle()
        {
            
        }
        public FacturaDetalle(Producto producto, decimal cantidad)
        {
            this.Producto = producto;
            this.Cantidad = cantidad;
            calcular();
        }
        public void calcular()
        {
            this.Subtotal = Math.Round(Producto.Precio_unitario * Cantidad, 2);
            this.Total = Subtotal * (1 + Producto.Iva / 100);
        }
    }
}
