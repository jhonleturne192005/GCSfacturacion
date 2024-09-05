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

namespace SistemaFacturacion.Vista.Clientes
{
    public partial class frmListarClientes : Form
    {
        //Variables de control de la paginación
        //Al elementos por página debe colocarse +1 como offset para verificar si existe una página adicional
        int PAGINA_ACTUAL;
        int ELEMENTOS_PAGINA;
        int ELEMENTOS_OBTENIDOS;


        //Control de modo del formulario
        bool SELECCIONAR;

        //Lista que contiene los clientes de la página actual
        List<Cliente> lstClientes;
        ClienteCtrl clienteCtrl;

        //Variables para cuando el formulario se use para seleccionar un cliente
        Cliente cliente_seleccionado;
        public Cliente Cliente_seleccionado { get { return cliente_seleccionado; } }


        public frmListarClientes()
        {
            InitializeComponent();
        }

        public frmListarClientes(bool seleccionar)
        {
            InitializeComponent();

            //Seleccionar
            SELECCIONAR = seleccionar;
            if (seleccionar == true)
            {
                cliente_seleccionado = null;

                //Configurar los componentes de diseño
                //btnAgregar.Visible = false;
                btnSeleccionar.Visible = true;
                //btnSeleccionar.Location = btnAgregar.Location;

                dgvCliente.MultiSelect = false;

                //Esconder los elementos de transacción del dgv
                //Orden: Eliminar, modificar, visualizar
                dgvCliente.Columns[dgvCliente.Columns.Count - 1].Visible = false;
                dgvCliente.Columns[dgvCliente.Columns.Count - 2].Visible = true;
                dgvCliente.Columns[dgvCliente.Columns.Count - 3].Visible = true;
            }
        }

        private void actualizarBusqueda(int PAGINA_ACTUAL, int ELEMENTOS_PAGINA)
        {
            //Juntar los filtros de búsqueda establecidos en el formulario
            List<Filtros> filtros = new List<Filtros>();
            filtros.Add(new Filtros("campo_busqueda", cmbFiltros.SelectedValue.ToString()));
            filtros.Add(new Filtros("texto_buscar", txtTextoBuscar.Text));

            cargarDGV(dgvCliente, clienteCtrl.buscarClientes(PAGINA_ACTUAL, ELEMENTOS_PAGINA, Filtros.filtros_a_xml("Filtros", filtros)));            
        }

        private void aplicarPaginacion() 
        {
            lblNumeroRegistros.Text = $"{dgvCliente.RowCount.ToString()} registros";

            //Se puede retroceder la página siempre y cuando el usuario se encuentre en una
            //página mayor a 1
            if (PAGINA_ACTUAL < 2)            
                btnPagAnterior.Enabled = false;            
            else
                btnPagAnterior.Enabled = true;

            //Se solicitan la cantidad de elementos + 1 para verificar si hay una página adicional
            //Sí la cantidad de datos obtenidas es exactamente el mismo número requerido (+1) entonces
            //existe una página adicional y se puede seguir avanzando
            if (ELEMENTOS_OBTENIDOS < ELEMENTOS_PAGINA)            
                btnPagSiguiente.Enabled = false;
            else
                btnPagSiguiente.Enabled = true;
        }

