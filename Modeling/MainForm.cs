using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Modeling
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Load_Patterns();
        }

        static string patterns = @"stats/patterns.json";

        public List<UserPattern> users;

        public static List<Session> NewSessions = new List<Session>();

        //подгрузка шаблонов из файла
        public void Load_Patterns()
        {
            users = JsonConvert.DeserializeObject<List<UserPattern>>(File.ReadAllText(patterns));

            foreach (UserPattern user in users)
                listBox.Items.Add(user.Login);
        }

        private void modeling_Click(object sender, EventArgs e)
        {
            int number;

            bool success = Int32.TryParse(textBox.Text, out number);

            if (success)
            {
                Generate(number);
            }
            else
            {
                MessageBox.Show("Введите число");
            }
        }

        static readonly Random random = new Random();

        //генерация сессий
        private void Generate(int value)
        {
            List<Session> sessions = new List<Session>();

            for (int i = 0; i < value; i++)
            {
                int mod = i % users.Count;

                var pattern = users[mod];

                Session session = new Session(pattern.Login);

                List<Letter> letters = new List<Letter>();

                foreach (Letter ExpectedValue in pattern.ExpectedValues)
                {
                    Letter letter = new Letter();
                    letter.Key = ExpectedValue.Key;
                    letter.Value = Box_Muller(ExpectedValue.Value, Math.Sqrt(pattern.Dispersions.FirstOrDefault(x => x.Key.Equals(ExpectedValue.Key)).Value));

                    letters.Add(letter);
                }

                session.Letters = letters;

                sessions.Add(session);
            }

            ShowSessions showSessions = new ShowSessions(sessions);
            showSessions.Show();
        }

        static double Box_Muller(double m, double sigma)
        {
        Start:

            double x = random.NextDouble() * 2 - 1;

            double y = random.NextDouble() * 2 - 1;

            double s = Math.Pow(x, 2) + Math.Pow(y, 2);

            double z0;
            if (s > 0 && s <= 1)
                z0 = x * Math.Sqrt(-2 * Math.Log(s, Math.E) / s);
            else
                goto Start;
            return m + sigma * z0;
        }
    }
}
