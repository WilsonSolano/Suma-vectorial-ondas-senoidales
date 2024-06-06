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

            this.vector = vector;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            vector.llenarDiccionarioPreguntas();
            vector.imprimirPreguntas(pregunta1);
        }
    }
}
