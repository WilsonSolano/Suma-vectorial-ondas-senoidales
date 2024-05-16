using System.Numerics;
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

            if (validarTextBox())
            {
                vectorClass vector = new vectorClass();

                vector.SGmagnitud = Convert.ToInt32(unidad.Text);
                vector.SGangulo = Convert.ToDouble(angulo.Text);

                vector.transformaAngulo();
                vector.calcularCoordenadas();
                vector.CalcularComponente();
                vector.DibujarVector(plano);

                Vectores.Add(vector);

                listaVectoresAgregados(vector.SGmagnitud, vector.SGangulo);

                angulo.Clear();
                unidad.Clear();
                unidad.Focus();
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (Vectores.Count != 0)
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
                    ListViewItem lista = new ListViewItem(vector.SGmagnitud.ToString() + " N");
                    lista.SubItems.Add((vector.GComX).ToString());
                    lista.SubItems.Add((vector.GComY).ToString());

                    cuadroResumen.Items.Add(lista);
                }

                ListViewItem sumatorias = new ListViewItem("SUMATORIA");
                sumatorias.SubItems.Add(newVector.GSumComponenteX.ToString());
                sumatorias.SubItems.Add(newVector.GSumComponenteY.ToString());

                cuadroResumen.Items.Add(sumatorias);
            }
            else
            {
                MessageBox.Show("Agregue los Vectores a sumar", "DATOS VACIOS", MessageBoxButtons.OK);
            }
        }

        public void listaVectoresAgregados(int magnitud, double angulo)
        {
            ListViewItem lista = new ListViewItem(magnitud.ToString() + " N");
            lista.SubItems.Add(angulo.ToString() + " °");

            LViewVectoresAgregados.Items.Add(lista);
        }

        private void unidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void angulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool validarTextBox()
        {
            if (!string.IsNullOrWhiteSpace(unidad.Text) && !string.IsNullOrWhiteSpace(angulo.Text))
            {
                if (Convert.ToInt32(angulo.Text) > 360)
                {
                    MessageBox.Show("Ingrese un angulo valido", "ANGULO FUERA DE RANGO", MessageBoxButtons.OK);
                    angulo.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos requeridos","DATOS VACIOS", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
