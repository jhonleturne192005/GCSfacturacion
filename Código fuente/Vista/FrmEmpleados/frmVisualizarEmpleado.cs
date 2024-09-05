using SistemaFacturacion.Controlador;
using SistemaFacturacion.DTO;
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
    public partial class frmVisualizarEmpleado : Form
    {
        EmpleadoCtrl empleadoCtrl;
        UsuarioCtrl usuarioCtrl;
        TipoUsuarioCtrl tipoUsuarioCtrl;


        Empleado empleadoDao;
        int id_empleado;
        public frmVisualizarEmpleado(int id_empleado)
        {
            InitializeComponent();
            this.id_empleado = id_empleado;
        }
        private void cargarDatosEmpleado(Empleado empleado)
        {
            txtCedula.Text = empleado.Cedula;
            txtNombres.Text = empleado.Nombres;
            txtApellidos.Text = empleado.Apellidos;
            dtpFechaNacimiento.Value = DateTime.Parse(empleado.Fecha_Nacimiento);

            if (empleado.Usuario != null)
            {
                txtNombreUsuario.Text = empleado.Usuario.Nombre_usuario;
            }
        }

        private void frmVisualizarEmpleado_Load(object sender, EventArgs e)
        {
            empleadoCtrl = new EmpleadoCtrl();
            usuarioCtrl = new UsuarioCtrl();
            tipoUsuarioCtrl = new TipoUsuarioCtrl();

            //Realizar la consulta a los datos recibidos por el contructor del formulario
            empleadoDao = empleadoCtrl.getEmpleadoUsuarioPorIdEmpleado(id_empleado);

            if (empleadoDao != null)
            {
                cargarDatosEmpleado(empleadoDao);
            }

            //Cargar los datos en los combobox
            cmbActivo.DataSource = usuarioCtrl.getOpcionesEstadosActivo();
            cmbActivo.DisplayMember = "ValorMostrar";
            cmbActivo.ValueMember = "ValorMiembro";

            cmbTipoUsuario.DataSource = tipoUsuarioCtrl.getOpcionesTipoUsuarios();
            cmbTipoUsuario.DisplayMember = "ValorMostrar";
            cmbTipoUsuario.ValueMember = "ValorMiembro";

            //Dibujar los bordes en los paneles
            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpciones.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
