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

namespace SistemaFacturacion.Vista.FrmUsuarios
{
    public partial class frmModificarContrasenia : Form
    {
        UsuarioCtrl usuarioCtrl;
        Usuario usuarioDto;
        int id_usuario;

        bool usuario_administrador;

        public frmModificarContrasenia(int id_usuario)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
        }

        private void cargarDatosUsuario(Usuario usuario)
        {
            txtNombreUsuario.Text = usuario.Nombre_usuario;            
        }

        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {
            usuarioCtrl = new UsuarioCtrl();

            usuarioDto = usuarioCtrl.getUsuario(id_usuario);

            //Cargar los datos del usuario existente
            if (usuarioDto != null)
            {
                cargarDatosUsuario(usuarioDto);
            }

            //Verificar si la sesión actual es de tipo administrador para permitirle modificar la contraseña
            usuario_administrador = DatosSesion.esAdmin(DatosSesion.Empleado);

            //Sí es administrador ocultar ciertos componentes
            if (usuario_administrador)
            {
                lblContraseniaActual.Visible = false;
                pnlContraseniaActual.Visible = false;

                lblContraseniaNueva.Location = lblContraseniaActual.Location;
                pnlContraseniaNueva.Location = pnlContraseniaActual.Location;
            }

            //Dibujar los bordes en los paneles
            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpciones.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (usuarioDto == null) return;

            string contrasenia_actual = txtContraseniaActual.Text.Trim();
            string contrasenia_nueva = txtContraseniaNueva.Text.Trim();

            //Sí es administrador la contraseña actual no importa
            if (!usuario_administrador)
            {
                if (string.IsNullOrWhiteSpace(contrasenia_actual))
                {
                    Mensaje.advertencia("La contraseña actual es requerida");
                    return;
                }
            }


            if (string.IsNullOrWhiteSpace(contrasenia_nueva))
            {
                Mensaje.advertencia("La nueva contraseña correspondiente al usuario del empleado es requerida");
                return;
            }

            if (!Validaciones.esContraseniaValida(contrasenia_nueva))
            {
                Mensaje.advertencia("La contraseña debe contener por lo menos un caracter especial y una combinación de números y letras. Además, debe tener una longitud de entre 5 a 15 caracteres");
                return;
            }

            Respuesta r;

            if (!usuario_administrador)
            {
                r = usuarioCtrl.modificarContrasenia(usuarioDto.Nombre_usuario, contrasenia_actual, contrasenia_nueva);
            }
            else
            {

                r = usuarioCtrl.modificarContraseniaAdm(DatosSesion.Empleado.Usuario.Id_usuario, usuarioDto.Nombre_usuario, contrasenia_nueva);
            }

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
            if (txtContraseniaActual.UseSystemPasswordChar)
            {
                //Cambiar el ícono para visualizar la contraseña
                pbContraseniaActual.BackgroundImage = Properties.Resources.ocultar;
                txtContraseniaActual.UseSystemPasswordChar = false;
            }
            else
            {
                //Cambiar el ícono para ocultar la contraseña
                pbContraseniaActual.BackgroundImage = Properties.Resources.mostrar;
                txtContraseniaActual.UseSystemPasswordChar = true;
            }
        }

        private void pbContraseniaNueva_Click(object sender, EventArgs e)
        {
            //Activar o desactivar la visualización de la contraseña según el estado
            if (txtContraseniaNueva.UseSystemPasswordChar)
            {
                //Cambiar el ícono para visualizar la contraseña
                pbContraseniaNueva.BackgroundImage = Properties.Resources.ocultar;
                txtContraseniaNueva.UseSystemPasswordChar = false;
            }
            else
            {
                //Cambiar el ícono para ocultar la contraseña
                pbContraseniaNueva.BackgroundImage = Properties.Resources.mostrar;
                txtContraseniaNueva.UseSystemPasswordChar = true;
            }
        }
    }
}
