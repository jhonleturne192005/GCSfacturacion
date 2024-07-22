using SistemaFacturacion.Controlador;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista.FrmUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Vista
{
    public partial class frmEditarEmpleado : Form
    {
        EmpleadoCtrl empleadoCtrl;
        UsuarioCtrl usuarioCtrl;
        TipoUsuarioCtrl tipoUsuarioCtrl;

        Empleado empleado;
        int id_empleado;

        public frmEditarEmpleado(int id_empleado)
        {
            InitializeComponent();
            this.id_empleado = id_empleado;
        }

        private void cargarDatosEmpleado(Empleado empleado)
        {
            txtCedula.Text = empleado.Cedula_empleado;
            txtNombres.Text = empleado.Nombres;
            txtApellidos.Text = empleado.Apellidos;
            dtpFechaNacimiento.Value = DateTime.Parse(empleado.Fecha_nacimiento);

            if (empleado.Usuario != null)
            {
                txtNombreUsuario.Text = empleado.Usuario.Nombre_usuario;
            }
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            empleadoCtrl = new EmpleadoCtrl();
            usuarioCtrl = new UsuarioCtrl();
            tipoUsuarioCtrl = new TipoUsuarioCtrl();

            //Realizar la consulta a los datos recibidos por el contructor del formulario
            empleado = empleadoCtrl.getEmpleadoUsuarioPorIdEmpleado(id_empleado);

            if (empleado != null)
            {
                cargarDatosEmpleado(empleado);
            }

            //Cargar los datos en los combobox
            cmbActivo.DataSource = usuarioCtrl.getOpcionesEstadosActivo();
            cmbActivo.DisplayMember = "ValorMostrar";
            cmbActivo.ValueMember = "ValorMiembro";

            cmbTipoUsuario.DataSource = tipoUsuarioCtrl.getOpcionesTipoUsuarios();
            cmbTipoUsuario.DisplayMember = "ValorMostrar";
            cmbTipoUsuario.ValueMember = "ValorMiembro";

            cmbActivo.SelectedValue = empleado.Usuario.Activo;
            cmbTipoUsuario.SelectedValue = empleado.Usuario.Tipo_usuario.Id_tipo_usuario;

            //Verificar si la sesión actual es de tipo administrador para permitirle modificar algunos datos adicionales
            bool usuario_administrador = DatosSesion.esAdmin(DatosSesion.Empleado);

            //Sí no es administrador ocultar ciertos componentes
            if (!usuario_administrador)
            {
                cmbActivo.Visible = false;
                cmbTipoUsuario.Visible = false;
            }

            //Dibujar los bordes en los paneles
            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpciones.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
        }

        private void btnModificarCredenciales_Click(object sender, EventArgs e)
        {
            if (empleado == null) return;
            if (empleado.Usuario == null) return;

            frmModificarContrasenia frmUsuario = new frmModificarContrasenia(empleado.Usuario.Id_usuario);
            frmUsuario.ShowDialog();
        }

        public bool EsMayorEdad(DateTime fechaNacimiento)
        {
            DateTime currentDate = DateTime.Now;
            int years = currentDate.Year - fechaNacimiento.Year;
            int months = currentDate.Month - fechaNacimiento.Month;
            int days = currentDate.Day - fechaNacimiento.Day;

            if (months < 0 || (months == 0 && days < 0))
            {
                years--;
            }

            return years >= 18;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Obtener los datos ingresados (modificados) por el usuario
            string cedula = txtCedula.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string fecha_nacimiento = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");

            string nombre_usuario = txtNombreUsuario.Text.Trim();
            string contrasenia = txtContraseniaConf.Text.Trim();
            bool activo = bool.Parse(cmbActivo.SelectedValue.ToString());
            int id_tipo_usuario = int.Parse(cmbTipoUsuario.SelectedValue.ToString());

            //Validar datos
            if (cedula.Length != 10)
            {
                Mensaje.advertencia("La cédula no contiene la cantidad de caracteres correcta");
                return;
            }

            //Verificar que la cédula contenga números y no caracteres            
            if (!Validaciones.esCedulaValida(cedula))
            {
                Mensaje.advertencia("La cédula contiene caracteres no válidos");
                return;
            }

            if (string.IsNullOrWhiteSpace(nombres))
            {
                Mensaje.advertencia("Los nombres del empleado son requeridos");
                return;
            }

            if (string.IsNullOrWhiteSpace(apellidos))
            {
                Mensaje.advertencia("Los apellidos del empleado son requeridos");
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre_usuario))
            {
                Mensaje.advertencia("El nombre de usuario del empleado es requerido");
                return;
            }

            if (!EsMayorEdad(dtpFechaNacimiento.Value))
            {
                Mensaje.advertencia("No es mayor de edad, no es posible registrar al empleado");
                return;
            }

            empleado.Cedula_empleado = cedula;
            empleado.Apellidos = apellidos;
            empleado.Nombres = nombres;
            empleado.Fecha_nacimiento = fecha_nacimiento;

            empleado.Usuario.Activo = activo;
            empleado.Usuario.Tipo_usuario.Id_tipo_usuario = id_tipo_usuario;
            empleado.Usuario.Nombre_usuario = nombre_usuario;
            empleado.Usuario.Contrasenia = contrasenia;


            Respuesta r = empleadoCtrl.modificarEmpleado(empleado, empleado.Usuario);
            if (r.Completado)
            {
                Mensaje.informacion(r.Mensaje);
                this.Close();
            }
            else
            {
                Mensaje.advertencia(r.Mensaje);
            }
        }

        private void pbContraseniaActual_Click(object sender, EventArgs e)
        {
            //Activar o desactivar la visualización de la contraseña según el estado
            if (txtContraseniaConf.UseSystemPasswordChar)
            {
                //Cambiar el ícono para visualizar la contraseña
                pbContraseniaActual.BackgroundImage = Properties.Resources.ocultar;
                txtContraseniaConf.UseSystemPasswordChar = false;
            }
            else
            {
                //Cambiar el ícono para ocultar la contraseña
                pbContraseniaActual.BackgroundImage = Properties.Resources.mostrar;
                txtContraseniaConf.UseSystemPasswordChar = true;
            }
        }
    }
}
