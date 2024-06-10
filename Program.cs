using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista;
using SistemaFacturacion.Vista.Clientes;
using SistemaFacturacion.Vista.FrmReportes;
using SistemaFacturacion.Vista.Menu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Reportes r = new Reportes("");
            //r.getReportes("RepCliente");

            Application.Run(new frmMenuVD());
            //Application.Run(new frmMenuVD());
            //Application.Run(new frmMnu());
            //Application.Run(new Form21());
        }
    }
}
