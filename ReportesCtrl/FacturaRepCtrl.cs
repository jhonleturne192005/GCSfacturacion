using Microsoft.Reporting.WinForms;
using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SistemaFacturacion.ReportesCtrl
{
    class FacturaRepCtrl
    {
        FacturaDao facturaDao;
        public FacturaRepCtrl()
        {
            facturaDao = new FacturaDao();
        }

        public RespuestaReporte getFactura(int id_factura)
        {
            //DataTable dtFactura = facturaDao.getXmlFactura(id_factura);
            XmlDocument xmlFactura = facturaDao.getXmlFactura(id_factura);

            XmlNode encabezado = xmlFactura.GetElementsByTagName("Encabezado")[0];
            XmlNode detalle = xmlFactura.GetElementsByTagName("Detalle")[0];
            XmlNode impuestos = xmlFactura.GetElementsByTagName("Impuestos")[0];
                        
            //DataTable dt = XmlParser.xmlADataTable("<Factura><Encabezado><Id_factura>13</Id_factura><Id_cliente>2350702312</Id_cliente><Apellidos>Alonso</Apellidos><Nombres>Renataaaaaaa</Nombres><Fecha>2024-06-09T18:06:34.103</Fecha><Subtotal>194.7600</Subtotal><Total>209.2087</Total></Encabezado><Detalle><Detalle><Id_factura_detalle>23</Id_factura_detalle><Id_producto>1</Id_producto><Nombre_producto>Arrozzzzzdd344</Nombre_producto><Cantidad>2.00</Cantidad><Precio>14.0896000000</Precio><Total>68.2100</Total></Detalle><Detalle><Id_factura_detalle>24</Id_factura_detalle><Id_producto>2</Id_producto><Nombre_producto>Azúcara</Nombre_producto><Cantidad>1.00</Cantidad><Precio>3.0800000000</Precio><Total>68.2100</Total></Detalle><Detalle><Id_factura_detalle>25</Id_factura_detalle><Id_producto>5</Id_producto><Nombre_producto>Manzanas</Nombre_producto><Cantidad>3.00</Cantidad><Precio>3.6915000000</Precio><Total>68.2100</Total></Detalle><Detalle><Id_factura_detalle>26</Id_factura_detalle><Id_producto>9</Id_producto><Nombre_producto>Café</Nombre_producto><Cantidad>4.00</Cantidad><Precio>7.6125000000</Precio><Total>68.2100</Total></Detalle><Detalle><Id_factura_detalle>27</Id_factura_detalle><Id_producto>14</Id_producto><Nombre_producto>Pescado</Nombre_producto><Cantidad>5.00</Cantidad><Precio>13.6425000000</Precio><Total>68.2100</Total></Detalle></Detalle><Impuestos><DetalleIVA><IVA>5.00</IVA><Total>4.4625</Total></DetalleIVA><DetalleIVA><IVA>7.00</IVA><Total>8.9250</Total></DetalleIVA><DetalleIVA><IVA>12.00</IVA><Total>8.9250</Total></DetalleIVA></Impuestos></Factura>");

            DataTable dtEncabezado = XmlParser.xmlADataTable(encabezado.OuterXml);
            DataTable dtDetalle = XmlParser.xmlADataTable(detalle.OuterXml);
            DataTable dtImpuestos = XmlParser.xmlADataTable(impuestos.OuterXml);
            
            ReportDataSource[] rds =
            {
                new ReportDataSource("dtFactura", dtEncabezado),
                new ReportDataSource("dtFacturaDetalle", dtDetalle),
                new ReportDataSource("dtFacturaIVA", dtImpuestos)
            };

            ReportParameter[] rp =
            {
                    new ReportParameter("pRutaLogo", $@"File:\{DatosEstaticos.rutaLogo}")
            };

            return new RespuestaReporte("rpFactura.rdlc", rp, rds);
        } 
    }
}