        private void cargarDGV(DataGridView dgv, List<DTO.Cliente> data)
        {
            ELEMENTOS_OBTENIDOS = data.Count;
            lstClientes = data;

            //Reiniciar la cantidad de filas del datagridview
            dgv.RowCount = 0;

            //Calcular la cantidad de filas que se crearán
            int filas_dgv = ELEMENTOS_OBTENIDOS == ELEMENTOS_PAGINA ? ELEMENTOS_OBTENIDOS - 1 : ELEMENTOS_OBTENIDOS;

            //Establecer los datos de la página actual en el dgv
            for (int i = 0; i < filas_dgv; i++)
            {
                int fila_indice = dgv.Rows.Add();
                dgv.Rows[fila_indice].Cells[0].Value = data[i].Cedula;
                dgv.Rows[fila_indice].Cells[1].Value = data[i].Apellidos;
                dgv.Rows[fila_indice].Cells[2].Value = data[i].Nombres;
            }

            //Posterior a la carga de datos, habilitar o no las opciones de cambio
            //de página, basándose en los resultados
            aplicarPaginacion();

        }
        private void eliminarCliente(int id_cliente)
        {
            bool desea_eliminar = Mensaje.pregunta($"¿Está seguro que desea eliminar al cliente con la identificación {id_cliente}?");
            if (desea_eliminar)
            {
                Respuesta r = clienteCtrl.eliminarCliente(id_cliente);
                Mensaje.informacion(r.Mensaje);
            }            
        }
        private void frmListarClientes_Load(object sender, EventArgs e)
        {
            //Variables para la paginación
            PAGINA_ACTUAL = 1;
            ELEMENTOS_PAGINA = 30 + 1;
            ELEMENTOS_OBTENIDOS = 0;

            //Una vez se incialice el formulario, mostrar la lista de clientes:
            clienteCtrl = new ClienteCtrl();

            //Cargar los filtros de búsqueda a los combobox
            cmbFiltros.DataSource = clienteCtrl.getFiltrosBusqueda();
            cmbFiltros.DisplayMember = "ValorMostrar";
            cmbFiltros.ValueMember = "ValorMiembro";

            //Cargar los datos en el datagridview
            //cargarDGV(dgvCliente, clienteCtrl.listarClientes(PAGINA_ACTUAL, ELEMENTOS_PAGINA));

            //Dibujar los bordes según los lados deseados
            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpcionesEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlContenedorBusqueda.Paint += (s, ev) => Disenio.dibujarBordesControlLados(s, ev);
        }

        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            PAGINA_ACTUAL = PAGINA_ACTUAL - 1;
            actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
        }

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            PAGINA_ACTUAL = PAGINA_ACTUAL + 1;
            actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int eliminar_indice = dgvCliente.ColumnCount - 1;
            int modificar_indice = eliminar_indice - 1;
            int visualizar_indice = modificar_indice - 1;

            //string id_cliente = dgvCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            int id_cliente = lstClientes[e.RowIndex].IdPersona;

            if (e.ColumnIndex == eliminar_indice)
            {
                eliminarCliente(id_cliente);
                actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
            }
            else if (e.ColumnIndex == modificar_indice)
            {
                frmEditarCliente frmEditarCliente = new frmEditarCliente(id_cliente);
                frmEditarCliente.ShowDialog();

                actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
            }
            else if (e.ColumnIndex == visualizar_indice)
            {
                frmVisualizarCliente frmVerCliente = new frmVisualizarCliente(id_cliente);
                frmVerCliente.ShowDialog();
            }

        }
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //Cargar los datos del cliente seleccionado
            cliente_seleccionado = lstClientes[e.RowIndex];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente frmRegistrarCliente = new frmRegistrarCliente();
            frmRegistrarCliente.ShowDialog();

            //Una vez se haya cerrado el formulario de registro, recargar la lista de clientes
            cargarDGV(dgvCliente, clienteCtrl.listarClientes(PAGINA_ACTUAL, ELEMENTOS_PAGINA));
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //Si no se ha seleccionado un cliente no permitir cerrar el formulario
            //mediante el click al botón
            if (Cliente_seleccionado != null)
            {
                this.Close();
            }
        }

        private void txtTextoBuscar_TextChanged(object sender, EventArgs e)
        {
            //Reiniciar la paginación puesto que es una nueva búsqueda
            //PAGINA_ACTUAL = 1;
            //actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (SELECCIONAR)
            {
                //Cargar los datos del cliente seleccionado
                cliente_seleccionado = lstClientes[e.RowIndex];

                //Si no se ha seleccionado un cliente no permitir cerrar el formulario
                //mediante el click al botón
                if (Cliente_seleccionado != null)
                {
                    this.Close();
                }
            }
        }

        private void txtTextoBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar si la tecla presionada es Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                //Reiniciar la paginación puesto que es una nueva búsqueda
                PAGINA_ACTUAL = 1;
                actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
            }
        }
    }
}
