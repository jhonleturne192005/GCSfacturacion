using Microsoft.Reporting.WinForms;
using SistemaFacturacion.Controlador;
using SistemaFacturacion.DAO;
using SistemaFacturacion.ReportesCtrl;
using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista.FrmReportes;
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
        int PAGINA_ACTUAL;
        int ELEMENTOS_PAGINA;
        int ELEMENTOS_OBTENIDOS;

        FacturaCtrl facturaCtrl;

        List<DTO.Factura> lstFactura;
        public frmListarFacturas()
        {
            InitializeComponent();
        }

        private void actualizarBusqueda(int PAGINA_ACTUAL, int ELEMENTOS_PAGINA)
        {
            //Juntar los filtros de búsqueda establecidos en el formulario
            List<Filtros> filtros = new List<Filtros>();
            filtros.Add(new Filtros("campo_busqueda", cmbFiltros.SelectedValue.ToString()));
            filtros.Add(new Filtros("texto_buscar", txtTextoBuscar.Text));
            filtros.Add(new Filtros("fecha_inicio", dtpFechaInicio.Value.Date.ToString("yyyy-MM-dd")));
            filtros.Add(new Filtros("fecha_fin", dtpFechaFin.Value.Date.ToString("yyyy-MM-dd")));

            cargarDGV(dgvFacturas, facturaCtrl.buscarFacturas(PAGINA_ACTUAL, ELEMENTOS_PAGINA, Filtros.filtros_a_xml("Filtros", filtros)));
        }
        private void aplicarPaginacion()
        {
            lblNumeroRegistros.Text = $"{dgvFacturas.RowCount.ToString()} registros";

            //Se puede retroceder la página siempre y cuando el usuario se encuentre en una
            //página mayor a 1
            if (PAGINA_ACTUAL < 2)
                btnPagAnterior.Enabled = false;
            else
                btnPagAnterior.Enabled = true;

            //Se solicitan la cantidad de elementos + 1 para verificar si hay una página adicional
            //Sí la cantidad de datos obtenidas es exactamente el mismo número requerido (+1) entonces
            //existe una página adicional y se puede seguir avanzando
            if (ELEMENTOS_OBTENIDOS < ELEMENTOS_PAGINA)
                btnPagSiguiente.Enabled = false;
            else
                btnPagSiguiente.Enabled = true;
        }

        private void cargarDGV(DataGridView dgv, List<DTO.Factura> data)
        {
            ELEMENTOS_OBTENIDOS = data.Count;
            lstFactura = data;

            //Reiniciar la cantidad de filas del datagridview
            dgv.RowCount = 0;

            //Calcular la cantidad de filas que se crearán
            int filas_dgv = ELEMENTOS_OBTENIDOS == ELEMENTOS_PAGINA ? ELEMENTOS_OBTENIDOS - 1 : ELEMENTOS_OBTENIDOS;

            //Establecer los datos de la página actual en el dgv
            for (int i = 0; i < filas_dgv; i++)
            {
                int fila_indice = dgv.Rows.Add();
                dgv.Rows[fila_indice].Cells[0].Value = data[i].Id_factura;
                dgv.Rows[fila_indice].Cells[1].Value = $"{data[i].Cliente.Apellidos} {data[i].Cliente.Nombres}";
                dgv.Rows[fila_indice].Cells[2].Value = $"{data[i].Empleado.Apellidos} {data[i].Empleado.Nombres}";
                dgv.Rows[fila_indice].Cells[3].Value = Math.Round(data[i].Subtotal, 2);
                dgv.Rows[fila_indice].Cells[4].Value = Math.Round(data[i].Total - data[i].Subtotal, 2);
                dgv.Rows[fila_indice].Cells[5].Value = Math.Round(data[i].Total, 2);
                dgv.Rows[fila_indice].Cells[6].Value = DateTime.Parse(data[i].Fecha).ToString("dd-MM-yyyy");
            }

            //Posterior a la carga de datos, habilitar o no las opciones de cambio
            //de página, basándose en los resultados
            aplicarPaginacion();
        }

        private void frmListarFacturas_Load(object sender, EventArgs e)
        {
            //Variables para controlar la paginación
            PAGINA_ACTUAL = 1;
            ELEMENTOS_PAGINA = 30 + 1;
            ELEMENTOS_OBTENIDOS = 0;

            facturaCtrl = new FacturaCtrl();

            //Cargar los filtros de búsqueda a los combobox            
            cmbFiltros.DataSource = facturaCtrl.getFiltrosBusqueda();
            cmbFiltros.DisplayMember = "ValorMostrar";
            cmbFiltros.ValueMember = "ValorMiembro";
        
            //Cargar el datagridview con las facturas correspondientes
            //cargarDGV(dgvFacturas, facturaCtrl.listarFacturas(PAGINA_ACTUAL, ELEMENTOS_PAGINA));

            dtpFechaInicio.Value = new DateTime(2024, 01, 01);
            dtpFechaFin.Value = DateTime.Today;

            //Dibujar los bordes según los lados deseados
            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpcionesEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlContenedorBusqueda.Paint += (s, ev) => Disenio.dibujarBordesControlLados(s, ev);
            dgvFacturas.DataSource = null;

        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            int id_factura = int.Parse(dgvFacturas.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (e.ColumnIndex == dgvFacturas.ColumnCount - 1)
            {
                FacturaRepCtrl facturaRep = new FacturaRepCtrl();
                frmVisualizarReporte frmReporte = new frmVisualizarReporte(facturaRep.getFactura(id_factura));

                frmReporte.Show();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new frmRegistrarFactura().ShowDialog();
        }

        private void txtTextoBuscar_TextChanged(object sender, EventArgs e)
        {            
            //PAGINA_ACTUAL = 1;
            //actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
        }

        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            PAGINA_ACTUAL = PAGINA_ACTUAL - 1;
            actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
        }

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            PAGINA_ACTUAL = PAGINA_ACTUAL + 1;
            actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtTextoBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar si la tecla presionada es Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                //Reiniciar la paginación puesto que es una nueva búsqueda
                PAGINA_ACTUAL = 1;
                actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
            }
        }

        private void dtpFechaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);

        }

        private void dtpFechaInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);

        }
    }
}
