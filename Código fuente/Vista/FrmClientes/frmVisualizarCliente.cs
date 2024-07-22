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

namespace SistemaFacturacion.Vista.Clientes
{
    public partial class frmVisualizarCliente : Form
    {
        ClienteCtrl clienteCtrl;
        int id_cliente;

        public frmVisualizarCliente(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
        }

        private void frmVisualizarCliente_Load(object sender, EventArgs e)
        {
            clienteCtrl = new ClienteCtrl();
            DTO.Cliente cliente = clienteCtrl.getClientePorId(id_cliente);

            if (cliente != null)
            {
                txtCedula.Text = cliente.Cedula_cliente;
                txtApellidos.Text = cliente.Apellidos;
                txtNombres.Text = cliente.Nombres;
            }

            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpciones.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
