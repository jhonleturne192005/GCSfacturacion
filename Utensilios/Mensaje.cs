using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Utencilios
{
    public static class Mensaje
    {
        public static void error(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void advertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void informacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool pregunta(string mensaje)
        {
            DialogResult dr = MessageBox.Show(mensaje, "Sistema de Facturación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dr == DialogResult.Yes;
        }
    }
}
