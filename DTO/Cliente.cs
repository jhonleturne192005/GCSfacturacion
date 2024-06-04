using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SistemaFacturacion.DTO
{
    public class Cliente
    {
        public string Id_Cliente { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }



        public string getXml() { return XmlParser.parsearXml(this); }
        public static string getXml(List<Cliente> lstClientes) { return XmlParser.parsearXml(lstClientes); }
    }
}
