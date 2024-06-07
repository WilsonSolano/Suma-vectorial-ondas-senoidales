using MaterialSkin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadoradevectore
{
    public partial class actividadInteractiva : MaterialSkin.Controls.MaterialForm
    {
        private List<vectorClass> listaVectores;
        private VectorResultanteClass newVector;
        private OrderedDictionary diccionarioPreguntas = new OrderedDictionary();
        private Label[] labels;
        private double margenDecimales = 0.2;

        public actividadInteractiva(List<vectorClass> vectores, VectorResultanteClass newVector)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            this.listaVectores = vectores;
            this.newVector = newVector;

            labels = new Label[] { pregunta1, pregunta2, pregunta3, pregunta4 };

            llenarDiccionarioPreguntas();
            imprimirPreguntas(labels);

            respuesta1.KeyPress += new KeyPressEventHandler(Validar_KeyPress);
            respuesta2.KeyPress += new KeyPressEventHandler(Validar_KeyPress);
            respuesta3.KeyPress += new KeyPressEventHandler(Validar_KeyPress);
            respuesta4.KeyPress += new KeyPressEventHandler(Validar_KeyPress);
        }

        public void llenarDiccionarioPreguntas()
        {
            int indice = new Random().Next(0, listaVectores.Count);
            diccionarioPreguntas.Add($"Para el vector {listaVectores[indice].SGmagnitud}, calcule la componente en X", listaVectores[indice].GComX);
            diccionarioPreguntas.Add($"Para el vector {listaVectores[indice].SGmagnitud}, calcule la componente en Y", listaVectores[indice].GComY);
            diccionarioPreguntas.Add($"Para las sumatorias en X:{newVector.GSumComponenteX}, Y:{newVector.GSumComponenteY * -1}, calcule el angulo del vector resultante", newVector.GSdireccionRadianesTan);
            diccionarioPreguntas.Add($"Para las sumatorias en X:{newVector.GSumComponenteX}, Y:{newVector.GSumComponenteY * -1}, calcule el modulo del vector resultante", newVector.GModulo);
        }

        public void imprimirPreguntas(Label[] labelPreguntas)
        {
            int i = 0;

            foreach (DictionaryEntry item in diccionarioPreguntas)
            {
                labelPreguntas[i].Text = item.Key.ToString();
                i++;
            }
        }

        public static bool respuestaCorrecta(double valorCalculado, double valorEsperado, double margen)
        {
            return Math.Abs(valorCalculado - valorEsperado) <= margen;
        }

        private void comporbar1_Click(object sender, EventArgs e)
        {
            if (respuestaCorrecta(Convert.ToDouble(respuesta1.Text), Convert.ToDouble(diccionarioPreguntas[pregunta1.Text]), margenDecimales))
            {
                correcto1.Visible = true;
                incorrecto1.Visible = false;
            }
            else
            {
                correcto1.Visible = false;
                incorrecto1.Visible = true;
            }
        }

        private void Validar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comporbar2_Click(object sender, EventArgs e)
        {
            if (respuestaCorrecta(Convert.ToDouble(respuesta2.Text), Convert.ToDouble(diccionarioPreguntas[pregunta2.Text]), margenDecimales))
            {
                correcto2.Visible = true;
                incorrecto2.Visible = false;
            }
            else
            {
                correcto2.Visible = false;
                incorrecto2.Visible = true;
            }

        }
        private void comporbar3_Click(object sender, EventArgs e)
        {
            if (respuestaCorrecta(Convert.ToDouble(respuesta3.Text), Convert.ToDouble(diccionarioPreguntas[pregunta3.Text]), margenDecimales))
            {
                correcto3.Visible = true;
                incorrecto3.Visible = false;
            }
            else
            {
                correcto3.Visible = false;
                incorrecto3.Visible = true;
            }
        }

        private void comporbar4_Click(object sender, EventArgs e)
        {
            if (respuestaCorrecta(Convert.ToDouble(respuesta4.Text), Convert.ToDouble(diccionarioPreguntas[pregunta4.Text]), margenDecimales))
            {
                correcto4.Visible = true;
                incorrecto4.Visible = false;
            }
            else
            {
                correcto4.Visible = false;
                incorrecto4.Visible = true;
            }
        }
    }
}
