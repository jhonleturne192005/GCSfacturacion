using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Dto
{
    public class csProductoDto
    {
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal iva { get; set; }
    }
}
