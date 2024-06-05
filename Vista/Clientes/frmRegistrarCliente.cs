using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFacturacion.Controlador;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;

namespace SistemaFacturacion.Vista.Clientes
{
    public partial class frmRegistrarCliente : Form
    {
        ClienteCtrl clienteCtrl;
        DTO.Cliente clienteDto;

        public frmRegistrarCliente()
        {
            InitializeComponent();
        }
        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {
            clienteDto = new DTO.Cliente();
            clienteCtrl = new ClienteCtrl();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;

            //Realizar validaciones
            //Longitud de cédula
            if (cedula.Length != 10) return;

            //Caracteres existentes en nombres
            if (string.IsNullOrWhiteSpace(nombres)) return;

            //Caracteres existentes en apellidos
            if (string.IsNullOrWhiteSpace(apellidos)) return;

            //Definir los valores correspondientes al objeto de tipo Cliente (DTO)
            clienteDto.Id_cliente = cedula;
            clienteDto.Nombres = nombres;
            clienteDto.Apellidos = apellidos;

            //Obtener la respuesta de la ejecución de la inserción de la función
            Respuesta respuesta_insercion = clienteCtrl.insertarCliente(clienteDto);
            
            //Mostrar el mensaje
            Mensaje.informacion(respuesta_insercion.Mensaje);

            //Sí se completó correctamente la transacción, cerrar el formulario
            if (respuesta_insercion.Completado) this.Close();            
        }
    }
}
