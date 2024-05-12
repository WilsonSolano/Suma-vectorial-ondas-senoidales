using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Calculadoradevectore
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        Graphics g, h;
        Pen p, q;
        bool existe = false;
        List<vectorClass> Vectores = new List<vectorClass>();

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan400, Primary.Cyan200, Primary.Cyan50, Accent.Lime400, TextShade.BLACK);
        }

        private void btnAna1_Click(object sender, EventArgs e)
        {
            if (!existe)
            {
                g = plano.CreateGraphics();
                p = new Pen(Color.Blue, 4);

                g.DrawLine(p, 0, 250, 500, 250);
                g.DrawLine(p, 250, 0, 250, 500);

                existe = true;
            }

            vectorClass vector = new vectorClass();

            vector.SGmagnitud = Convert.ToInt32(unidad.Text);
            vector.SGangulo = Convert.ToDouble(angulo.Text);

            vector.transformaAngulo();
            vector.calcularCoordenadas();
            vector.CalcularComponente();
            vector.DibujarVector(plano);


            Vectores.Add(vector);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            double valor = 0;

            //foreach (var vectorComponentess in vectoresComponentes)
            //{
            //    if (vectorComponentess.ContainsKey("componenteX"))
            //    {
            //        valor += vectorComponentess["componenteX"];
            //    }
            //}

            double pru = Math.Pow(2, 3);
            label6.Text = pru.ToString();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            VectorResultanteClass newVector = new VectorResultanteClass();

            newVector.componenteX(Vectores);
            newVector.componenteY(Vectores);
            newVector.calcularModulo();
            newVector.calcularDireccion();
            newVector.calcularCoordenadas();
            newVector.DibujarVector(plano);

            foreach (var vector in Vectores)
            {
                ListViewItem lista = new ListViewItem(vector.SGmagnitud.ToString());
                lista.SubItems.Add(vector.GComX.ToString());
                lista.SubItems.Add(vector.GComY.ToString());
                lista.SubItems.Add(vector.SGangulo.ToString());

                cuadroResumen.Items.Add(lista);
            }

        }
    }
}
