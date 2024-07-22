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
    public partial class frmRegistrarEmpleado : Form
    {
        EmpleadoCtrl empleadoCtrl;
        UsuarioCtrl usuarioCtrl;
        TipoUsuarioCtrl tipoUsuarioCtrl;
        public frmRegistrarEmpleado()
        {
            InitializeComponent();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Obtener los datos ingresados (modificados) por el usuario
            string cedula = txtCedula.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string fecha_nacimiento = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");

            string nombre_usuario = txtNombreUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();
            int id_tipo_usuario = int.Parse(cmbTipoUsuario.SelectedValue.ToString());
            //bool activo = bool.Parse(cmbActivo.SelectedValue.ToString());

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

            if (string.IsNullOrWhiteSpace(contrasenia))
            {
                Mensaje.advertencia("La contraseña correspondiente al usuario del empleado es requerida");
                return;
            }

            if (!Validaciones.esContraseniaValida(contrasenia))
            {
                Mensaje.advertencia("La contraseña debe contener por lo menos un caracter especial y una combinación de números y letras. Además, debe tener una longitud de entre 5 a 15 caracteres");
                return;
            }

            if (!EsMayorEdad(dtpFechaNacimiento.Value))
            {
                Mensaje.advertencia("No es mayor de edad, no es posible registrar al empleado");
                return;
            }

            Empleado empleado = new Empleado();
            empleado.Cedula_empleado = cedula;
            empleado.Apellidos = apellidos;
            empleado.Nombres = nombres;
            empleado.Fecha_nacimiento = fecha_nacimiento;

            empleado.Usuario = new Usuario();
            empleado.Usuario.Tipo_usuario.Id_tipo_usuario = id_tipo_usuario;
            empleado.Usuario.Nombre_usuario = nombre_usuario;
            empleado.Usuario.Contrasenia = contrasenia;
            //empleado.Usuario.Activo = activo;


            Respuesta r = empleadoCtrl.insertarEmpleado(empleado, empleado.Usuario);
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

        private void frmRegistrarEmpleado_Load(object sender, EventArgs e)
        {
            empleadoCtrl = new EmpleadoCtrl();
            usuarioCtrl = new UsuarioCtrl();
            tipoUsuarioCtrl = new TipoUsuarioCtrl();

            //Cargar los datos en los combobox
            /*cmbActivo.DataSource = usuarioCtrl.getOpcionesEstadosActivo();
            cmbActivo.DisplayMember = "ValorMostrar";
            cmbActivo.ValueMember = "ValorMiembro";*/

            cmbTipoUsuario.DataSource = tipoUsuarioCtrl.getOpcionesTipoUsuarios();
            cmbTipoUsuario.DisplayMember = "ValorMostrar";
            cmbTipoUsuario.ValueMember = "ValorMiembro";



            //Dibujar los bordes en los paneles
            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpciones.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
        }

        private void pbContraseniaActual_Click(object sender, EventArgs e)
        {
            //Activar o desactivar la visualización de la contraseña según el estado
            if (txtContrasenia.UseSystemPasswordChar)
            {
                //Cambiar el ícono para visualizar la contraseña
                pbContraseniaActual.BackgroundImage = Properties.Resources.ocultar;
                txtContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                //Cambiar el ícono para ocultar la contraseña
                pbContraseniaActual.BackgroundImage = Properties.Resources.mostrar;
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }
    }
}
