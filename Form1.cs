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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////panel1.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, new char[3] {'D', 'L', 'T'});
            ////List<Cliente> dataList = new List<Cliente>();
            ////ClienteCtrl ctrl = new ClienteCtrl();
            ////dataList = ctrl.listarClientes(1, 200);

            ////MessageBox.Show(dataList.Count+"");
            ///
            this.reportViewer1.RefreshReport();
            // Crear una lista de objetos con los datos que deseas mostrar en el reporte

            List<Cliente> dataList = new List<Cliente>();
            ClienteCtrl ctrl = new ClienteCtrl();
            FacturaCtrl fctrl = new FacturaCtrl();
            
            dataList = ctrl.listarClientes(1, 1);
            //dataList.RemoveRange(1, dataList.Count - 1);

            List<DTO.Factura> fct = fctrl.listarFacturas(1, 100);
            FacturaDao fdao = new FacturaDao();

            DataSet dsFactura = fdao.visualizarFactura(3);           

            // Asignar la lista como origen de datos para el ReportViewer
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dtCliente", dataList));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dtFactura", dsFactura.Tables[0]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dtFacturaDetalle", dsFactura.Tables[1]));

            // Especificar el nombre del archivo .r
            // Refrescar el reporte
            reportViewer1.RefreshReport();
        }
    }
}
