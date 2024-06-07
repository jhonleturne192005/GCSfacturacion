using SistemaFacturacion.Vista.Factura;
using SistemaFacturacion.Vista.Productofrm;
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

            rescalarIconosBotones(btnListarclientesp);
            rescalarIconosBotones(btnRegistrarclientesp);

            rescalarIconosBotones(btnListarfacturasp);
            rescalarIconosBotones(btnRegistrarfacturasp);

            rescalarIconosBotones(btnListarproductosp);
            rescalarIconosBotones(btnRegistrarproductosp);

            PersonalizarDiseño();
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



        private void PersonalizarDiseño()
        {
            pnlSubClientes.Visible = false;
            pnlSubFactura.Visible = false;
            pnlSubProductos.Visible = false;

            //int rescalaH = tamanioBoton.Height;//;30 * tamanioBoton.Width / 100;            
            //btnClientes.Image = (Image)(new Bitmap(this.btnClientes.Image, new Size(rescalaH, rescalaH)));
        }

        private void OcultarSubmenu()
        {
            if (pnlSubClientes.Visible == true)
                pnlSubClientes.Visible = false;

            if (pnlSubFactura.Visible == true)
                pnlSubFactura.Visible = false;


            if (pnlSubProductos.Visible == true)
                pnlSubProductos.Visible = false;

        }

        private void MostrarSubMenu(Panel Sub)
        {
            if (Sub.Visible == false)
            {
                OcultarSubmenu();
                Sub.Visible = true;
            }
            else
            {
                Sub.Visible = false;
            }
            

            
        }
        private void rescalarIconosBotones(Button btnPrueba)
        {
            Size tamanioImagen = btnPrueba.Image.Size;
            Size tamanioBoton = btnPrueba.Size;

            int rescalaH = tamanioBoton.Height;//;30 * tamanioBoton.Width / 100;            
            btnPrueba.Image = (Image)(new Bitmap(btnPrueba.Image, new Size(rescalaH, rescalaH)));
            btnPrueba.ImageAlign = ContentAlignment.MiddleLeft;
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {
            tpOpciones.SetToolTip(btnClientes, "Clientes");
            tpOpciones.SetToolTip(btnProductos, "Productos");
            tpOpciones.SetToolTip(btnFactura, "Facturas");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubClientes);
            //abrirFormulario(new frmListarClientes());


        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubFactura);
            //abrirFormulario(new frmRegistrarFactura());


            //abrirFormulario(new frmRegistrarFactura());
            abrirFormulario(new frmListarFacturas());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnListarclientesp_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarClientes());
            OcultarSubmenu();
           
        }

        private void btnRegistrarclientesp_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubProductos);
        }

        private void btnRegistrarfacturasp_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmRegistrarFactura());
        }

        private void btnListarproductosp_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarProductos());
        }

        private void btnRegistrarproductosp_Click(object sender, EventArgs e)
        {
            //abrirFormulario(new frmRegistrarProducto());
        }
    }
}
