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

        static string PatternsPath = @"stats/patterns.json";

        public List<UserPattern> Patterns;

        //подгрузка шаблонов из файла
        public void Load_Patterns()
        {
            Patterns = JsonConvert.DeserializeObject<List<UserPattern>>(File.ReadAllText(PatternsPath));

            foreach (UserPattern user in Patterns)
                listBox.Items.Add(user.Login);
        }

        private void Modeling_Click(object sender, EventArgs e)
        {
            bool success = Int32.TryParse(textBox.Text, out int number);

            string login = listBox.SelectedItem.ToString();

            if (success)
            {
                SessionModeling sessionModeling = new SessionModeling(Patterns.FirstOrDefault(x => x.Login == login));
                sessionModeling.Generate(number);
            }
            else
            {
                MessageBox.Show("Введите число");
            }
        }
    }
}
