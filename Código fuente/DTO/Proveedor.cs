using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.DTO
{
    public class Proveedor: Persona
    {
        public  int  IdProveedor { get; set;  }
        public string Email { get; set; }


        public string getXml()
        {
            XElement xml_cliente = new XElement("Proveedor");
            xml_cliente.Add(new XElement("Id_proveedor", IdPersona));
            xml_cliente.Add(new XElement("Cedula_proveedor", Cedula));
            xml_cliente.Add(new XElement("Apellidos", Apellidos));
            xml_cliente.Add(new XElement("Nombres", Nombres));
            xml_cliente.Add(new XElement("Email", Email));

            return xml_cliente.ToString();
        }


    }

}
