using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Worker
        {
            public string Surname { get; set; }
            public string Initials { get; set; }
            public string Position { get; set; }
            public int Year { get; set; }

            public Worker(string surname, string initials, string position, int year)
            {
                Surname = surname;
                Initials = initials;
                Position = position;
                Year = year;
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Generate();
        }
        private void SortAlpButton_Click(object sender, EventArgs e)
        {
            SortAlph();
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int experience))
            {
                Filter(experience);
            }
            else
            {
                MessageBox.Show("Введите корректное количество лет стажа.");
            }
        }
        private void SortAlph()
        {
            List<Worker> workers = new List<Worker>();
            using (StreamReader reader = new StreamReader("workers.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    workers.Add(new Worker(parts[0], parts[1], parts[2], int.Parse(parts[3])));
                }
            }
            workers.Sort((w1, w2) => w1.Surname.CompareTo(w2.Surname));
            richTextBox1.Clear();
            foreach (var worker in workers)
            {
                richTextBox1.AppendText($"{worker.Surname} {worker.Initials} {worker.Position} {worker.Year}\n");
            }
        }
        private void Generate()
        {
            List<Worker> workers = new List<Worker>();
            Random random = new Random();
            string[] surnames = { "Иванов", "Петров", "Сидоров", "Кузнецов", "Новиков", "Попов", "Васильев", "Михайлов" };
            string[] initials = { "И.И.", "И.П.", "П.И.", "К.С.", "С.К.", "Н.М.", "М.Н.", "В.В.", "П.Ф.", "Ф.." };
            string[] positions = { "Работник", "Менеджер", "Инженер", "Программист", "Аналитик", "Дизайнер", "Тестировщик", "Бухгалтер" };

            for (int i = 0; i < 10; i++)
            {
                int surnameIndex = random.Next(surnames.Length);
                int initialsIndex = random.Next(initials.Length);
                int positionIndex = random.Next(positions.Length);
                int year = 2013 + random.Next(1, 11);

                workers.Add(new Worker(surnames[surnameIndex], initials[initialsIndex], positions[positionIndex], year));
            }

            using (StreamWriter writer = new StreamWriter("workers.txt"))
            {
                foreach (var worker in workers)
                {
                    writer.WriteLine($"{worker.Surname} {worker.Initials} {worker.Position} {worker.Year}");
                }
            }
        }

        private void Load()
        {
            List<Worker> workers = new List<Worker>();
            using (StreamReader reader = new StreamReader("workers.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    workers.Add(new Worker(parts[0], parts[1], parts[2], Convert.ToInt32(parts[3])));
                }
            }

            foreach (var worker in workers)
            {
                richTextBox1.AppendText($"{worker.Surname} {worker.Initials} {worker.Position} {worker.Year}\n");
            }
        }

        private void Filter(int experience)
        {

            richTextBox2.Clear();
            List<Worker> workers = new List<Worker>();
            using (StreamReader reader = new StreamReader("workers.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    workers.Add(new Worker(parts[0], parts[1], parts[2], int.Parse(parts[3])));
                }
            }

            bool found = false;
            foreach (var worker in workers)
            {
                int currYear = DateTime.Now.Year;
                int currExperience = currYear - worker.Year;
                if (currExperience > experience)
                {
                    richTextBox2.AppendText($"{worker.Surname} {worker.Initials} - стаж работы превышает {experience}\n");
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("Работников с таким стажем не найдено.");
            }
        }
    }
}
