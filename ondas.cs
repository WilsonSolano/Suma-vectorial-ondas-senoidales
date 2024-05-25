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

namespace Calculadoradevectore
{
    public partial class ondas : MaterialSkin.Controls.MaterialForm
    {
        public ondas()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan400, Primary.Cyan200, Primary.Cyan50, Accent.Lime400, TextShade.BLACK);
            InitializeComponent();

            //SineWaveProvider32 provider = new SineWaveProvider32();
            //WaveOut waveOut = new WaveOut();
            //waveOut.Init(provider);
            //waveOut.Play();
        }
    }

    //public class SineWaveProvider32 : WaveProvider32
    //{
    //    private float amplitude = 0.5f;
    //    private float frequency = 440f; // 440 Hz is the frequency of the note A above middle C

    //    public override int Read(float[] buffer, int offset, int sampleCount)
    //    {
    //        int sampleRate = WaveFormat.SampleRate;
    //        for (int n = 0; n < sampleCount; n++)
    //        {
    //            buffer[n + offset] = (float)(amplitude * Math.Sin(2 * Math.PI * frequency * n / sampleRate));
    //        }
    //        return sampleCount;
    //    }
    //}
}
