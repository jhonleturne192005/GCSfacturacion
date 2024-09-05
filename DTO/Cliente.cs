using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SistemaFacturacion.DTO
{
    public class Cliente:Persona
    {

        public string getXml() 
        {
            XElement xml_cliente = new XElement("Cliente");
            xml_cliente.Add(new XElement("Id_cliente", IdPersona));
            xml_cliente.Add(new XElement("Cedula_cliente", Cedula));
            xml_cliente.Add(new XElement("Apellidos", Apellidos));
            xml_cliente.Add(new XElement("Nombres", Nombres));

            return xml_cliente.ToString();
        }        
    }
}
