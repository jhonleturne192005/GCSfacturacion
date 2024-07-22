using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
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

        public static DataTable xmlADataTable(string xmlString)
        {
            DataSet dataSet = new DataSet();
            DataTable dt = null;

            using (StringReader sr = new StringReader(xmlString))
            {
                dataSet.ReadXml(sr);
                if (dataSet.Tables.Count > 0)
                {
                    dt = dataSet.Tables[0];
                }
            }


            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    if (col.DataType == typeof(decimal))
                    {
                        System.Windows.Forms.MessageBox.Show("Test");
                        //Reemplazar el punto decimal con coma si es necesario
                        row[col] = row[col].ToString().Replace('.', ',');
                    }
                }
            }

            return dt;
        }
    }

    public class Filtros
    {
        public string nombre_parametro;
        public string valor;

        public Filtros(string nombre_parametro, string valor)
        {
            this.nombre_parametro = nombre_parametro;
            this.valor = valor;
        }

        public static string filtros_a_xml(string nombre_xml, List<Filtros> lst_filtros)
        {
            XElement xml_filtros = new XElement(nombre_xml);
            for (int i = 0; i < lst_filtros.Count; i++)
            {
                xml_filtros.Add(new XElement(lst_filtros[i].nombre_parametro, lst_filtros[i].valor));
            }

            return xml_filtros.ToString();

        }
    }
}