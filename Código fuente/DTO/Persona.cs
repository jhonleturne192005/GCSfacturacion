using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.DTO
{
    public abstract class Persona
    {
        public int IdPersona { get; set; }
        public string Cedula { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Fecha_Nacimiento { get; set; }
    }
}
