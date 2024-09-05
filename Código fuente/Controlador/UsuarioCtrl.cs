using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controlador
{
    public class UsuarioCtrl
    {
        UsuarioDao usuarioDao;
        public UsuarioCtrl()
        {
            usuarioDao = new UsuarioDao();
        }
        public Respuesta logIn(string usuario, string contrasenia)
        {
            string[] outputs_login = usuarioDao.loginGetUsuario(usuario, contrasenia);

            string estado = "-1";
            int id_usuario = -1;

            bool completado = false;
            string mensaje = string.Empty;

            //Guardar los parámetros de la ejecución del procedimiento
            if (outputs_login != null)
            {
                estado = outputs_login[0];
            }

            switch (estado)
            {
                case "0":
                    mensaje = "Login exitoso";
                    id_usuario = int.Parse(outputs_login[1]);
                    completado = true;
                    break;
                case "1":
                    mensaje = "Las credenciales ingresadas son incorrectas";
                    break;
                case "2":
                    mensaje = "No esposible iniciar sesión, la cuenta se encuentra desactivada";
                    break;
                default:
                    mensaje = "Se ha producido un error durante el inicio de sesión";
                    break;
            }

            //Datos de salida
            Hashtable datos = new Hashtable();
            datos.Add("id_usuario", id_usuario);

            return new Respuesta(completado, mensaje, datos);
        }

        public Respuesta modificarContrasenia(string nombre_usuario, string contrasenia_actual, string nueva_contrasenia)
        {
            int estado = usuarioDao.modificarContrasenia(nombre_usuario, contrasenia_actual, nueva_contrasenia);

            bool completado = false;
            string mensaje = string.Empty;
          
            switch (estado)
            {
                case 0:
                    mensaje = "La contraseña fue modificada exitosamente";
                    completado = true;
                    break;
                case 1:
                    mensaje = "La contraseña actual no coincide con las credenciales de su usuario";
                    break;               
                default:
                    mensaje = "Se ha producido un error durante la modificación de la contraseña";
                    break;
            }

            
            return new Respuesta(completado, mensaje);
        }

        public Respuesta modificarContraseniaAdm(int id_usuario_edita, string nombre_usuario, string nueva_contrasenia)
        {
            int estado = usuarioDao.modificarContraseniaPorAdmin(id_usuario_edita, nombre_usuario, nueva_contrasenia);

            bool completado = false;
            string mensaje = string.Empty;

            switch (estado)
            {
                case 0:
                    mensaje = "La contraseña fue modificada exitosamente";
                    completado = true;
                    break;
                case 1:
                    mensaje = "La contraseña actual no coincide con las credenciales de su usuario";
                    break;
                default:
                    mensaje = "Se ha producido un error durante la modificación de la contraseña";
                    break;
            }


            return new Respuesta(completado, mensaje);
        }

        public Usuario getUsuario(int id_usuario)
        {
            Usuario usuario = null;
            DataTable dtUsuario = usuarioDao.getUsuario(id_usuario);

            if (dtUsuario.Rows.Count == 1)
            {
                usuario = new Usuario();

                DataRow drUsuario = dtUsuario.Rows[0];
                usuario.Id_usuario = id_usuario;

                usuario.Tipo_usuario = new TipoUsuario();
                usuario.Tipo_usuario.Id_tipo_usuario = int.Parse(drUsuario[1].ToString());
                usuario.Tipo_usuario.Tipo_usuario = drUsuario[2].ToString();
                usuario.Tipo_usuario.Descripcion = drUsuario[3].ToString();

                usuario.Nombre_usuario = drUsuario[4].ToString();
                usuario.Activo = bool.Parse(drUsuario[5].ToString());
            }

            return usuario;
        }

        public Opcion<bool>[] getOpcionesEstadosActivo()
        {
            return new Opcion<bool>[]
            {
               new Opcion<bool>("Sí", true),
               new Opcion<bool>("No", false),
            };
        }
    }
}
