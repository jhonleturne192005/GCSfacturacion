﻿using SistemaFacturacion.Controlador;
using SistemaFacturacion.DTO;
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
        string id_cliente;

        public frmVisualizarCliente(string id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
        }

        private void frmVisualizarCliente_Load(object sender, EventArgs e)
        {
            clienteCtrl = new ClienteCtrl();
            DTO.Cliente cliente = clienteCtrl.getCliente(id_cliente);

            if (cliente != null)
            {
                txtCedula.Text = cliente.Id_cliente;
                txtApellidos.Text = cliente.Apellidos;
                txtNombres.Text = cliente.Nombres;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
