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

namespace SistemaFacturacion.Vista.Productofrm
{
    public partial class frmListarProductos : Form
    {
        ProductoCtrl productoCtrl;

        //Variables de control de la paginación
        int PAGINA_ACTUAL;
        int ELEMENTOS_PAGINA;
        int ELEMENTOS_OBTENIDOS;

        List<DTO.Producto> lstProductos;

        public frmListarProductos()
        {
            InitializeComponent();
        }

        private void cargarDGV(DataGridView dgv, List<DTO.Producto> data)
        {
            ELEMENTOS_OBTENIDOS = data.Count;
            lstProductos = data;

            //Reiniciar la cantidad de filas del datagridview
            dgv.RowCount = 0;

            //Calcular la cantidad de filas que se crearán
            int filas_dgv = ELEMENTOS_OBTENIDOS == ELEMENTOS_PAGINA ? ELEMENTOS_OBTENIDOS - 1 : ELEMENTOS_OBTENIDOS;

            //Establecer los datos de la página actual en el dgv            
            for (int i = 0; i < filas_dgv; i++)
            {
                int fila_indice = dgv.Rows.Add();
                dgv.Rows[fila_indice].Cells[0].Value = data[i].Id_producto;
                dgv.Rows[fila_indice].Cells[1].Value = data[i].Nombre_producto;
                dgv.Rows[fila_indice].Cells[2].Value = data[i].Precio_unitario;
                dgv.Rows[fila_indice].Cells[3].Value = data[i].Iva;
            }

            aplicarPaginacion();
        }
        private void aplicarPaginacion()
        {
            lblNumeroRegistros.Text = $"{dgvProducto.RowCount.ToString()} registros";

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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistrarProducto fmrregistroproducto = new frmRegistrarProducto();
            fmrregistroproducto.ShowDialog();
        }

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            PAGINA_ACTUAL = PAGINA_ACTUAL + 1;
            cargarDGV(dgvProducto, productoCtrl.buscarProducto(PAGINA_ACTUAL, ELEMENTOS_PAGINA, txtTextoBuscar.Text));
            aplicarPaginacion();
        }

        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            PAGINA_ACTUAL = PAGINA_ACTUAL - 1;
            cargarDGV(dgvProducto, productoCtrl.buscarProducto(PAGINA_ACTUAL, ELEMENTOS_PAGINA, txtTextoBuscar.Text));
            aplicarPaginacion();
        }
        private void eliminarProducto(int id_producto)
        {
            bool desea_eliminar = Mensaje.pregunta($"¿Está seguro que desea eliminar el producto?");
            if (desea_eliminar)
            {
                Respuesta r = productoCtrl.eliminarProducto(id_producto);
                Mensaje.informacion(r.Mensaje);
            }
        }
        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int eliminar_indice = dgvProducto.ColumnCount - 1;
            int modificar_indice = eliminar_indice - 1;
            int visualizar_indice = modificar_indice - 1;

            int id_producto = int.Parse(dgvProducto.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (e.ColumnIndex == eliminar_indice)
            {
                eliminarProducto(id_producto);
                cargarDGV(dgvProducto, productoCtrl.buscarProducto(PAGINA_ACTUAL, ELEMENTOS_PAGINA, txtTextoBuscar.Text));
            }
            else if (e.ColumnIndex == modificar_indice)
            {
                frmEditarProducto frmeEditarProducto = new frmEditarProducto(id_producto);
                frmeEditarProducto.ShowDialog();

                cargarDGV(dgvProducto, productoCtrl.buscarProducto(PAGINA_ACTUAL, ELEMENTOS_PAGINA, txtTextoBuscar.Text));
            }
            else if (e.ColumnIndex == visualizar_indice)
            {
                frmVisualizarProducto frmproductovista = new frmVisualizarProducto(id_producto);
                frmproductovista.ShowDialog();
            }
        }

        private void txtTextoBuscar_TextChanged(object sender, EventArgs e)
        {
            //Reiniciar la paginación puesto que es una nueva búsqueda
            PAGINA_ACTUAL = 1;

            //Realizar la búsqueda haciendo uso de la paginación
            cargarDGV(dgvProducto, productoCtrl.buscarProducto(PAGINA_ACTUAL, ELEMENTOS_PAGINA, txtTextoBuscar.Text));
        }

        private void frmListarProductos_Load(object sender, EventArgs e)
        {
            //Variables para la paginación
            PAGINA_ACTUAL = 1;
            ELEMENTOS_PAGINA = 30 + 1;
            ELEMENTOS_OBTENIDOS = 0;

            //Una vez se incialice el formulario, mostrar la lista de productos:
            productoCtrl = new ProductoCtrl();            

            //Cargar los datos en el datagridview
            cargarDGV(dgvProducto, productoCtrl.listarProductos(PAGINA_ACTUAL, ELEMENTOS_PAGINA));


            //Dibujar los bordes según los lados deseados
            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpcionesEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlContenedorBusqueda.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev);
        }
    }
}
