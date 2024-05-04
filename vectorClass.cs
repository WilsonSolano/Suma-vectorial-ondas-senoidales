using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void calcularCoordenadas()
        {
            X = Convert.ToInt32(magnitud * Math.Cos(angulo));
            Y = Convert.ToInt32(magnitud * Math.Sin(angulo));
        }

        public void transformaAngulo()
        {
            angulo = (angulo * -1);
            angulo = (angulo * Math.PI) / 180;
        }

        public void DibujarVector(PictureBox plano/*, int color*/)
        {
            g = plano.CreateGraphics();
            p = new Pen(Color.Red, 4);

            g.DrawLine(p, 250, 250, (X + 250), (Y + 250));
        }
    }

    //internal class VectorClass
    //{
    //    private double angulo; // Ángulo en radianes
    //    private int magnitud;
    //    private int x, y; // Coordenadas del extremo del vector

    //    public int Magnitud { get => magnitud; set => magnitud = value; }
    //    public double Angulo { get => angulo; set => angulo = value * Math.PI / 180; } // Angulo en grados

    //    public void CalcularCoordenadas()
    //    {
    //        x = Convert.ToInt32(magnitud * Math.Cos(angulo));
    //        y = Convert.ToInt32(magnitud * Math.Sin(angulo));
    //    }

    //    public void DibujarVector(PictureBox plano)
    //    {
    //        Graphics g = plano.CreateGraphics();
    //        Pen p = new Pen(Color.Red, 4);

    //        // Dibujar el vector desde el centro del PictureBox
    //        int centerX = plano.Width / 2;
    //        int centerY = plano.Height / 2;

    //        g.DrawLine(p, centerX, centerY, centerX + x, centerY - y);
    //        g.Dispose();
    //    }
    //}
}
