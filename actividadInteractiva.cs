using MaterialSkin;
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
    public partial class actividadInteractiva : MaterialSkin.Controls.MaterialForm
    {
        private VectorResultanteClass vector;

        public actividadInteractiva(VectorResultanteClass vector)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan400, Primary.Cyan200, Primary.Cyan50, Accent.Lime400, TextShade.BLACK);

            this.vector = vector;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            vector.llenarDiccionarioPreguntas();
            vector.imprimirPreguntas(pregunta1);
        }
    }
}
