using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        private double comY, comX;
        protected Pen[] lapices = new Pen[]
        {
            new Pen(Color.Red, 4),
            new Pen(Color.Green, 4),
            new Pen(Color.Azure, 4),
            new Pen(Color.Yellow, 4),
            new Pen(Color.Orange, 4),
            new Pen(Color.Purple, 4),
            new Pen(Color.Brown, 4),
            new Pen(Color.Cyan, 4),
            new Pen(Color.Magenta, 4),
            new Pen(Color.Black, 4)
        };
        protected Brush[] pinceles = new Brush[]
        {
            Brushes.Red,
            Brushes.Green,
            Brushes.Azure,
            Brushes.Yellow,
            Brushes.Orange,
            Brushes.Purple,
            Brushes.Brown,
            Brushes.Cyan,
            Brushes.Magenta,
            Brushes.Black
        };

        public int SGmagnitud { get => magnitud; set => magnitud = value; }
        public double SGangulo { get => angulo; set => angulo = value; }
        public double GComY { get => comY;}
        public double GComX { get => comX;}

        public void transformaAngulo()
        {
            anguloRadiano = angulo;
            anguloRadiano = (anguloRadiano * -1);
            anguloRadiano = (anguloRadiano * Math.PI) / 180;
        }

        public void CalcularComponente()
        {
            comX = Math.Round((magnitud * Math.Cos(anguloRadiano)), 2);
            comY = Math.Round((magnitud * Math.Sin(anguloRadiano)), 2);
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
 
        public virtual void DibujarVector(PictureBox plano, Bitmap mapaVector, int numVectorColor)
        {
            using (Graphics g = Graphics.FromImage(mapaVector))
            {
                //float escala = 0.4f; // 151 a 625
                float escala = 3f; // 625 a 1250
                //float escala = 2f; // 1 a 150

                //float escala = magnitud > 600 && magnitud > 1000 ? 0.2f : 0.4f;
                //escala = magnitud > 600 && magnitud > 1000 ? 0.2f : 0.4f;


                using (lapices[numVectorColor])
                {
                    g.DrawLine(lapices[numVectorColor], 250, 250, ((X * escala) + 250), ((Y * escala) + 250));

                    float angle = (float)Math.Atan2(((Y * escala) + 250) - 250, ((X * escala) + 250) - 250);
                    PointF[] arrowPoints = new PointF[3];
                    arrowPoints[0] = new PointF(((X * escala) + 250), ((Y * escala) + 250));
                    arrowPoints[1] = new PointF(((X * escala) + 250) - 25 * (float)Math.Cos(angle - Math.PI / 5), ((Y * escala) + 250) - 25 * (float)Math.Sin(angle - Math.PI / 5));
                    arrowPoints[2] = new PointF(((X * escala) + 250) - 25 * (float)Math.Cos(angle + Math.PI / 5), ((Y * escala) + 250) - 25 * (float)Math.Sin(angle + Math.PI / 5));
                    g.FillPolygon(pinceles[numVectorColor], arrowPoints);

                    plano.Image = mapaVector;
                }
            }
        }


        public virtual void DibujarVectorPartes(PictureBox plano, Bitmap mapaVector)
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
                float escala = 3f; // 625 a 1250

                using (Pen p = new Pen(Color.Red, 4))
                {
                    g.DrawLine(p, 250, 250, ((X * escala) + 250), ((Y * escala) + 250));

                    float angle = (float)Math.Atan2(((Y * escala) + 250) - 250, ((X * escala) + 250) - 250);
                    PointF[] arrowPoints = new PointF[3];
                    arrowPoints[0] = new PointF(((X * escala) + 250), ((Y * escala) + 250));
                    arrowPoints[1] = new PointF(((X * escala) + 250) - 25 * (float)Math.Cos(angle - Math.PI / 5), ((Y * escala) + 250) - 25 * (float)Math.Sin(angle - Math.PI / 5));
                    arrowPoints[2] = new PointF(((X * escala) + 250) - 25 * (float)Math.Cos(angle + Math.PI / 5), ((Y * escala) + 250) - 25 * (float)Math.Sin(angle + Math.PI / 5));
                    g.FillPolygon(Brushes.Red, arrowPoints);

                    using (Pen componentPen = new Pen(Color.CornflowerBlue, 3))
                    {
                        // Componente en X
                        g.DrawLine(componentPen, ((X * escala) + 250), ((Y * escala) + 250), ((X * escala) + 250), 250);
                        // Componente en Y
                        g.DrawLine(componentPen, ((X * escala) + 250), ((Y * escala) + 250), 250, ((Y * escala) + 250));
                    }

                    plano.Image = mapaVector;
                }
            }
        }
    }
}
