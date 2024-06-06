using SistemaFacturacion.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Vista.Productofrm
{
    public partial class frmListarProductos : Form
    {
        ProductoCtrl productoctrl;
        int pagina_actual;
        int elementos_pagina;

        public frmListarProductos()
        {
            InitializeComponent();
            productoctrl = new ProductoCtrl();
            pagina_actual = 1;
            elementos_pagina = 30;
            cargarDGV(dgvProducto, productoctrl.listarProductos(pagina_actual, elementos_pagina));
        }

        private void cargarDGV(DataGridView dgv, List<DTO.Producto> data)
        {
            dgv.RowCount = 0;
            for (int i = 0; i < data.Count; i++)
            {
                int fila_indice = dgv.Rows.Add();
                dgv.Rows[fila_indice].Cells[0].Value = data[i].id_producto;
                dgv.Rows[fila_indice].Cells[1].Value = data[i].nombre_producto;
                dgv.Rows[fila_indice].Cells[2].Value = data[i].precio_unitario;
                dgv.Rows[fila_indice].Cells[3].Value = data[i].iva;
            }
        }


        private void aplicarPaginacion()
        {
            lblNumeroRegistros.Text = dgvProducto.RowCount.ToString() + " registros";

            if (pagina_actual < 2)
                btnPagAnterior.Enabled = false;
            else
                btnPagAnterior.Enabled = true;

            if (dgvProducto.RowCount < elementos_pagina)
                btnPagSiguiente.Enabled = false;
            else
                btnPagSiguiente.Enabled = true;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistrarProducto fmrregistroproducto = new frmRegistrarProducto();
            fmrregistroproducto.ShowDialog();
        }

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            pagina_actual = pagina_actual + 1;
            cargarDGV(dgvProducto, productoctrl.listarProductos(pagina_actual, elementos_pagina));
            aplicarPaginacion();
        }

        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            pagina_actual = pagina_actual - 1;
            cargarDGV(dgvProducto, productoctrl.listarProductos(pagina_actual, elementos_pagina));
            aplicarPaginacion();
        }

    

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int eliminar_indice = dgvProducto.ColumnCount - 1;
            int modificar_indice = eliminar_indice - 1;
            int visualizar_indice = modificar_indice - 1;
            string id_producto = dgvProducto.Rows[e.RowIndex].Cells[0].Value.ToString();
            string nombre_producto = dgvProducto.Rows[e.RowIndex].Cells[1].Value.ToString();
            string precio = dgvProducto.Rows[e.RowIndex].Cells[2].Value.ToString();
            string iva = dgvProducto.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (e.ColumnIndex == eliminar_indice)
            {
                DialogResult dr=MessageBox.Show("Desea eliminar el producto seleccionado","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string estado_eliminacion=productoctrl.eliminarProducto(int.Parse(id_producto));
                    MessageBox.Show(estado_eliminacion, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    cargarDGV(dgvProducto, productoctrl.listarProductos(pagina_actual, elementos_pagina));
                    aplicarPaginacion();
                }
            }
            else if (e.ColumnIndex == modificar_indice)
            {
                frmActualizarProducto frmVerCliente = new frmActualizarProducto(int.Parse(id_producto), nombre_producto,decimal.Parse(precio),decimal.Parse(iva));
                frmVerCliente.Show();
            }
            else if (e.ColumnIndex == visualizar_indice)
            {
                frmProductoVista frmproductovista = new frmProductoVista(id_producto, nombre_producto, precio,iva);
                frmproductovista.Show();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            cargarDGV(dgvProducto, productoctrl.buscarProducto(txtTextoBuscar.Text,pagina_actual, elementos_pagina));
            aplicarPaginacion();
        }

        private void txtTextoBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtTextoBuscar.Text.Trim()=="")
            {
                cargarDGV(dgvProducto, productoctrl.buscarProducto(txtTextoBuscar.Text, pagina_actual, elementos_pagina));
                aplicarPaginacion();
            }
        }
    }
}
