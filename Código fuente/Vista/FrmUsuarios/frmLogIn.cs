using SistemaFacturacion.Controlador;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista.FrmMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Vista.FrmLogIn
{
    public partial class frmLogIn : Form
    {
        public static frmLogIn frmLogin;
        UsuarioCtrl usuarioCtrl;        
        public frmLogIn()
        {
            InitializeComponent();
        }

        public static frmLogIn getSingleton()
        {
            if (frmLogin == null)
            {
                frmLogin = new frmLogIn();
            }

            return frmLogin;
        }
        private void frmLogIn_Load(object sender, EventArgs e)
        {
            usuarioCtrl = new UsuarioCtrl();
            frmLogin = this;

            //Cambiar el color del logo
            Color color = Color.FromArgb(50, 55, 65);
            pbLogo.BackgroundImage = Disenio.cambiarColorImagen(color, pbLogo.BackgroundImage);

            pnlLogo.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'R');
        }

        private void pbContrasenia_Click(object sender, EventArgs e)
        {
            //Activar o desactivar la visualización de la contraseña según el estado
            if (txtContrasenia.UseSystemPasswordChar)
            {
                //Cambiar el ícono para visualizar la contraseña
                pbContrasenia.BackgroundImage = Properties.Resources.ocultar;
                txtContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                //Cambiar el ícono para ocultar la contraseña
                pbContrasenia.BackgroundImage = Properties.Resources.mostrar;
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                Mensaje.advertencia("Por favor ingrese el nombre de usuario.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtContrasenia.Text))
            {
                Mensaje.advertencia("Por favor ingrese la contraseña del usuario ingresado.");
                return;
            }

            Respuesta resp_login = usuarioCtrl.logIn(txtUsuario.Text, txtContrasenia.Text);

            if (resp_login.Completado)
            {
                //Obtener el id del usuario posterior al inicio de sesión
                int id_usuario = (int)resp_login.Datos["id_usuario"];

                Empleado empleado = new Empleado();
                EmpleadoCtrl empleadoCtrl = new EmpleadoCtrl();

                //Obtener el empleado y guardarlo de forma estática para su fácil acceso
                empleado = empleadoCtrl.getEmpleadoUsuarioPorIdUsuario(id_usuario);
                DatosSesion.Empleado = empleado;

                //Limpiar los campos correspondientes a las credenciales
                txtUsuario.Text = "";
                txtContrasenia.Text = "";

                //Instanciar el formulario del menú y mostrarlo
                frmMenuV frmMenu = new frmMenuV();
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                Mensaje.error(resp_login.Mensaje);
            }
        }
    }
}
