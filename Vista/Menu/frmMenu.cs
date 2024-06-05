using SistemaFacturacion.Vista.Clientes;
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

        private void rescalarIconosBotones()
        {
            Size tamanioImagen = this.btnClientes.Image.Size;
            Size tamanioBoton = this.btnClientes.Size;

            int rescalaW = 30 * tamanioBoton.Width / 100;            
            //this.btnClientes.Image = (Image)(new Bitmap(this.button2.Image, new Size(rescalaW, rescalaW)));
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            tpOpciones.SetToolTip(btnClientes, "Clientes");
            tpOpciones.SetToolTip(btnProductos, "Productos");
            tpOpciones.SetToolTip(btnFactura, "Facturas");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarClientes());
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            //abrirFormulario(new frmRegistrarFactura());
            abrirFormulario(new frmListarFacturas());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
