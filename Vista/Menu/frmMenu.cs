using SistemaFacturacion.Vista.Factura;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
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

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarClientes());
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmRegistrarFactura());
        }
    }
}
