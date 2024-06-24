using System;
using System.Collections.Generic;
using System.Data;
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
}