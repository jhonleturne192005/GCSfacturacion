using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
{
    public class Respuesta
    {
        public bool Completado { get; }
        public string Mensaje { get; }
        public Hashtable Datos { get; }
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

        public Respuesta(bool completado, string mensaje, Hashtable hashTable)
        {
            this.Completado = completado;
            this.Mensaje = mensaje;
            this.Datos = hashTable;
        }
    }
}
