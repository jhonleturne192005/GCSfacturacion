using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Utencilios
{
    class Disenio
    {
        public static void dibujarBordesControl(object sender, PaintEventArgs e, char lado, int tamanio_borde = 1)
        {
            //Definir los parámetros de dibujo pará las líneas
            Color color_borde = Color.FromArgb(200, 200, 200);

            //Lapices para dibujar los bordes (aumentar uno a la izquierda y abajo por que pinta mal windows forms (? )
            Pen lapiz_tl = new Pen(color_borde, tamanio_borde);
            Pen lapiz_dr = new Pen(color_borde, tamanio_borde + 1);

            //Obtener el espacio que ocupa el control
            Rectangle rect = ((Control)(sender)).ClientRectangle;

            switch (lado)
            {
                case ('T'): //TOP (ARRIBA)
                    e.Graphics.DrawLine(lapiz_tl, rect.Left, rect.Top, rect.Right, rect.Top);
                    break;
                case ('D'): //DOWN (ABAJO)
                    e.Graphics.DrawLine(lapiz_dr, rect.Left, rect.Bottom, rect.Right, rect.Bottom);
                    break;
                case ('L'): //LEFT (IZQUIERDA)
                    e.Graphics.DrawLine(lapiz_tl, rect.Left, rect.Top, rect.Left, rect.Bottom);
                    break;
                case ('R'): //RIGHT (DERECHA)
                    e.Graphics.DrawLine(lapiz_dr, rect.Right, rect.Top, rect.Right, rect.Bottom);
                    break;
                default:
                    return;
            }
        }

        public static void dibujarBordesControl(object sender, PaintEventArgs e, char[] lados = null, int tamanio_borde = 1)
        {
            if (lados == null) lados = new char[4] { 'T', 'D', 'L', 'R' };

            //Definir los parámetros de dibujo pará las líneas
            Color color_borde = Color.FromArgb(200, 200, 200);
            Pen lapiz_tl = new Pen(color_borde, tamanio_borde);
            Pen lapiz_dr = new Pen(color_borde, tamanio_borde + 1);

            //Obtener el espacio que ocupa el control
            Rectangle rect = ((Control)(sender)).ClientRectangle;

            for (int i = 0; i < lados.Length; i++)
            {
                char lado = lados[i];
                switch (lado)
                {
                    case ('T'): //TOP (ARRIBA)
                        e.Graphics.DrawLine(lapiz_tl, rect.Left, rect.Top, rect.Right, rect.Top);
                        break;
                    case ('D'): //DOWN (ABAJO)
                        e.Graphics.DrawLine(lapiz_dr, rect.Left, rect.Bottom, rect.Right, rect.Bottom);
                        break;
                    case ('L'): //LEFT (IZQUIERDA)
                        e.Graphics.DrawLine(lapiz_tl, rect.Left, rect.Top, rect.Left, rect.Bottom);
                        break;
                    case ('R'): //RIGHT (DERECHA)
                        e.Graphics.DrawLine(lapiz_dr, rect.Right, rect.Top, rect.Right, rect.Bottom);
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}
