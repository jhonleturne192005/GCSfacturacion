using SistemaFacturacion.Controlador;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista.Cliente;
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
        ProductoCtrl productoCtrl;
        ClienteCtrl clienteCtrl;
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
                dgv.Rows[fila_indice].Cells[0].Value = data[i].id_producto;
                dgv.Rows[fila_indice].Cells[1].Value = data[i].nombre_producto;
                dgv.Rows[fila_indice].Cells[2].Value = Math.Round(data[i].precio_unitario, 2);
            }
        }

        private void restaurarCodigoProductoFactura(int indice_fila)
        {
            dgvProductosFactura.Rows[indice_fila].Cells[0].Value = dgvProductosFactura.Rows[indice_fila].Cells[6].Value;
        }

        private bool existeProductoFactura(int id_producto, bool proviene_dgv_productos)
        {
            //Considerar que va a existir por lo menos una vez, debido a que es el código que está ingresando
            //el usuario, por lo tanto la condición de salida es que el contador sea igual a 2.
            int contador = 0;
            int contador_existe_producto = proviene_dgv_productos ? 1 : 2;

            for (int i = 0; i < dgvProductosFactura.RowCount; i++)
            { 
                //Sí no existe valor en la celda del id_producto, continuar a la siguiente iteración
                if (dgvProductosFactura.Rows[i].Cells[0].Value == null) continue;                

                //Sí es igual entonces incrementar el contador
                if (dgvProductosFactura.Rows[i].Cells[0].Value.ToString() == id_producto.ToString())
                    contador = contador + 1;
                
                if (contador == contador_existe_producto) return true;
            }

            return false;
        }

        private bool agregarProductoFactura(int indice_fila, int id_producto, bool proviene_dgv_productos)
        {
            //Verificar que le producto no haya sido registrado en la factura
            if (existeProductoFactura(id_producto, proviene_dgv_productos))
            {
                MessageBox.Show("El producto seleccionado ya ha sido registrado en la factura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Buscar un producto que coincide con el ingresado por le usuario
            Producto producto = productoCtrl.getProducto(id_producto);

            //Sí el producto no existe mostrar el mensaje de advertencia la usuario
            if (producto == null)
            {
                MessageBox.Show("El código del producto ingresado no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Insertar los valores en la fila correspondiente
            dgvProductosFactura.Rows[indice_fila].Cells[0].Value = producto.id_producto;
            dgvProductosFactura.Rows[indice_fila].Cells[1].Value = producto.nombre_producto;
            dgvProductosFactura.Rows[indice_fila].Cells[2].Value = 1; //Cantidad
            dgvProductosFactura.Rows[indice_fila].Cells[3].Value = Math.Round(producto.precio_unitario, 2);
            dgvProductosFactura.Rows[indice_fila].Cells[4].Value = Math.Round(producto.precio_unitario, 2); //Total
            dgvProductosFactura.Rows[indice_fila].Cells[5].Value = producto.iva;

            //Actualizar el código previo del producto en el detalle de la factura en la fila correspondiente
            dgvProductosFactura.Rows[indice_fila].Cells[6].Value = producto.id_producto;

            //Agregar una nueva fila en la lista de productos solo sí se ingresó correctamente y
            //en la penúltima fila            
            if (indice_fila == dgvProductosFactura.RowCount - 1) dgvProductosFactura.Rows.Add();

            //Después de insertar los datos actualizarl los totales de la factura
            calcularTotalesFactura();
            return true;           
        }

        private void calcularSubtotalProductoFactura(int indice_fila)
        {
            decimal cantidad = decimal.Parse(dgvProductosFactura.Rows[indice_fila].Cells[2].Value.ToString());
            decimal precio_unitario = decimal.Parse(dgvProductosFactura.Rows[indice_fila].Cells[3].Value.ToString());

            dgvProductosFactura.Rows[indice_fila].Cells[4].Value = Math.Round(cantidad * precio_unitario, 2);
        }

        private void calcularTotalesFactura()
        {
            decimal subtotal = 0; //Total sin impuestos
            decimal total = 0;
            decimal iva_acumulado = 0;

            for (int i = 0; i < dgvProductosFactura.RowCount; i++)
            {
                //Validar que los datos de los productos en el detalle no sean nulos
                if (dgvProductosFactura.Rows[i].Cells[2].Value == null) continue;
                if (dgvProductosFactura.Rows[i].Cells[3].Value == null) continue;
                if (dgvProductosFactura.Rows[i].Cells[5].Value == null) continue;

                //Almacenar los datos en variables
                decimal cantidad_producto = decimal.Parse(dgvProductosFactura.Rows[i].Cells[2].Value.ToString());
                decimal precio_unitario = decimal.Parse(dgvProductosFactura.Rows[i].Cells[3].Value.ToString());
                decimal iva_producto = decimal.Parse(dgvProductosFactura.Rows[i].Cells[5].Value.ToString());

                //Subtotal = precio_unitario * cantidad
                decimal subtotal_producto = precio_unitario * cantidad_producto;
                decimal total_producto = subtotal_producto * (1 + iva_producto / 100);

                subtotal = subtotal + subtotal_producto;
                total = total + total_producto;
            }
            
            //Calcular le IVA
            iva_acumulado = total - subtotal;

            //Establecer los valores totales:
            lblSubtotal.Text = $"$ {Math.Round(subtotal, 2)}";
            lblIva.Text = $"$ {Math.Round(iva_acumulado, 2)}";
            lblTotal.Text = $"$ {Math.Round(total, 2)}";
        }

        private void frmRegistrarFactura_Load(object sender, EventArgs e)
        {
            productoCtrl = new ProductoCtrl();
            clienteCtrl = new ClienteCtrl();

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
            pnlOpcionesProducto.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
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

            //Agregar el producto al detalle
            agregarProductoFactura(dgvProductosFactura.RowCount - 1, id_producto, true);
        }

        private void dgvProductosFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Obtener la celda que se finalizó de editar
            DataGridViewCell dgvFilaSeleccionada = dgvProductosFactura.Rows[e.RowIndex].Cells[e.ColumnIndex];
            bool se_inserto_producto = false;

            if (e.ColumnIndex == 0) { //Código del producto

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
                se_inserto_producto = agregarProductoFactura(e.RowIndex, id_producto, false);

                //Sí no se pudo insertar restaurar el código al valor anterior
                if (!se_inserto_producto) restaurarCodigoProductoFactura(e.RowIndex);
                
            }            
            else if (e.ColumnIndex == 2) { //Cantidad

                //Verificar que el valor de la celda no sea nulo, sí lo es colocar por defecto el valor de 1
                if (dgvFilaSeleccionada.Value == null) dgvFilaSeleccionada.Value = 1;

                //Sí no hay precio unitario entonces no hay producto, por lo tanto se restaura el valor
                if (dgvProductosFactura.Rows[e.RowIndex].Cells[3].Value == null)
                {
                    dgvFilaSeleccionada.Value = null;
                    return;
                }

                //Verificar sí existen datos para realizar los cálculos
                decimal cantidad = 0;

                //Verificar que los datos de las celdas sean decimales válidos, caso contrario dejar el valor de 1
                if (!decimal.TryParse(dgvFilaSeleccionada.Value.ToString(), out cantidad)) dgvFilaSeleccionada.Value = 1;                

                //Calcular el total y subtotal del producto y el general
                calcularSubtotalProductoFactura(e.RowIndex);

                //Actualizar los totales de la factura
                calcularTotalesFactura();
            }
        }
        private void dgvProductosFactura_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //Actualizar los totales de la factura
            calcularTotalesFactura();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente frmSeleccionar = new frmSeleccionarCliente();
            frmSeleccionar.ShowDialog();

            //Cargar los datos del cliente seleccionado
            txtCedulaCliente.Text = frmSeleccionar.Cliente_seleccionado.Cedula;
            txtNombresCliente.Text = $"{frmSeleccionar.Cliente_seleccionado.Nombres} {frmSeleccionar.Cliente_seleccionado.Apellidos}";            
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
            if (dgvProductosFactura.RowCount < 2)
            {
                MessageBox.Show("No hay productos a registrar en la factura. Por favor, registre productos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Parsear los datos de la factura (cliente y productos) para registrarlos.
        }
    }
}
