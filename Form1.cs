using Microsoft.Reporting.WinForms;
using SistemaFacturacion.Controlador;
using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class Form1 : Form
    {
        int id_factura;
        public Form1()
        {
            InitializeComponent();
            id_factura = 3;
        }
        public Form1(int idFactura)
        {
            InitializeComponent();
            this.id_factura = idFactura;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
                   
            FacturaDao fdao = new FacturaDao();
            DataSet dsFactura = fdao.visualizarFactura(this.id_factura);           

            // Asignar la lista como origen de datos para el ReportViewer
            reportViewer1.LocalReport.DataSources.Clear();

            string ruta = "";
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                ruta = fd.FileName;
            }

            reportViewer1.LocalReport.SetParameters(new ReportParameter("pRutaLogo", @"File:\" + ruta));
         
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dtFactura", dsFactura.Tables[0]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dtFacturaDetalle", dsFactura.Tables[1]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dtFacturaIVA", dsFactura.Tables[2]));

         
            reportViewer1.RefreshReport();
        }
    }
}
