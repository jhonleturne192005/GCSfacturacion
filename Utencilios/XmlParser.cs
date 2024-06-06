using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SistemaFacturacion.Utencilios
{
    public static class XmlParser
    {
        /// <summary>
        /// Función que transforma un objeto a formato xml.
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public static string parsearXml(Object objeto)
        {            
            XmlSerializer xml = new XmlSerializer(objeto.GetType());
            StringWriter strWriter = new StringWriter();

            xml.Serialize(strWriter, objeto);
          

            return strWriter.ToString();
        }
    }
}