using MaterialSkin;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Timer = System.Windows.Forms.Timer;

namespace Calculadoradevectore
{
    public partial class ondas : MaterialSkin.Controls.MaterialForm
    {
        private WaveOutEvent waveOut = new WaveOutEvent();
        private ondaSenoidalClass ondaSenoidal = new ondaSenoidalClass(44100);
        private bool noSuena = true;
        private float time;
        private const float timeIncrement = 0.02f;
        private Timer timer;

        public ondas()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan400, Primary.Cyan200, Primary.Cyan50, Accent.Lime400, TextShade.BLACK);
            InitializeComponent();
        }

        private void generarSonido(float volum, int frecuen, WaveOutEvent waveOutF, ondaSenoidalClass onda)
        {
            volum = volum / 100;

            onda.Frecuencia = frecuen;
            onda.Volumen = volum;
            // Inicializar el dispositivo de salida de audio
            waveOutF.Init(onda);
        }

        private void DrawSineWave(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(Color.White);

            Pen pen = new Pen(Color.Black);
            int width = pictureBox.Width;
            int height = pictureBox.Height;
            int midHeight = height / 2;

            float amplitude = ondaSenoidal.Volumen /** height / 2*/; // Escalar amplitud para ajustarse al gráfico
            float frequency = (float)ondaSenoidal.Frecuencia;
            float sampleRate = (float)ondaSenoidal.WaveFormat.SampleRate;

            PointF[] points = new PointF[width];
            for (int x = 0; x < width; x++)
            {
                float t = (time + x / sampleRate);
                float y = amplitude * (float)Math.Sin(2 * Math.PI * frequency * t);
                points[x] = new PointF(x, midHeight - y);
            }

            g.DrawLines(pen, points);
        }

        private void sliderFrecuencia_onValueChanged(object sender, int newValue)
        {
            ondaSenoidal.Frecuencia = Convert.ToInt32(sliderFrecuencia.Value);
            DrawSineWave(pictureBox);
        }

        private void sliderVolumen_onValueChanged(object sender, int newValue)
        {
            ondaSenoidal.Volumen = Convert.ToInt32(sliderVolumen.Value);
            DrawSineWave(pictureBox);
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            if (noSuena)
            {
                generarSonido(Convert.ToInt32(sliderVolumen.Value), Convert.ToInt32(sliderFrecuencia.Value), waveOut, ondaSenoidal);
                waveOut.Play();
            }
            noSuena = false;

            DrawSineWave(pictureBox);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            waveOut.Stop();
            noSuena = true;
        }
    }
}