using SistemaFacturacion.Controlador;
using SistemaFacturacion.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Vista.Clientes
{
    public partial class frmSeleccionarCliente : Form
    {
        ClienteCtrl clienteCtrl;
        int pagina_actual;
        int elementos_pagina;

        DTO.Cliente cliente_seleccionado;
        public DTO.Cliente Cliente_seleccionado { get { return cliente_seleccionado; } }

        public frmSeleccionarCliente()
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

        private void cargarDGV(DataGridView dgv, List<DTO.Cliente> data)
        {
            dgv.RowCount = 0;
            for (int i = 0; i < data.Count; i++)
            {
                int fila_indice = dgv.Rows.Add();
                dgv.Rows[fila_indice].Cells[0].Value = data[i].Id_Cliente;
                dgv.Rows[fila_indice].Cells[1].Value = data[i].Apellidos;
                dgv.Rows[fila_indice].Cells[2].Value = data[i].Nombres;
            }
        }

        private void frmSeleccionarCliente_Load(object sender, EventArgs e)
        {
            //Una vez se incialice el formulario, mostrar la lista de clientes:
            clienteCtrl = new ClienteCtrl();
            cliente_seleccionado = new DTO.Cliente();

            //Configuración inicial de paginación para los registros en el datagridview
            pagina_actual = 1;
            elementos_pagina = 15;

            //Cargar los datos en el datagridview
            cargarDGV(dgvCliente, clienteCtrl.listarClientes(pagina_actual, elementos_pagina));
            aplicarPaginacion();
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

        private void dgvCliente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.Rows[e.RowIndex].Cells[0].Value == null) return;
                        
            cliente_seleccionado.Id_Cliente = dgvCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            cliente_seleccionado.Nombres = dgvCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            cliente_seleccionado.Apellidos = dgvCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
