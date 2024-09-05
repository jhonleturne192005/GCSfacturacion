using SistemaFacturacion.Controlador;
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

namespace SistemaFacturacion.Vista.FrmProveedores
{
    public partial class frmVisualizarProveedor : Form
    {
        int idProveedor; 
        public frmVisualizarProveedor(int idProveedor)
        {
            this.idProveedor = idProveedor;
            InitializeComponent();
        }
        ProveedorCtrl clCtrl;
        DTO.Proveedor cliDto;

        private void frmVisualizarProveedor_Load(object sender, EventArgs e)
        {
            cliDto = new DTO.Proveedor();
            clCtrl = new ProveedorCtrl();

            //Cargar los datos del cliente seleccionado
            cliDto = clCtrl.getProveedorPorId(idProveedor);

            //Sí no se obtuvo nada al buscar el cliente que corresponda el id, 
            //cerrar el formulario
            if (cliDto == null)
            {
                this.Close();
            }
            else
            {
                //Cargar datos a los controles del formulario
                txtCedula.Text = cliDto.Cedula;
                txtApellidos.Text = cliDto.Apellidos;
                txtNombres.Text = cliDto.Nombres;
                txtEmail.Text = cliDto.Email;
            }

            pnlEncabezado.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'D');
            pnlOpciones.Paint += (s, ev) => Disenio.dibujarBordesControl(s, ev, 'T');

        }
    }
}
