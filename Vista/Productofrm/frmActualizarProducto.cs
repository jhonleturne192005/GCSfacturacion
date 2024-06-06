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
    public partial class frmActualizarProducto : Form
    {
        ProductoCtrl productoctrl;
        DTO.Producto producto;
        int id_producto;
        string nombre_producto;
        decimal precio;
        decimal iva;
        public frmActualizarProducto(int id_producto,string nombre_producto,decimal precio, decimal iva)
        {
            InitializeComponent();
            productoctrl = new ProductoCtrl();
            producto = new DTO.Producto();
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.precio = precio;
            this.iva = iva;
            asignardatos();
        }


        private void asignardatos()
        {
            txtNombreProducto.Text = this.nombre_producto;
            txtPrecioUnitario.Text = this.precio.ToString();
            txtIva.Text = this.iva.ToString();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre_producto = txtNombreProducto.Text;
            string precio_unitario = txtPrecioUnitario.Text;
            string iva = txtIva.Text;

            producto.id_producto = this.id_producto;
            producto.nombre_producto = nombre_producto;
            producto.precio_unitario = decimal.Parse(precio_unitario);
            producto.iva = decimal.Parse(iva);

            string mensaje = productoctrl.actualizarProducto(producto);
            MessageBox.Show(mensaje);

        }
    }
}
