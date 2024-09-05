using Microsoft.Reporting.WinForms;
using SistemaFacturacion.Controlador;
using SistemaFacturacion.DAO;
using SistemaFacturacion.DTO;
using SistemaFacturacion.Utencilios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class Form1 : Form
    {
        int id_factura;
        public Form1()
        {
            InitializeComponent();
            id_factura = 3;
        }
        public Form1(int idFactura)
        {
            InitializeComponent();
            this.id_factura = idFactura;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
