namespace лаба10_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                if (a < 0)
                {
                    MessageBox.Show("Введите корректное число для длины ребра.");
                }
                else
                {
                    double v = Math.Pow(a, 3);
                    double s = 4 * Math.Pow(a, 2);

                    label4.Text = v.ToString();
                    label5.Text = s.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное число для длины ребра.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
