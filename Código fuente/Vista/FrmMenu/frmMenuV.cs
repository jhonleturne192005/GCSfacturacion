using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista.Clientes;
using SistemaFacturacion.Vista.Factura;
using SistemaFacturacion.Vista.FrmEmpleados;
using SistemaFacturacion.Vista.FrmLogIn;
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

namespace SistemaFacturacion.Vista.FrmMenu
{
    public partial class frmMenuV : Form
    {
        public static frmMenuV frmMenu;        
        public frmMenuV()
        {
            InitializeComponent();
        }

        public static frmMenuV getSingleton()
        {
            if (frmMenu == null)
            {
                frmMenu = new frmMenuV();                
            }

            return frmMenu;
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
            pnlForms.Controls.Clear();

            formulario.TopLevel = false;
            pnlForms.Controls.Add(formulario);
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }

      

        private void frmMenuV_Load(object sender, EventArgs e)
        {
            rescalarIconosBotones(btnNombre);
            rescalarIconosBotones(btnClientes);
            rescalarIconosBotones(btnUsuarios);
            rescalarIconosBotones(btnProductos);
            rescalarIconosBotones(btnFacturas);
            rescalarIconosBotones(btnFacturar);

            //Establecer el fórmulario como estático para tener acceso de forma externa
            frmMenu = this;

            //Bordes en los paneles
            pnlMenuIzquierdo.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'R');
            pnlConfiguracion.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');

            //Cargar los datos de la sesión activa
            if (DatosSesion.Empleado == null) return;
            if (DatosSesion.Empleado.Usuario == null) return;
            if (DatosSesion.Empleado.Usuario.Tipo_usuario == null) return;

            //Cargar el nombre en el formulario
            lblNombreUsuario.Text = DatosSesion.Empleado.Usuario.Nombre_usuario;
            lblRol.Text = DatosSesion.Empleado.Usuario.Tipo_usuario.Tipo_usuario;

            //Verificar los accesos por el rol
            if (DatosSesion.Empleado.Usuario.Tipo_usuario.Id_tipo_usuario != 1)
            {
                pnlUsuarios.Visible = false;
                pnlProductos.Visible = false;
                pnlClientes.Visible = false;
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
           abrirFormulario(new frmListarEmpleados());
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            if (pnlMenuIzquierdo.Size.Width == pnlMenuIzquierdo.MaximumSize.Width)
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
        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn.getSingleton().Show();
        }

        private void pbConfigurarUsuario_Click(object sender, EventArgs e)
        {
            //Configurar los datos del usuario (sesión vigente)
            if (DatosSesion.Empleado == null) return;

            frmEditarEmpleado frmEditarEmp = new frmEditarEmpleado(DatosSesion.Empleado.Id_empleado);
            frmEditarEmp.ShowDialog();
        }
    }
}
