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
    public partial class Menu : MaterialSkin.Controls.MaterialForm
    {
        public Menu()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form1 vectores = new Form1();

            vectores.Show();


        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            ondas ondas = new ondas();

            ondas.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();

        }
    }
}
