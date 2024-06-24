using SistemaFacturacion.Controlador;
using SistemaFacturacion.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Vista.Cliente
{
    public partial class frmVisualizarCliente : Form
    {
        csClienteCtrl clienteCtrl;
        string id_cliente;

        public frmVisualizarCliente(string id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
        }

        private void frmVisualizarCliente_Load(object sender, EventArgs e)
        {
            clienteCtrl = new csClienteCtrl();
            csClienteDto cliente = clienteCtrl.getCliente(id_cliente);

            txtCedula.Text = cliente.Cedula;
            txtApellidos.Text = cliente.Apellidos;
            txtNombres.Text = cliente.Nombres;
        }
    }
}
