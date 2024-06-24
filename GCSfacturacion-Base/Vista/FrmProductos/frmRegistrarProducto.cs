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
    public partial class frmRegistrarProducto : Form
    {

        ProductoCtrl productoCtrl;
        DTO.Producto productoDto;

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
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre_producto = txtNombreProducto.Text.Trim();
            string precio_unitario_str = txtPrecioUnitario.Text.Trim().Replace('.', ',');
            string iva_str = txtIva.Text.Trim().Replace('.', '.');

            decimal precio_unitario = 0;
            decimal iva = 0;

            //Realizar las validaciones para los datos

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
            if(iva_str.Length > 5)
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

            //Definir los valores para el objeto Dto de producto
            productoDto.Nombre_producto = nombre_producto;
            productoDto.Precio_unitario = precio_unitario;
            productoDto.Iva = iva;

            //Ejecutar el procedimiento para la inserción del producto
            Respuesta respuesta = productoCtrl.insertarProducto(productoDto);

            //Mostrar el mensaje resultante de la ejecución
            Mensaje.informacion(respuesta.Mensaje);

            //Sí se completo la transacción cerrar el formulario
            if (respuesta.Completado) this.Close();          
        }
    }
}
