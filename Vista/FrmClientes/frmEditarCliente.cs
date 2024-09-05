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

namespace SistemaFacturacion.Vista.Clientes
{
    public partial class frmEditarCliente : Form
    {
        DTO.Cliente clienteDto;
        ClienteCtrl clienteCtrl;

        int id_cliente;
        public frmEditarCliente(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            clienteDto = new DTO.Cliente();
            clienteCtrl = new ClienteCtrl();

            //Cargar los datos del cliente seleccionado
            clienteDto = clienteCtrl.getClientePorId(id_cliente);

            //Sí no se obtuvo nada al buscar el cliente que corresponda el id, 
            //cerrar el formulario
            if (clienteDto == null)
            {
                this.Close();                
            }
            else
            {
                //Cargar datos a los controles del formulario
                txtCedula.Text = clienteDto.Cedula;
                txtApellidos.Text = clienteDto.Apellidos;
                txtNombres.Text = clienteDto.Nombres;
            }

            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpciones.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();

            //Realizar validaciones
            //Longitud de cédula
            if (cedula.Length != 10)
            {
                Mensaje.advertencia("La cantidad de digitos ingresados en la cédula no son válidos");
                return;
            };

            //Verificar que la cédula contenga números y no caracteres            
            if (!Validaciones.esCedulaValida(cedula))
            {
                Mensaje.advertencia("La cédula contiene caracteres no válidos");
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

            //Definir los valores correspondientes al objeto de tipo Cliente (DTO)
            clienteDto.Cedula = cedula;
            clienteDto.Nombres = nombres;
            clienteDto.Apellidos = apellidos;

            //Obtener la respuesta de la ejecución de la inserción de la función
            Respuesta respuesta_insercion = clienteCtrl.modificarCliente(clienteDto);

            //Mostrar el mensaje
            Mensaje.informacion(respuesta_insercion.Mensaje);

            //Sí se completó correctamente la transacción, cerrar el formulario
            if (respuesta_insercion.Completado) this.Close();
        }
    }
}
