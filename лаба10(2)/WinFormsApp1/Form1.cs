namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double q = double.Parse(textBox1.Text);
                if (q == 1 | q == 2)
                {
                    label3.Text = "Плюс(+)";
                }
                if (q == 3 | q == 4)
                {
                    label3.Text = "Минус(-)";
                }
                if (q > 4 | q == 0)
                {
                    label3.Text = "Такой четверти не существует";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q = comboBox1.Text;
            if (q == "1 четверть")
            {
                MessageBox.Show("Знак - Плюс(+)");
            }
            if (q == "2 четверть")
            {
                MessageBox.Show("Знак - Плюс(+)");
            }
            if (q == "3 четверть")
            {
                MessageBox.Show("Знак - Минус(-)");
            }
            if (q == "4 четверть")
            {
                MessageBox.Show("Знак - Минус(-)");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
