using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
{
    class Respuesta
    {
        public bool Completado { get; }
        public string Mensaje { get; }        

        public Respuesta(bool completado, string mensaje)
        {
            this.Completado = completado;
            this.Mensaje = mensaje;
        }
    }
}
