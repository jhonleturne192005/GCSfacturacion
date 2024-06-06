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
    public partial class frmProductoVista : Form
    {
        public frmProductoVista(string id_producto,string nombre_producto,string precio_producto,string iva_producto)
        {
            InitializeComponent();
            cargar_datos(id_producto,nombre_producto,precio_producto,iva_producto);
        }

        private void cargar_datos(string id_producto, string nombre_producto, string precio_producto, string iva_producto)
        {
            lblidproducto.Text = id_producto;
            lblproductonombre.Text = nombre_producto;
            lblprecioproducto.Text = precio_producto;
            lblivaproducto.Text = iva_producto;
        }

        private void lblproductonombre_Click(object sender, EventArgs e)
        {

        }
    }
}
