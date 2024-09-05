using System;
using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Controlador;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Vista.FrmProveedores
{
    public partial class frmRegistrarProveedor : Form
    {
        ProveedorCtrl clCtrl;
        DTO.Proveedor cliDto; 

        public frmRegistrarProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cedula_str = txtCedula.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string email = txtEmail.Text.Trim();


            //Realizar validaciones
            //Longitud de cédula
            if (cedula_str.Length < 10 )
            {

                Mensaje.advertencia("La cantidad de digitos ingresados  cédula 10 ó 13 si es Ruc");
                return;
            };

            //Verificar que la cédula contenga números y no caracteres            
            //Verificar que la cédula contenga números y no caracteres            
            if (cedula_str.Length == 10 && !Validaciones.esCedulaValida(cedula_str))
            {
                Mensaje.advertencia("La cédula contiene caracteres no válidos");
                return;
            }

            if (cedula_str.Length == 13 && !Validaciones.esRucValida(cedula_str))
            {
                Mensaje.advertencia("El RUC contiene caracteres no válidos");
                return;
            }

            //Caracteres existentes en nombres
            if (string.IsNullOrWhiteSpace(nombres))
            {
                Mensaje.advertencia("Los nombres del cliente son requeridos");
                return;
            }

            //Caracteres existentes en apellidos
            if (string.IsNullOrWhiteSpace(apellidos))
            {
                Mensaje.advertencia("Los apellidos del cliente son requeridos");
                return;
            }

            if (email.Length > 0)
            {
                string emailVal = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(email, emailVal))
                {
                    Mensaje.advertencia("Formato de correo incorrecto 'ejemplo@email.com'");
                    return;
                }
                
            }



            //Definir los valores correspondientes al objeto de tipo Cliente (DTO)
            cliDto.Cedula = cedula_str;
            cliDto.Nombres = nombres;
            cliDto.Apellidos = apellidos;
            cliDto.Email = email;

            //Obtener la respuesta de la ejecución de la inserción de la función
            Respuesta respuesta_insercion = clCtrl.insertarProveedor(cliDto);

            //Mostrar el mensaje
            Mensaje.informacion(respuesta_insercion.Mensaje);

            //Sí se completó correctamente la transacción, cerrar el formulario
            if (respuesta_insercion.Completado) this.Close();
        }

        private void frmRegistrarProveedor_Load(object sender, EventArgs e)
        {

            cliDto = new DTO.Proveedor();
            clCtrl = new ProveedorCtrl();

            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpciones.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
        }
    }
}
