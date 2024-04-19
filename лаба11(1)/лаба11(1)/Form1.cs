using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace лаба11_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int n;
        public double formula;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Maximum = 10000;
            n = hScrollBar1.Value;
            label2.Text = n.ToString();
            formula = Math.Pow(n, 2) * Math.Pow((n + 1), 2) / 4;
            label3.Text = formula.ToString();

            double result = 0;

            for (int i = 1; i <= n; i++)
            {
                result = i * i * (i + 1) * (i + 1) / 4.0;
            }
            label4.Text = result.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
