using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Calculadoradevectore
{
    internal class vectorClass
    {
        private double angulo, anguloRadiano;
        private int magnitud, X, Y;
        private int comY, comX;
        protected Graphics g;
        protected Pen p;

        public int SGmagnitud { get => magnitud; set => magnitud = value; }
        public double SGangulo { get => angulo; set => angulo = value; }
        public int GComY { get => comY;}
        public int GComX { get => comX;}

        public void transformaAngulo()
        {
            anguloRadiano = angulo;
            anguloRadiano = (anguloRadiano * -1);
            anguloRadiano = (anguloRadiano * Math.PI) / 180;
        }

        public void CalcularComponente()
        {
            comX = Convert.ToInt32(magnitud * Math.Cos(anguloRadiano));
            comY = Convert.ToInt32(magnitud * Math.Sin(anguloRadiano));
        }

        public void imprimirComponentes(Label labelX, Label labelY, Label labelXre, Label labelYre)
        {
            string componenteXimprimir = ($"fx = {magnitud} * Cos {angulo}");
            string resulX = $"fx = {comX}";
            labelX.Text = componenteXimprimir;
            labelXre.Text = resulX;
            

            string componenteYimprimir = ($"fy = {magnitud} * Sen {angulo}");
            string resulY = $"fy = {comY * -1}";
            labelY.Text = componenteYimprimir;
            labelYre.Text = resulY;
        }

        public virtual void calcularCoordenadas()
        {
            X = Convert.ToInt32(magnitud * Math.Cos(anguloRadiano));
            Y = Convert.ToInt32(magnitud * Math.Sin(anguloRadiano));
        }

        public virtual void DibujarVector(PictureBox plano, Bitmap mapaVector)
        {
            using (Graphics g = Graphics.FromImage(mapaVector))
            {
                using (Pen p = new Pen(Color.Red, 4))
                {
                    g.DrawLine(p, 250, 250, (X + 250), (Y + 250));


                    float angle = (float)Math.Atan2((Y + 250) - 250, (X + 250) - 250);
                    PointF[] arrowPoints = new PointF[3];
                    arrowPoints[0] = new PointF((X + 250), (Y + 250));
                    arrowPoints[1] = new PointF((X + 250) - 30 * (float)Math.Cos(angle - Math.PI / 5), (Y + 250) - 30 * (float)Math.Sin(angle - Math.PI / 5));
                    arrowPoints[2] = new PointF((X + 250) - 30 * (float)Math.Cos(angle + Math.PI / 5), (Y + 250) - 30 * (float)Math.Sin(angle + Math.PI / 5));
                    g.FillPolygon(Brushes.Red, arrowPoints);

                    plano.Image = mapaVector;
                }
            }
        }
    }
}
