using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Calculadoradevectore
{
    internal class vectorClass
    {
        double angulo, x, y;
        int magnitud, X, Y;
        Graphics g;
        Pen p;


        public int SGmagnitud { get => magnitud; set => magnitud = value; }
        public double SGangulo { get => angulo; set => angulo = value; }


        public void transformaAngulo()
        {
            angulo = (angulo * -1);
            angulo = (angulo * Math.PI) / 180;
        }

        public void calcularCoordenadas()
        {
            X = Convert.ToInt32(magnitud * Math.Cos(angulo));
            Y = Convert.ToInt32(magnitud * Math.Sin(angulo));
        }

        public void DibujarVector(PictureBox plano)
        {
            g = plano.CreateGraphics();
            p = new Pen(Color.Red, 4);

            g.DrawLine(p, 250, 250, (X + 250), (Y + 250));


            float angle = (float)Math.Atan2((Y + 250) - 250,(X + 250) - 250);
            PointF[] arrowPoints = new PointF[3];
            arrowPoints[0] = new PointF((X + 250),(Y + 250));
            arrowPoints[1] = new PointF((X + 250) - 30 * (float)Math.Cos(angle - Math.PI / 5), (Y + 250) - 30 * (float)Math.Sin(angle - Math.PI / 5));
            arrowPoints[2] = new PointF((X + 250) - 30 * (float)Math.Cos(angle + Math.PI / 5), (Y + 250) - 30 * (float)Math.Sin(angle + Math.PI / 5));
            g.FillPolygon(Brushes.Red, arrowPoints);
        }
    }
}
