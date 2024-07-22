using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
{
    public static class DatosEstaticos
    {
        public static string rutaBaseProyecto = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
        public static string rutaReportes = $@"{rutaBaseProyecto}\ReportesRdlc";
        public static string rutaRecursos = $@"{rutaBaseProyecto}\Resources";

        public static string rutaLogo = $@"{rutaRecursos}\search_icon.png";
    }
}
