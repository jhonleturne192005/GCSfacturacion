using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistemaFacturacion.DTO
{
    public class Empleado
    {
        public int Id_empleado { get; set; }
        public Usuario Usuario { get; set; }
        public string Cedula_empleado { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Fecha_nacimiento { get; set; }

        public Empleado()
        {
            Usuario = new Usuario();
        }

        public string getXml()
        {
            XElement xml_empleado = new XElement("Empleado");
            xml_empleado.Add(new XElement("Id_empleado", Id_empleado));
            xml_empleado.Add(new XElement("Cedula", Cedula_empleado));
            xml_empleado.Add(new XElement("Apellidos", Apellidos));
            xml_empleado.Add(new XElement("Nombres", Nombres));
            xml_empleado.Add(new XElement("Fecha_nacimiento", Fecha_nacimiento));

            return xml_empleado.ToString();
        }
    }
}
