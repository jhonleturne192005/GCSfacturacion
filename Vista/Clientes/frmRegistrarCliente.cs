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

namespace SistemaFacturacion.Vista.Cliente
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

            clienteDto.Cedula = cedula;
            clienteDto.Nombres = nombres;
            clienteDto.Apellidos = apellidos;

            string mensaje = clienteCtrl.insertarCliente(clienteDto);
            MessageBox.Show(mensaje);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCedula_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
