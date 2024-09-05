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

namespace SistemaFacturacion.Vista.FrmEmpleados
{
    public partial class frmListarEmpleados : Form
    {   
        EmpleadoCtrl empleadoCtrl;

        //Variables de control de la paginación
        int PAGINA_ACTUAL;
        int ELEMENTOS_PAGINA;
        int ELEMENTOS_OBTENIDOS;

        List<DTO.Empleado> lstEmpleados;
        public frmListarEmpleados()
        {
            InitializeComponent();
        }

        private void cargarDGV(DataGridView dgv, List<DTO.Empleado> data)
        {
            ELEMENTOS_OBTENIDOS = data.Count;
            lstEmpleados = data;

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
                dgv.Rows[fila_indice].Cells[3].Value = DateTime.Parse(data[i].Fecha_Nacimiento).ToString("dd-MM-yyyy");
            }

            aplicarPaginacion();
        }
        private void aplicarPaginacion()
        {
            lblNumeroRegistros.Text = $"{dgvEmpleados.RowCount.ToString()} registros";

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

        private void actualizarBusqueda(int PAGINA_ACTUAL, int ELEMENTOS_PAGINA)
        {
            //Juntar los filtros de búsqueda establecidos en el formulario
            List<Filtros> filtros = new List<Filtros>();
            filtros.Add(new Filtros("campo_busqueda", cmbFiltros.SelectedValue.ToString()));
            filtros.Add(new Filtros("texto_buscar", txtTextoBuscar.Text));

            cargarDGV(dgvEmpleados, empleadoCtrl.buscarEmpleados(PAGINA_ACTUAL, ELEMENTOS_PAGINA, Filtros.filtros_a_xml("Filtros", filtros)));
        }

        private void eliminarEmpleado(int id_empleado)
        {
            bool desea_eliminar = Mensaje.pregunta($"¿Está seguro que desea eliminar el empleado?");
            if (desea_eliminar)
            {
                Respuesta r = empleadoCtrl.eliminarEmpleado(id_empleado);
                Mensaje.informacion(r.Mensaje);
            }
        }

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            PAGINA_ACTUAL = PAGINA_ACTUAL + 1;
            actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
            aplicarPaginacion();
        }

        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            PAGINA_ACTUAL = PAGINA_ACTUAL - 1;
            actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
            aplicarPaginacion();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int eliminar_indice = dgvEmpleados.ColumnCount - 1;
            int modificar_indice = eliminar_indice - 1;
            int visualizar_indice = modificar_indice - 1;

            int id_empleado = lstEmpleados[e.RowIndex].Id_empleado;

            if (e.ColumnIndex == eliminar_indice)
            {
                if (DatosSesion.Empleado.Id_empleado == id_empleado)
                {
                    Mensaje.error("No es posible eliminar el usuario actual");
                    return;
                }

                eliminarEmpleado(id_empleado);
                actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
            }
            else if (e.ColumnIndex == modificar_indice)
            {
                frmEditarEmpleado frmEditar = new frmEditarEmpleado(id_empleado);
                frmEditar.ShowDialog();

                actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
            }
            else if (e.ColumnIndex == visualizar_indice)
            {
                frmVisualizarEmpleado frmVisualizar = new frmVisualizarEmpleado(id_empleado);
                frmVisualizar.ShowDialog();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistrarEmpleado frmRegistro = new frmRegistrarEmpleado();
            frmRegistro.ShowDialog();

            //actualizarBusqueda(PAGINA_ACTUAL, ELEMENTOS_PAGINA);
        }

        private void frmListarEmpleados_Load(object sender, EventArgs e)
        {
            //Variables para la paginación
            PAGINA_ACTUAL = 1;
            ELEMENTOS_PAGINA = 30 + 1;
            ELEMENTOS_OBTENIDOS = 0;

            //Una vez se incialice el formulario, mostrar la lista de productos:
            empleadoCtrl = new EmpleadoCtrl();

            //Cargar los filtros de búsqueda a los combobox            
            cmbFiltros.DataSource = empleadoCtrl.getFiltrosBusqueda();
            cmbFiltros.DisplayMember = "ValorMostrar";
            cmbFiltros.ValueMember = "ValorMiembro";

            //Cargar los datos en el datagridview
            //cargarDGV(dgvEmpleados, empleadoCtrl.listarEmpleados(PAGINA_ACTUAL, ELEMENTOS_PAGINA));


            //Dibujar los bordes según los lados deseados
            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpcionesEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlContenedorBusqueda.Paint += (s, ev) => Disenio.dibujarBordesControlLados(s, ev);
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
