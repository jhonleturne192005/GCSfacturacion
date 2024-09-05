using SistemaFacturacion.Controlador;
using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista.FrmProveedores;
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

        ProductoCtrl productoCtrl;
        DTO.Producto productoDto;
        DTO.Proveedor proveedor; 

        public frmRegistrarProducto()
        {
            InitializeComponent();            
        }
        private void frmRegistrarProducto_Load(object sender, EventArgs e)
        {
            productoCtrl = new ProductoCtrl();
            productoDto = new DTO.Producto();
            txtPrecioUnitario.Text = "0";
            txtIva.Text = "0";

            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpciones.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre_producto = txtNombreProducto.Text.Trim();
            string precio_unitario_str = txtPrecioUnitario.Text.Trim();
            string iva_str = txtIva.Text.Trim();

            decimal precio_unitario = 0;
            decimal iva = 0;

            //NOMBRE DEL PRODUCTO
            if (string.IsNullOrWhiteSpace(nombre_producto))
            {
                Mensaje.advertencia("El nombre del producto es requerido");
                return;
            }

            if (nombre_producto.Length > 30)
            {
                Mensaje.advertencia("El nombre del producto no puede superar una longitud de 30 caracteres");
                return;
            }

            //PRECIO UNITARIO (PU)
            if (!decimal.TryParse(precio_unitario_str, out precio_unitario))
            {
                Mensaje.advertencia("El precio unitario del producto contiene caracteres no válidos");
                return;
            }

            if (precio_unitario_str.Length > 14)
            {
                Mensaje.advertencia("El precio unitario debe contener un máximo de 10 números enteros y 4 decimales");
                return;
            }

            if (precio_unitario <= 0)
            {
                Mensaje.advertencia("El precio unitario debe ser un valor mayor que $0,00");
                return;
            }

            //IVA
            if (iva_str.Length > 5)
            {
                Mensaje.advertencia("El IVA debe contener un máximo de 3 números enteros y 2 decimales");
                return;
            }

            if (!decimal.TryParse(iva_str, out iva))
            {
                Mensaje.advertencia("El iva del producto contiene caracteres no válidos");
                return;
            }

            if (iva < 0 || iva > 100)
            {
                Mensaje.advertencia("El IVA debe estar en un porcentaje entre 0 y 100");
                return;
            }

            if (proveedor == null)
            {
                Mensaje.advertencia("Debe seleccionar un proveedor");
                return;
            }

            if (txtCedulaProveedor.Text.Trim() == "")
            {
                Mensaje.advertencia("Debe seleccionar un proveedor");
                return;
            }

            //Definir los valores correspondientes al objeto de tipo Producto (DTO)
            productoDto.Nombre_producto = nombre_producto;
            productoDto.Precio_unitario = precio_unitario;
            productoDto.Iva = iva;

            //Asignar el objeto proveedor al producto para su posterior inserción
            productoDto.Proveedor = this.proveedor;

            //Ejecutar el procedimiento para la inserción del producto
            Respuesta respuesta = productoCtrl.insertarProducto(productoDto);

            //Mostrar el mensaje resultante de la ejecución
            Mensaje.informacion(respuesta.Mensaje);

            //Sí se completo la transacción cerrar el formulario
            if (respuesta.Completado) this.Close();          
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmListarProveedor frmSeleccionar = new frmListarProveedor(seleccionar: true);
            frmSeleccionar.ShowDialog();

            //Solo sí se seleccionó un proveedor establecer los valores
            if (frmSeleccionar.proveedor_seleccionado != null)
            {
                this.proveedor = frmSeleccionar.proveedor_seleccionado;

                this.txtCedulaProveedor.Text = frmSeleccionar.proveedor_seleccionado.Cedula;
                this.txtEmailProveedor.Text = frmSeleccionar.proveedor_seleccionado.Email;
                this.txtNombreProveedor.Text = frmSeleccionar.proveedor_seleccionado.Apellidos + " " +
                    frmSeleccionar.proveedor_seleccionado.Nombres;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
