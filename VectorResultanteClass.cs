using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoradevectore
{
    public class VectorResultanteClass : vectorClass
    {
        private double modulo;
        private int X, Y;
        private double sumComponenteX, sumComponenteY, direccionRadianes, direccionGrados, direccionRadianesTan;
        private List<vectorClass> listaVectores = new List<vectorClass>();
        private OrderedDictionary diccionarioPreguntas = new OrderedDictionary();

        public double GModulo { get => modulo;}
        public int GX { get => X;}
        public int GY { get => Y;}
        public double GSumComponenteX { get => sumComponenteX;}
        public double GSumComponenteY { get => sumComponenteY;}
        public double GDireccionGrados { get => direccionGrados;}
        public double GSdireccionRadianesTan { get => direccionRadianesTan; set => direccionRadianesTan = value; }

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

            this.listaVectores = componentesY;
            return sumComponenteY;
        }

        public void calcularModulo()
        {
            modulo = Math.Round((Math.Sqrt((Math.Pow(sumComponenteX, 2) + Math.Pow(sumComponenteY, 2)))), 2);
        }

        public void calcularDireccion()
        {
            //direccionRadianesTan = Math.Abs(Math.Atan((sumComponenteY / sumComponenteX)));


            direccionRadianes = Math.Atan2(sumComponenteY * -1, sumComponenteX);
            direccionGrados = Math.Round(((direccionRadianes * 180) / Math.PI), 2);
            direccionRadianes = (direccionRadianes * -1);

            if (direccionGrados < 0)
            {
                direccionGrados += 360;
            }
        }

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
                //float escala = modulo > 600 && modulo > 1000 ? 0.2f : 0.4f ;
                float escala = 3f; // 625 a 1250

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

        public string sentido()
        {
            if (direccionGrados >= 0 && direccionGrados < 90)
            {
                return "Noreste (NE)";
            }
            else if (direccionGrados >= 90 && direccionGrados < 180)
            {
                return "Noroeste (NO)";
            }
            else if (direccionGrados >= 180 && direccionGrados < 270)
            {
                return "Suroeste (SO)";
            }
            else if (direccionGrados >= 270 && direccionGrados < 360)
            {
                return "Sureste (SE)";
            }
            else
            {
                return "Desconocido";
            }
        }

        public OrderedDictionary llenarDiccionarioPreguntas()
        {
            int indice = new Random().Next(0,listaVectores.Count);
            diccionarioPreguntas.Add($"¿Para el vector {listaVectores[indice].SGmagnitud}, calcule la componente en X?", listaVectores[indice].GComX);
            return new OrderedDictionary();
        }

        public void imprimirPreguntas(Label labelPreguntas)
        {
            foreach (DictionaryEntry item in diccionarioPreguntas)
            {
                labelPreguntas.Text = item.Key.ToString();
            }
        }
    }
}
