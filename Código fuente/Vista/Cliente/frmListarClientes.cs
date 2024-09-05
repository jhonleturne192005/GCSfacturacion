using SistemaFacturacion.Controlador;
using SistemaFacturacion.Dto;
using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Vista
{
    public partial class frmListarClientes : Form
    {
        csClienteCtrl clienteCtrl;
        int pagina_actual;
        int elementos_pagina;

        public frmListarClientes()
        {
            InitializeComponent();
        }

        private void aplicarPaginacion() 
        {
            lblNumeroRegistros.Text = dgvCliente.RowCount.ToString() + " registros";

            if (pagina_actual < 2)            
                btnPagAnterior.Enabled = false;            
            else
                btnPagAnterior.Enabled = true;

            if (dgvCliente.RowCount < elementos_pagina)            
                btnPagSiguiente.Enabled = false;
            else
                btnPagSiguiente.Enabled = true;
        }

        private void cargarDGV(DataGridView dgv, List<csClienteDto> data)
        {
            dgv.RowCount = 0;
            for (int i = 0; i < data.Count; i++)
            {
                int fila_indice = dgv.Rows.Add();
                dgv.Rows[fila_indice].Cells[0].Value = data[i].Cedula;
                dgv.Rows[fila_indice].Cells[1].Value = data[i].Apellidos;
                dgv.Rows[fila_indice].Cells[2].Value = data[i].Nombres;
            }
        }

        private void frmListarClientes_Load(object sender, EventArgs e)
        {
            //Una vez se incialice el formulario, mostrar la lista de clientes:
            clienteCtrl = new csClienteCtrl();

            //Configuración inicial de paginación para los registros en el datagridview
            pagina_actual = 1;
            elementos_pagina = 30;

            //Cargar los datos en el datagridview
            cargarDGV(dgvCliente, clienteCtrl.listarClientes(pagina_actual, elementos_pagina));
            aplicarPaginacion();

            //Dibujar los bordes según los lados deseados
            pnlEncabezado.Paint += (s, ev) => csDisenio.dibujarBordesControl(s, ev, 'D');
            pnlOpcionesEncabezado.Paint += (s, ev) => csDisenio.dibujarBordesControl(s, ev, 'D');
        }

        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            pagina_actual = pagina_actual - 1;
            cargarDGV(dgvCliente, clienteCtrl.listarClientes(pagina_actual, elementos_pagina));

            aplicarPaginacion();
        }

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            pagina_actual = pagina_actual + 1;
            cargarDGV(dgvCliente, clienteCtrl.listarClientes(pagina_actual, elementos_pagina));

            aplicarPaginacion();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int eliminar_indice = dgvCliente.ColumnCount - 1;
            int modificar_indice = eliminar_indice - 1;
            int visualizar_indice = modificar_indice - 1;
            string id_cliente = dgvCliente.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (e.ColumnIndex == eliminar_indice)
            {
                
            }
            else if (e.ColumnIndex == modificar_indice)
            {
                
            }
            else if (e.ColumnIndex == visualizar_indice)
            {
                frmVisualizarCliente frmVerCliente = new frmVisualizarCliente(id_cliente);
                frmVerCliente.Show();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente frmRegistrarCliente = new frmRegistrarCliente();
            frmRegistrarCliente.ShowDialog();
        }
    }
}
