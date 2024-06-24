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
    public partial class frmVisualizarProducto : Form
    {
        DTO.Producto productoDto;
        ProductoCtrl productoCtrl;

        int id_producto;
        public frmVisualizarProducto(int id_producto)
        {
            InitializeComponent();
            this.id_producto = id_producto;
        }

        private void frmProductoVista_Load(object sender, EventArgs e)
        {
            productoCtrl = new ProductoCtrl();
            productoDto = productoCtrl.getProducto(id_producto);

            if (productoDto != null)
            {
                txtNombreProducto.Text = productoDto.Nombre_producto;
                txtPrecioUnitario.Text = productoDto.Precio_unitario.ToString();
                txtIva.Text = productoDto.Iva.ToString();
            }           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
