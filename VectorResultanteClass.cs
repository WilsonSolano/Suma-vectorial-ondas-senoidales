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
        public double GSumComponenteX { get => sumComponenteX;}
        public double GSumComponenteY { get => sumComponenteY;}
        public double GDireccionGrados { get => direccionGrados;}

        public double componenteX(List<vectorClass> componentesX)
        {
            var query = from X in componentesX select X.GComX;

            sumComponenteX = Math.Round(query.Sum(), 2);
            return sumComponenteX;
        }

        public double componenteY(List<vectorClass> componentesY)
        {
            var query = from Y in componentesY select Y.GComY;

            sumComponenteY = Math.Round((query.Sum()), 2);
            return sumComponenteY;
        }

        public void calcularModulo()
        {
            modulo = Math.Round((Math.Sqrt((Math.Pow(sumComponenteX, 2) + Math.Pow(sumComponenteY, 2)))), 2);
        }

        public void calcularDireccion()
        {
            //direccionRadianes = Math.Abs(Math.Atan((sumComponenteY / sumComponenteX)));
            direccionRadianes = Math.Atan2(sumComponenteY * -1, sumComponenteX);
            direccionGrados = Math.Round(((direccionRadianes * 180) / Math.PI), 2);
            direccionRadianes = (direccionRadianes * -1);

            if (direccionGrados < 0)
            {
                direccionGrados += 360;
            }
        }

        //public void analisisCuadrante()
        //{
        //    if (sumComponenteX <= 0 && sumComponenteY >= 0) //cuadrante 2 + +
        //    {
        //        direccionGrados = direccionGrados + 90;
        //        direccionRadianes = direccionRadianes + ((90 * Math.PI) / 180);
        //    }
        //    else if (sumComponenteX <= 0 && sumComponenteY <= 0) //cuadrante 3 - -
        //    {
        //        direccionGrados = direccionGrados + 180;
        //        direccionRadianes = direccionRadianes + ((180 * Math.PI) / 180);
        //    }
        //}

        public override void calcularCoordenadas()
        {
            X = Convert.ToInt32(modulo * Math.Cos(direccionRadianes));
            Y = Convert.ToInt32(modulo * Math.Sin(direccionRadianes));
        }

        public override void DibujarVector(PictureBox plano, Bitmap mapaVector, int NumeroColor)
        {

            using (Graphics g = Graphics.FromImage(mapaVector))
            {
                g.Clear(Color.Transparent);

                using (Pen p = new Pen(Color.Blue, 4))
                {
                    g.DrawLine(p, 0, 250, 500, 250);
                    g.DrawLine(p, 250, 0, 250, 500);
                }
            }

            using (Graphics g = Graphics.FromImage(mapaVector))
            {
                float escala = modulo > 600 && modulo > 1000 ? 0.2f : 0.4f ;

                using (Pen p = new Pen(Color.Aqua, 4))
                {
                    g.DrawLine(p, 250, 250, ((X * escala) + 250), ((Y * escala) + 250));

                    float angle = (float)Math.Atan2(((Y * escala) + 250) - 250, ((X * escala) + 250) - 250);
                    PointF[] arrowPoints = new PointF[3];
                    arrowPoints[0] = new PointF(((X * escala) + 250), ((Y * escala) + 250));
                    arrowPoints[1] = new PointF(((X * escala) + 250) - 25 * (float)Math.Cos(angle - Math.PI / 5), ((Y * escala) + 250) - 25 * (float)Math.Sin(angle - Math.PI / 5));
                    arrowPoints[2] = new PointF(((X * escala) + 250) - 25 * (float)Math.Cos(angle + Math.PI / 5), ((Y * escala) + 250) - 25 * (float)Math.Sin(angle + Math.PI / 5));
                    g.FillPolygon(Brushes.Aqua, arrowPoints);

                    plano.Image = mapaVector;
                }
            }
        }

        public void imprimirModulo(Label labelModulo, Label labelModuloResul)
        {
            string componenteXimprimir = ($"fr =√ ({sumComponenteX})^2 + ({sumComponenteY * -1})^2");
            string resulX = $"fr = {modulo}";
            labelModulo.Text = componenteXimprimir;
            labelModuloResul.Text = resulX;
        }

        public void imprimirDireccion(Label labelDireccion, Label labelModuloResul)
        {
            string imprimir = $"⌀ = Tan^-1({sumComponenteY * -1} / {sumComponenteX})";
            string resulX = $"⌀ = {Convert.ToInt32(direccionGrados)}";
            labelDireccion.Text = imprimir;
            labelModuloResul.Text = resulX;
        }
    }
}
