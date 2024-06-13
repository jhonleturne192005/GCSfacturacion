using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista.Clientes;
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
    public partial class frmMenuVD : Form
    {
        public static frmMenuVD frmMenu;
        public frmMenuVD()
        {
            InitializeComponent();
        }
        private void rescalarIconosBotones(Button btnPrueba)
        {
            Size tamanioBoton = btnPrueba.Size;

            int rescalaH = tamanioBoton.Height - 5;
            btnPrueba.Image = (Image)(new Bitmap(btnPrueba.Image, new Size(rescalaH, rescalaH)));
            btnPrueba.ImageAlign = ContentAlignment.MiddleLeft;

            Color color = Color.FromArgb(50, 55, 65);
            btnPrueba.Image = Disenio.cambiarColorImagen(color, btnPrueba.Image);
        }
        public void abrirFormulario(Form formulario)
        {
            pnlFormulario.Controls.Clear();

            formulario.TopLevel = false;
            pnlFormulario.Controls.Add(formulario);
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }
    
        private void frmMenuVD_Load(object sender, EventArgs e)
        {
            rescalarIconosBotones(btnNombre);
            rescalarIconosBotones(btnClientes);
            rescalarIconosBotones(btnProductos);
            rescalarIconosBotones(btnFacturas);
            rescalarIconosBotones(btnFacturar);

            frmMenu = this;

            pnlInterfaz.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'L');
        }

    
        private void btnNombre_Click(object sender, EventArgs e)
        {
            if (pnlMenuIzquierdo.Size == pnlMenuIzquierdo.MaximumSize)
            {
                pnlMenuIzquierdo.Size = pnlMenuIzquierdo.MinimumSize;
                RecorrerPanel(pnlMenuIzquierdo, false);
            }
            else
            {
                pnlMenuIzquierdo.Size = pnlMenuIzquierdo.MaximumSize;
                RecorrerPanel(pnlMenuIzquierdo, true);
            }           
        }

        private void RecorrerPanel(Control control, bool activar)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Button)
                {
                    //Verificar si se desea activar o desactivar
                    if (activar)
                    {
                        c.Text = c.Tag.ToString();
                    }
                    else
                    {
                        c.Text = string.Empty;
                    }
                }
                else if (c is Panel)
                {
                    RecorrerPanel(c, activar);
                }
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarClientes());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarProductos());
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarFacturas());
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmRegistrarFactura());
        }
    }
}
