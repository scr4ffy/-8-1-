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
                    label3.Text = "����(+)";
                }
                if (q == 3 | q == 4)
                {
                    label3.Text = "�����(-)";
                }
                if (q > 4 | q == 0)
                {
                    label3.Text = "����� �������� �� ����������";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("������� ���������� ������");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q = comboBox1.Text;
            if (q == "1 ��������")
            {
                MessageBox.Show("���� - ����(+)");
            }
            if (q == "2 ��������")
            {
                MessageBox.Show("���� - ����(+)");
            }
            if (q == "3 ��������")
            {
                MessageBox.Show("���� - �����(-)");
            }
            if (q == "4 ��������")
            {
                MessageBox.Show("���� - �����(-)");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
