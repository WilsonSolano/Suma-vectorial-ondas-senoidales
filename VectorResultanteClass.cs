using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoradevectore
{
    internal class VectorResultanteClass : vectorClass
    {
        private double modulo;
        private int X, Y;
        private double sumComponenteX, sumComponenteY, sentido, direccionRadianes, direccionGrados;

        public double GModulo { get => modulo;}
        public int GX { get => X;}
        public int GY { get => Y;}


        public double componenteX(List<vectorClass> componentesX)
        {
            var query = from X in componentesX select X.GComX;

            sumComponenteX = query.Sum();
            return sumComponenteX;
        }

        public double componenteY(List<vectorClass> componentesY)
        {
            var query = from Y in componentesY select Y.GComY;

            sumComponenteY = query.Sum();
            return sumComponenteY;
        }

        public void calcularModulo()
        {
            modulo = Math.Sqrt((Math.Pow(sumComponenteX, 2) + Math.Pow(sumComponenteY, 2)));
        }

        public void calcularDireccion()
        {
            direccionRadianes = Math.Abs(Math.Atan((sumComponenteY / sumComponenteX)));
            direccionRadianes = (direccionRadianes * -1);
            direccionGrados = (direccionRadianes * 180) / Math.PI;
        }

        public override void calcularCoordenadas()
        {
            X = Convert.ToInt32(modulo * Math.Cos(direccionRadianes));
            Y = Convert.ToInt32(modulo * Math.Sin(direccionRadianes));
        }

        public override void DibujarVector(PictureBox plano)
        {
            g = plano.CreateGraphics();
            p = new Pen(Color.Aqua, 4);

            g.DrawLine(p, 250, 250, (X + 250), (Y + 250));


            float angle = (float)Math.Atan2((Y + 250) - 250, (X + 250) - 250);
            PointF[] arrowPoints = new PointF[3];
            arrowPoints[0] = new PointF((X + 250), (Y + 250));
            arrowPoints[1] = new PointF((X + 250) - 30 * (float)Math.Cos(angle - Math.PI / 5), (Y + 250) - 30 * (float)Math.Sin(angle - Math.PI / 5));
            arrowPoints[2] = new PointF((X + 250) - 30 * (float)Math.Cos(angle + Math.PI / 5), (Y + 250) - 30 * (float)Math.Sin(angle + Math.PI / 5));
            g.FillPolygon(Brushes.Aqua, arrowPoints);
        }
    }
}
