using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoradevectore
{
    internal class ondaSenoidalClass : ISampleProvider
    {
        private readonly float[] tablaOnda;
        private double fase;
        private double pasoFaseActual;
        private double pasoFaseObjetivo;
        private double frecuencia;
        private double deltaPasoFase;
        private bool buscarFrecuencia;

        public ondaSenoidalClass(int tasaMuestreo = 44100)
        {
            WaveFormat = WaveFormat.CreateIeeeFloatWaveFormat(tasaMuestreo, 1);
            tablaOnda = new float[tasaMuestreo];
            for (int indice = 0; indice < tasaMuestreo; ++indice)
                tablaOnda[indice] = (float)Math.Sin(2 * Math.PI * (double)indice / tasaMuestreo);
            Frecuencia = 1000f;
            Volumen = 0.25f;
            TiempoCambio = 0.5;
        }

        public double TiempoCambio { get; set; }

        public double Frecuencia
        {
            get
            {
                return frecuencia;
            }
            set
            {
                frecuencia = value;
                buscarFrecuencia = true;
            }
        }

        public float Volumen { get; set; }

        public WaveFormat WaveFormat { get; private set; }

        public int Read(float[] buffer, int desplazamiento, int cantidad)
        {
            if (buscarFrecuencia) // procesa el cambio de frecuencia solo una vez por llamada a Leer
            {
                pasoFaseObjetivo = tablaOnda.Length * (frecuencia / WaveFormat.SampleRate);
                deltaPasoFase = (pasoFaseObjetivo - pasoFaseActual) / (WaveFormat.SampleRate * TiempoCambio);
                buscarFrecuencia = false;
            }
            var vol = Volumen; // procesa el cambio de volumen solo una vez por llamada a Leer
            for (int n = 0; n < cantidad; ++n)
            {
                int indiceTablaOnda = (int)fase % tablaOnda.Length;
                buffer[n + desplazamiento] = tablaOnda[indiceTablaOnda] * vol;
                fase += pasoFaseActual;
                if (fase > tablaOnda.Length)
                    fase -= tablaOnda.Length;
                if (pasoFaseActual != pasoFaseObjetivo)
                {
                    pasoFaseActual += deltaPasoFase;
                    if (deltaPasoFase > 0.0 && pasoFaseActual > pasoFaseObjetivo)
                        pasoFaseActual = pasoFaseObjetivo;
                    else if (deltaPasoFase < 0.0 && pasoFaseActual < pasoFaseObjetivo)
                        pasoFaseActual = pasoFaseObjetivo;
                }
            }
            return cantidad;
        }

        public void calcularLongitudOnda(Label proceso, Label resultado)
        {
            double longitudOnda = Math.Round((343 / frecuencia), 2);

            string operacion = ($"λ = 343 m/s / {frecuencia}");
            string resultadoLongitud = $"λ = {longitudOnda} m";

            proceso.Text = operacion;
            resultado.Text = resultadoLongitud;
        }   
    }   
}
