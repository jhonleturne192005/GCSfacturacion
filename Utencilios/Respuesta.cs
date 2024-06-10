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
        public string Id { get; }

        public Respuesta(bool completado, string mensaje, string id)
        {
            this.Completado = completado;
            this.Mensaje = mensaje;
            this.Id = id;
        }

        public Respuesta(bool completado, string mensaje)
        {
            this.Completado = completado;
            this.Mensaje = mensaje;
        }
    }
}
