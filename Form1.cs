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


        }

        private void btnAna1_Click(object sender, EventArgs e)
        {
            if(!existe)
            {
                g = plano.CreateGraphics();
                p = new Pen(Color.Blue, 4);

                g.DrawLine(p, 0, 250, 500, 250);
                g.DrawLine(p, 250, 0, 250, 500);

                existe = true;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
