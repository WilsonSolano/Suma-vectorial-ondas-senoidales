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
            vector.DibujarVector(plano);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
