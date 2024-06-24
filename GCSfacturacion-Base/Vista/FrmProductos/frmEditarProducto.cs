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
    public partial class frmEditarProducto : Form
    {
        ProductoCtrl productoCtrl;
        DTO.Producto productoDto;

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
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nombre_producto = txtNombreProducto.Text.Trim();
            string precio_unitario_str = txtPrecioUnitario.Text.Trim();
            string iva_str = txtIva.Text.Trim();

            decimal precio_unitario = 0;
            decimal iva = 0;

            //Realizar validaciones
            if (!decimal.TryParse(precio_unitario_str, out precio_unitario)) return;
            if (!decimal.TryParse(iva_str, out iva)) return;

            //Definir los valores correspondientes al objeto de tipo Producto (DTO)
            productoDto.Nombre_producto = nombre_producto;
            productoDto.Precio_unitario = precio_unitario;
            productoDto.Iva = iva;

            //Obtener la respuesta de la ejecución de la inserción de la función
            Respuesta respuesta_insercion = productoCtrl.modificarProducto(productoDto);

            //Mostrar el mensaje
            Mensaje.informacion(respuesta_insercion.Mensaje);

            //Sí se completó correctamente la transacción, cerrar el formulario
            if (respuesta_insercion.Completado) this.Close();
        }
    }
}
