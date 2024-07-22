using Microsoft.Reporting.WinForms;
using SistemaFacturacion.DAO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Vista.FrmReportes
{
    public partial class frmVisualizarReporte : Form
    {       
        RespuestaReporte respuestaRep;   

        public frmVisualizarReporte(RespuestaReporte respuesta)
        {
            InitializeComponent();
            respuestaRep = respuesta;
        }

        private void frmVisualizarReporte_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            
            ArchivosReporte archivoRdlc = Reportes.getReporte(respuestaRep.NombreReporte);
            reportViewer1.LocalReport.ReportPath = archivoRdlc.Ruta;

            reportViewer1.LocalReport.SetParameters(respuestaRep.ReportParametros);

            for (int i = 0; i < respuestaRep.ReportDataSources.Length; i++)
            {                
                reportViewer1.LocalReport.DataSources.Add(respuestaRep.ReportDataSources[i]);
            }


            reportViewer1.RefreshReport();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
        }
    }
}
