using System.Numerics;
using System.Collections;
using System.Collections.Specialized;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadoradevectore
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        int numVector = 0;
        bool existe = false;
        List<vectorClass> Vectores = new List<vectorClass>();
        Bitmap mapavectores = new Bitmap(500, 500);
        Bitmap vectorResultanteMapa = new Bitmap(500, 500);
        VectorResultanteClass newVector = new VectorResultanteClass();


        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            datosNuevoVector.SendToBack();
        }
        private void btnAna1_Click(object sender, EventArgs e)
        {
            if (!existe)
            {
                using (Graphics g = Graphics.FromImage(mapavectores))
                {
                    using (Pen p = new Pen(Color.Blue, 4))
                    {
                        g.DrawLine(p, 0, 250, 500, 250);
                        g.DrawLine(p, 250, 0, 250, 500);
                    }
                }

                plano.Image = mapavectores;
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
                vector.DibujarVector(plano, mapavectores, numVector);
                numVector = numVector == 10 ? 0 : numVector + 1;

                Vectores.Add(vector);

                listaVectoresAgregados(vector.SGmagnitud, vector.SGangulo);

                angulo.Clear();
                unidad.Clear();
                unidad.Focus();

                comboFuerzasCompo.Items.Add($"Fuerza {Vectores.Count} : {vector.SGmagnitud}N");
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (Vectores.Count != 0)
            {

                newVector.componenteX(Vectores);
                newVector.componenteY(Vectores);
                newVector.calcularModulo();
                newVector.calcularDireccion();
                newVector.calcularCoordenadas();
                newVector.DibujarVector(planoResul, vectorResultanteMapa, numVector);
                sentidoResultante.Text = newVector.sentido();

                foreach (var vector in Vectores)
                {
                    ListViewItem lista = new ListViewItem(vector.SGmagnitud.ToString() + " N");
                    lista.SubItems.Add((vector.GComX).ToString());
                    lista.SubItems.Add((vector.GComY * -1).ToString());

                    cuadroResumen.Items.Add(lista);
                }

                ListViewItem sumatorias = new ListViewItem("SUMATORIA");
                sumatorias.SubItems.Add(newVector.GSumComponenteX.ToString());
                sumatorias.SubItems.Add((newVector.GSumComponenteY * -1).ToString());
                cuadroResumen.Items.Add(sumatorias);

                moduloResultante.Text = newVector.GModulo.ToString();
                direccionResultante.Text = Convert.ToInt32(newVector.GDireccionGrados).ToString();

                newVector.imprimirModulo(moduloImpresion, moduloResul);
                newVector.imprimirDireccion(labelImprimirDireccion, imprimirDireccionResul);

                pestañas.SelectTab("tabResultados");

                panelCubrir.Visible = false;
            }
            else
            {
                MessageBox.Show("Agregue los Vectores a sumar", "DATOS VACIOS", MessageBoxButtons.OK);
            }

            actividadInteractiva actividad = new actividadInteractiva(Vectores, newVector);

            actividad.Show();
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
                else if (Convert.ToInt32(angulo.Text) < 0 || Convert.ToInt32(unidad.Text) <= 0)
                {
                    MessageBox.Show("Ingrese un angulo o magnitud valida (mayores a 0)", "DATOS FUERA DE RANGO", MessageBoxButtons.OK);
                    return false;

                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos requeridos", "DATOS VACIOS", MessageBoxButtons.OK);
                return false;
            }
        }

        private void comboFuerzasCompo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Vectores[comboFuerzasCompo.SelectedIndex].imprimirComponentes(imprimirComponentesX, imprimirComponentesY, ComponenteXresul, ComponenteYresul);
            Vectores[comboFuerzasCompo.SelectedIndex].DibujarVectorPartes(planoResul, vectorResultanteMapa);
        }

        private void verVector_Click(object sender, EventArgs e)
        {
            newVector.DibujarVector(planoResul, vectorResultanteMapa, numVector);
        }

        private void nuevaSuma_Click(object sender, EventArgs e)
        {
            panelCubrir.Visible = true;
            cuadroResumen.Items.Clear();
            LViewVectoresAgregados.Items.Clear();
            Graphics g = Graphics.FromImage(mapavectores);
            g.Clear(Color.Transparent);
            Graphics gg = Graphics.FromImage(vectorResultanteMapa);
            gg.Clear(Color.Transparent);
            Vectores.Clear();
            comboFuerzasCompo.Items.Clear();
            pestañas.SelectTab("tabSuma");
            existe = false;
            numVector = 0;
        }

        public void actividad()
        {
            OrderedDictionary preguntas = new OrderedDictionary();

            preguntas.Add("",1);
        }


        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
    }
}