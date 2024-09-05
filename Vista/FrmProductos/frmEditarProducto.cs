using SistemaFacturacion.Controlador;
using SistemaFacturacion.Utencilios;
using SistemaFacturacion.DTO;
using System;
using SistemaFacturacion.Vista.FrmProveedores;

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
    public partial class frmEditarProducto : Form
    {
        ProductoCtrl productoCtrl;
        DTO.Producto productoDto;
        Proveedor proveedor;

        int id_producto;
        
        public frmEditarProducto(int id_producto)
        {
            InitializeComponent();
            this.id_producto = id_producto;
        }

        private void frmActualizarProducto_Load(object sender, EventArgs e)
        {
            productoCtrl = new ProductoCtrl();

            //Cargar los datos del cliente seleccionado
            productoDto = productoCtrl.getProducto(id_producto);
            this.proveedor = productoDto.Proveedor;


            //Sí no se obtuvo nada al buscar el cliente que corresponda el id, 
            //cerrar el formulario
            if (productoDto == null)
            {
                this.Close();
            }
            else
            {
                //Cargar datos a los controles del formulario
                txtNombreProducto.Text = productoDto.Nombre_producto;
                txtPrecioUnitario.Text = productoDto.Precio_unitario.ToString();
                txtIva.Text = productoDto.Iva.ToString();

                txtNombreProveedor.Text = $"{this.proveedor.Apellidos} {this.proveedor.Nombres}";
                txtCedulaProveedor.Text = $"{this.proveedor.Cedula}";
            }

            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpciones.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
        }

        private void btnEditar_Click(object sender, EventArgs e)
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
            productoDto.Proveedor = this.proveedor;

            //Obtener la respuesta de la ejecución de la inserción de la función
            Respuesta respuesta_insercion = productoCtrl.modificarProducto(productoDto);

            //Mostrar el mensaje
            Mensaje.informacion(respuesta_insercion.Mensaje);

            //Sí se completó correctamente la transacción, cerrar el formulario
            if (respuesta_insercion.Completado) this.Close();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmListarProveedor frmSeleccionar = new frmListarProveedor(seleccionar: true);
            frmSeleccionar.ShowDialog();

            //Solo sí se seleccionó un cliente establecer los valores
            if (frmSeleccionar.proveedor_seleccionado != null)
            {
                this.proveedor = frmSeleccionar.proveedor_seleccionado;

                this.txtCedulaProveedor.Text = frmSeleccionar.proveedor_seleccionado.Cedula;
                this.txtNombreProveedor.Text = frmSeleccionar.proveedor_seleccionado.Apellidos + " " +
                    frmSeleccionar.proveedor_seleccionado.Nombres;

            }
        }
    }
}
