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
    public partial class frmRegistrarProducto : Form
    {

        ProductoCtrl productoctrl;
        DTO.Producto producto;

        public frmRegistrarProducto()
        {
            InitializeComponent();
            productoctrl = new ProductoCtrl();
            producto = new DTO.Producto();
            txtPrecioUnitario.Text = "0";
            txtIva.Text = "0";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre_producto = txtNombreProducto.Text.Trim();
            string precio_unitario = txtPrecioUnitario.Text.Trim();
            string iva = txtIva.Text.Trim();
            if (nombre_producto != "" && precio_unitario != "" && iva != "")
            {
                producto.Nombre_producto = nombre_producto;
                producto.Precio_unitario = decimal.Parse(precio_unitario);
                producto.Iva = decimal.Parse(iva);

                string [] mensaje = productoctrl.insertarProducto(producto);
                MessageBox.Show(mensaje[1]);
                if (mensaje[0]=="0") { this.Close(); }
                this.Close();
            }
            else
                MessageBox.Show("Error existen campos vacios");
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            validar_numeros(txtPrecioUnitario);
        }

        private void txtIva_TextChanged(object sender, EventArgs e)
        {
            validar_numeros(txtIva);
        }

        private void validar_numeros(TextBox txtbox)
        {
            try
            {
                decimal num = decimal.Parse(txtbox.Text.Trim());
                if (num < 0)
                    txtbox.Text = (num * -1).ToString();
            }
            catch (Exception ex)
            {
                if (txtbox.Text != "")
                {
                    MessageBox.Show("Error");
                    txtbox.Text = "";
                }
            }
        }
    }
}
