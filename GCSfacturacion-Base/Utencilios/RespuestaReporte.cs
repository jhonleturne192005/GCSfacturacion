using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
{
    public class RespuestaReporte
    {
        public string NombreReporte { get; }
        public ReportParameter[] ReportParametros { get; }
        public ReportDataSource[] ReportDataSources { get; }

        public RespuestaReporte(string nombre_reporte, ReportParameter[] reporte_parametros, ReportDataSource[] reporte_dataSources)
        {
            this.NombreReporte = nombre_reporte;
            this.ReportParametros = reporte_parametros;
            this.ReportDataSources = reporte_dataSources;
        }
    }
}
