using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista.Clientes;
using SistemaFacturacion.Vista.Factura;
using SistemaFacturacion.Vista.Productofrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        private void activarSubmenu(Panel panel)
        {
            
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }

        private void rescalarIconosBotones(Button btnPrueba)
        {
            Size tamanioBoton = btnPrueba.Size;

            int rescalaH = tamanioBoton.Height;//;30 * tamanioBoton.Width / 100;            
            btnPrueba.Image = (Image)(new Bitmap(btnPrueba.Image, new Size(rescalaH, rescalaH)));
            btnPrueba.ImageAlign = ContentAlignment.MiddleLeft;

            Color color = Color.FromArgb(255, 255, 255);
            btnPrueba.Image = Disenio.cambiarColorImagen(color, btnPrueba.Image);           
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {
            tpOpciones.SetToolTip(btnClientes, "Clientes");
            tpOpciones.SetToolTip(btnProductos, "Productos");
            tpOpciones.SetToolTip(btnFactura, "Facturas");

            rescalarIconosBotones(btnClientes);
            rescalarIconosBotones(btnProductos);
            rescalarIconosBotones(btnFactura);
            rescalarIconosBotones(btnFacturar);

            pnlMenuIzquierdo.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarClientes());
            //activarSubmenu(pnlOpcionesClientes);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarProductos());
            //activarSubmenu(pnlOpcionesProducto);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarFacturas());
            //activarSubmenu(pnlOpcionesFactura);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmRegistrarFactura());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            if (pnlMenuIzquierdo.Size == pnlMenuIzquierdo.MaximumSize)
            {
                pnlMenuIzquierdo.Size = pnlMenuIzquierdo.MinimumSize;
            }
            else
            {
                pnlMenuIzquierdo.Size = pnlMenuIzquierdo.MaximumSize;
            }
        }

        private void btnListarFactura_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarFacturas());
        }

        private void btnRegistrarFactura_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmRegistrarFactura());
        }

        
    }
}
