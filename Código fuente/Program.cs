using SistemaFacturacion.Utencilios;
using SistemaFacturacion.Vista;
using SistemaFacturacion.Vista.Clientes;
using SistemaFacturacion.Vista.FrmLogIn;
using SistemaFacturacion.Vista.FrmMenu;
using SistemaFacturacion.Vista.FrmReportes;
using SistemaFacturacion.Vista.Menu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Globalization;
using System.Threading;
using System.Xml.Linq;

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
            CultureInfo culture = new CultureInfo("en-US"); Thread.CurrentThread.CurrentCulture = culture; Thread.CurrentThread.CurrentUICulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Reportes r = new Reportes("");

            Application.Run(new frmLogIn());
            //Application.Run(new frmMenuV());
            //Application.Run(new frmMenuVD());
            //Application.Run(new frmMnu());
            //Application.Run(new Form21());
        }
    }    
}
