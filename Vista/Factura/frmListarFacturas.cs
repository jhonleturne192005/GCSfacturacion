using SistemaFacturacion.Controlador;
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

namespace SistemaFacturacion.Vista.Factura
{
    public partial class frmListarFacturas : Form
    {
        //Variables de control de la paginación
        int PAGINA_ACTUAL = 1;
        int ELEMENTOS_PAGINA = 30 + 1;

        int ELEMENTOS_OBTENIDOS = 0;

        FacturaCtrl facturaCtrl;

        List<DTO.Factura> lstFactura;
        public frmListarFacturas()
        {
            InitializeComponent();
        }

        private void cargarDGV(DataGridView dgv, List<DTO.Factura> data)
        {
            ELEMENTOS_OBTENIDOS = data.Count;
            lstFactura = data;

            dgv.RowCount = 0;
            for (int i = 0; i < data.Count - 1; i++)
            {
                int fila_indice = dgv.Rows.Add();
                dgv.Rows[fila_indice].Cells[0].Value = data[i].Id_factura;
                dgv.Rows[fila_indice].Cells[1].Value = $"{data[i].Id_cliente.Apellidos} {data[i].Id_cliente.Nombres}";
                dgv.Rows[fila_indice].Cells[2].Value = Math.Round(data[i].Subtotal, 2);
                dgv.Rows[fila_indice].Cells[3].Value = Math.Round(data[i].Total - data[i].Subtotal, 2);
                dgv.Rows[fila_indice].Cells[4].Value = Math.Round(data[i].Total, 2);
            }
        }

        private void frmListarFacturas_Load(object sender, EventArgs e)
        {
            ELEMENTOS_OBTENIDOS = 0;
            facturaCtrl = new FacturaCtrl();

            cargarDGV(dgvFacturas, facturaCtrl.listarFacturas(PAGINA_ACTUAL, ELEMENTOS_PAGINA));

            //Dibujar los bordes según los lados deseados
            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpcionesEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvFacturas.ColumnCount)
            {
                Form1 frmReporte = new Form1();
                frmReporte.Show();
            }
            if (e.ColumnIndex == dgvFacturas.ColumnCount - 1)
            {
                Form1 frmReporte = new Form1();
                frmReporte.Show();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new frmRegistrarFactura().ShowDialog();
        }
    }
}
