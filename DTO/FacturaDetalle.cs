using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.DTO
{
    class FacturaDetalle
    {
        public int Id_factura_detalle { get; set; }
        public int Id_factura { get; set; }
        public int Id_producto { get; set; }
        public float Cantidad { get; set; }


    }
}
