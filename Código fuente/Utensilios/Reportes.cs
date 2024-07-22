using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Utencilios
{
    public class Reportes
    {
        string rutaArchivos;
        static List<ArchivosReporte> lstReportes;

        public Reportes(string carpetaNombre)
        {
            this.rutaArchivos = DatosEstaticos.rutaReportes;
            lstReportes = new List<ArchivosReporte>();

            getReportes("");
        }

        public void getReportes(string modulo)
        {
            try
            {
                this.rutaArchivos = $@"{ DatosEstaticos.rutaReportes}\{modulo}";
                //Verificar si el directorio existe
                if (Directory.Exists(rutaArchivos))
                {
                    //Obtener todos los archivos .rdlc en el directorio
                    string[] directoriosReporte = Directory.GetDirectories(rutaArchivos);

                    foreach (string directorio in directoriosReporte)
                    {
                        string[] archivosRDLC = Directory.GetFiles(directorio, "*.rdlc");

                        //Agregar los datos del archivo a la lista
                        foreach (string archivoRDLC in archivosRDLC)
                        {
                            //Obtener el nombre del archivo
                            string nombreArchivo = Path.GetFileName(archivoRDLC);

                            //Crear un objeto ArchivoReporte con el nombre y la ruta
                            ArchivosReporte archivo = new ArchivosReporte(nombreArchivo, archivoRDLC);
                            lstReportes.Add(archivo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

         public static ArchivosReporte getReporte(string nombre)
         {
            //Buscar el reporte requerido por el nombre con el que es guardado
            for (int i = 0; i < lstReportes.Count; i++)
            {
                if (lstReportes[i].Nombre_archivo == nombre.Trim()) return lstReportes[i];
            }

            return null;
         }
    }

    public class ArchivosReporte {
        public string Nombre_archivo { get; set; }
        public string Ruta { get; set; }

        public ArchivosReporte(string nombre_archivo, string ruta)
        {
            this.Nombre_archivo = nombre_archivo;
            this.Ruta = ruta;
        }
    }
}
