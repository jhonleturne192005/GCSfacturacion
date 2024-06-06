using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Vista.Menu
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            tvOpciones.ExpandAll();

            //pnlInterfaz.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'L');
            pnlMenuIzquierdo.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev);
            pnlLogo.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');


        }
        private void abrirFormulario(Form formulario)
        {
            pnlInterfaz.Controls.Clear();

            formulario.TopLevel = false;
            pnlInterfaz.Controls.Add(formulario);
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }
        private void tvOpciones_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag.ToString() == "0")
            {
                frmListarClientes clientes = new frmListarClientes();
                abrirFormulario(clientes);
            }
        }
    }
}
