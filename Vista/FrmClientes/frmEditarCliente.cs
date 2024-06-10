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

        string id_cliente;
        public frmEditarCliente(string id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            clienteDto = new DTO.Cliente();
            clienteCtrl = new ClienteCtrl();

            //Cargar los datos del cliente seleccionado
            clienteDto = clienteCtrl.getCliente(id_cliente);

            //Sí no se obtuvo nada al buscar el cliente que corresponda el id, 
            //cerrar el formulario
            if (clienteDto == null)
            {
                this.Close();                
            }
            else
            {
                //Cargar datos a los controles del formulario
                txtCedula.Text = clienteDto.Id_cliente;
                txtApellidos.Text = clienteDto.Apellidos;
                txtNombres.Text = clienteDto.Nombres;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();

            //Realizar validaciones
            //Caracteres existentes en nombres
            if (string.IsNullOrWhiteSpace(nombres)) return;

            //Caracteres existentes en apellidos
            if (string.IsNullOrWhiteSpace(apellidos)) return;

            //Definir los valores correspondientes al objeto de tipo Cliente (DTO)
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
