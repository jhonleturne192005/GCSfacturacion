using SistemaFacturacion.Controlador;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Vista.Factura
{
    public partial class frmRegistrarFactura : Form
    {
        //Controladores
        ProductoCtrl productoCtrl;
        ClienteCtrl clienteCtrl;
        FacturaCtrl facturaCtrl;

        //DTO para el control de objetos
        DTO.Factura facturaDto;

        //Variables de control para la selección de items
        int fila_producto_seleccionada;


        public frmRegistrarFactura()
        {
            InitializeComponent();
        }

        private void cargarProductosDGV(DataGridView dgv, List<Producto> data)
        {
            dgv.RowCount = 0;
            for (int i = 0; i < data.Count; i++)
            {
                int fila_indice = dgv.Rows.Add();
                dgv.Rows[fila_indice].Cells[0].Value = data[i].Id_producto;
                dgv.Rows[fila_indice].Cells[1].Value = data[i].Nombre_producto;
                dgv.Rows[fila_indice].Cells[2].Value = Math.Round(data[i].Precio_unitario, 2);
            }
        }

        private void restaurarCodigoProductoFactura(int indice_fila)
        {
            dgvProductosFactura.Rows[indice_fila].Cells[0].Value = dgvProductosFactura.Rows[indice_fila].Cells[6].Value;
        }
               

        private void actualizarDetalleDGV(int indice_fila, DTO.FacturaDetalle detalle)
        {
            //Actualizar los datos al detalle del índice correspondiente
            dgvProductosFactura.Rows[indice_fila].Cells[0].Value = detalle.Producto.Id_producto;
            dgvProductosFactura.Rows[indice_fila].Cells[1].Value = detalle.Producto.Nombre_producto;
            dgvProductosFactura.Rows[indice_fila].Cells[2].Value = detalle.Cantidad;
            dgvProductosFactura.Rows[indice_fila].Cells[3].Value = Math.Round(detalle.Subtotal, 2);
            dgvProductosFactura.Rows[indice_fila].Cells[4].Value = Math.Round(detalle.Total, 2);
            dgvProductosFactura.Rows[indice_fila].Cells[5].Value = detalle.Producto.Iva;

            //Guardar el id del producto que determinado válido para posteriores validaciones
            dgvProductosFactura.Rows[indice_fila].Cells[6].Value = detalle.Producto.Id_producto;
        }

        private bool agregarProductoFactura(int indice_fila, int id_producto)
        {
            //Verificar que le producto no haya sido registrado en la factura
            if (facturaDto.existeProductoFactura(id_producto))
            {
                Mensaje.advertencia("El producto seleccionado ya ha sido registrado en la factura");                
                return false;
            }

            //Buscar un producto que coincide con el ingresado por le usuario
            Producto producto = productoCtrl.getProducto(id_producto);

            //Sí el producto no existe mostrar el mensaje de advertencia la usuario
            if (producto == null)
            {
                Mensaje.advertencia("El código del producto ingresado no existe");
                return false;
            }

            //Agregar el producto a la lista de productos del detalle de la factura
            FacturaDetalle factura_detalle = new FacturaDetalle(producto, 1);
            facturaDto.agregarDetalleFactura(indice_fila, factura_detalle);

            //Insertar los valores en la fila correspondiente
            actualizarDetalleDGV(indice_fila, factura_detalle);

            //Agregar una nueva fila en la lista de productos solo sí se ingresó correctamente y
            //en la penúltima fila
            if (indice_fila == dgvProductosFactura.RowCount - 1)
            {                
                dgvProductosFactura.Rows.Add();
            }

            //Después de insertar los datos actualizarl los totales de la factura
            calcularTotalesFactura();
            return true;           
        }

        private void calcularDetalleFactura(int indice, decimal cantidad)
        {
            facturaDto.Factura_Detalle[indice].Cantidad = cantidad;
            facturaDto.Factura_Detalle[indice].calcular();

            actualizarDetalleDGV(indice, facturaDto.Factura_Detalle[indice]);            
        }

        private void calcularTotalesFactura()
        {
            //Calcular el subtotal y total de la factura
            facturaDto.calcular();
            
            //Calcular le IVA
            decimal iva_acumulado = facturaDto.Total - facturaDto.Subtotal;

            //Establecer los valores totales:
            lblSubtotal.Text = $"$ {Math.Round(facturaDto.Subtotal, 2)}";
            lblTotal.Text = $"$ {Math.Round(facturaDto.Total, 2)}";
            lblIva.Text = $"$ {Math.Round(iva_acumulado, 2)}";
        }

        private void frmRegistrarFactura_Load(object sender, EventArgs e)
        {
            productoCtrl = new ProductoCtrl();
            clienteCtrl = new ClienteCtrl();
            facturaCtrl = new FacturaCtrl();

            facturaDto = new DTO.Factura();

            //Cargar la lista de productos
            //cargarProductosDGV(dgvProductos, productoCtrl.listarProductos());

            //Cargar por defecto una fila en la lista de los productos en factura
            dgvProductosFactura.Rows.Add();

            //Dibujar los bordes según los lados deseados
            pnlTotalesFactura.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
            pnlCliente.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlDatosFactura.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlEncabezadoProductos.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');

            pnlDgvProductos.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'R');
            pnlBuscarProducto.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'R');
            pnlOpcionesProducto.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
            pnlOpcionesProducto.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'R');
        }
        
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtener el producto seleccionado por el usuario
            fila_producto_seleccionada = e.RowIndex;
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount == 0) return;

            //Función que envía la fila del producto seleccionado al detalle de la factura
            int id_producto = int.Parse(dgvProductos.Rows[fila_producto_seleccionada].Cells[0].Value.ToString());

            //Agregar el producto al detalle en al penúltima posición
            agregarProductoFactura(dgvProductosFactura.RowCount - 1, id_producto);
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.RowCount == 0) return;

            //Función que envía la fila del producto seleccionado al detalle de la factura
            int id_producto = int.Parse(dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString());

            //Agregar el producto al detalle en al penúltima posición
            agregarProductoFactura(dgvProductosFactura.RowCount - 1, id_producto);
        }

        private void dgvProductosFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Obtener la celda que se finalizó de editar
            DataGridViewCell dgvFilaSeleccionada = dgvProductosFactura.Rows[e.RowIndex].Cells[e.ColumnIndex];
            bool se_inserto_producto = false;

            //Modificación del código del producto
            if (e.ColumnIndex == 0) { 

                //Verificar que el valor de la celda no sea nulo, sí es nulo restaurar al valor previo
                if (dgvFilaSeleccionada.Value == null)
                {
                    restaurarCodigoProductoFactura(e.RowIndex);
                    return;
                }

                //Verificar que el valor ingresado sea numérico
                int id_producto = 0;
                if (!int.TryParse(dgvFilaSeleccionada.Value.ToString(), out id_producto)) return;

                //Verificar si es posible agregar el producto a lista de detalle de la factura
                se_inserto_producto = agregarProductoFactura(e.RowIndex, id_producto);

                //Sí no se pudo insertar restaurar el código al valor anterior
                if (!se_inserto_producto) restaurarCodigoProductoFactura(e.RowIndex);
                
            }
            //Modificación de la cantidad del producto
            else if (e.ColumnIndex == 2) { 

                //Verificar que el valor de la celda no sea nulo, sí lo es colocar por defecto el valor de 1
                if (dgvFilaSeleccionada.Value == null) dgvFilaSeleccionada.Value = 1;

                //Sí no hay precio unitario entonces no hay producto, por lo tanto se restaura el valor
                if (dgvProductosFactura.Rows[e.RowIndex].Cells[3].Value == null)
                {
                    dgvFilaSeleccionada.Value = null;
                    return;
                }

                //Obtener la cantidad ingresada por el usuario
                //Sí no es un valor numérico o lo es pero negativo dejar por defecto la unidad como cantidad
                decimal cantidad = 0;
                if (!decimal.TryParse(dgvFilaSeleccionada.Value.ToString(), out cantidad))
                {
                    dgvFilaSeleccionada.Value = 1;
                }
                if (cantidad < 0)
                {
                    dgvFilaSeleccionada.Value = 1;
                }

                //Actualizar los cálculos
                calcularDetalleFactura(e.RowIndex, cantidad);
                calcularTotalesFactura();
            }
        }
        private void dgvProductosFactura_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //Remover de la lista de productos el índice seleccionado
            facturaDto.Factura_Detalle.RemoveAt(e.RowIndex);

            //Actualizar los totales de la factura
            calcularTotalesFactura();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmListarClientes frmSeleccionar = new frmListarClientes(seleccionar: true);
            frmSeleccionar.ShowDialog();

            //Cargar los datos del cliente seleccionado
            txtCedulaCliente.Text = frmSeleccionar.Cliente_seleccionado.Id_cliente;
            txtNombresCliente.Text = $"{frmSeleccionar.Cliente_seleccionado.Nombres} {frmSeleccionar.Cliente_seleccionado.Apellidos}";

            facturaDto.Id_cliente = frmSeleccionar.Cliente_seleccionado;
        }

        private void txtCedulaCliente_Leave(object sender, EventArgs e)
        {
            //Cargar los datos del cliente seleccionado
            DTO.Cliente cliente = clienteCtrl.getCliente(txtCedulaCliente.Text);

            if (cliente == null)
            {
                MessageBox.Show("No existe cliente al que corresponda la cédula ingresada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtNombresCliente.Text = $"{cliente.Nombres} {cliente.Apellidos}";
            facturaDto.Id_cliente = cliente;
        }

        private void txtTextoBuscar_TextChanged(object sender, EventArgs e)
        {            
            //Mostrar la lista de próductos que cumplen con el texto de búsqueda
            List<Producto> lstProductos = productoCtrl.buscarProducto(txtProductoBuscar.Text);            
            cargarProductosDGV(dgvProductos, lstProductos);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            //Verificar que existan productos seleccionados en la factura
            if (facturaDto.Factura_Detalle.Count == 0 || facturaDto.Id_cliente == null)
            {
                Mensaje.advertencia("No hay productos a registrar en la factura. Por favor, registre productos");
                return;
            }

            //Insertar la factura
            facturaCtrl.insertarFactura(facturaDto);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }
    }
}
