using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
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

        static string generated = @"stats/generated.json";

        public static List<UserActivity> generatedUsers = new List<UserActivity>();

        public List<UserPattern> users;

        //подгрузка шаблонов из файла
        public void Load_Patterns()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DictionaryAsArrayResolver()
            };

            //users = JsonConvert.DeserializeObject<List<UserPattern>>(File.ReadAllText(patterns), settings);

            users = JsonConvert.DeserializeObject<List<UserPattern>>(File.ReadAllText(patterns));

            foreach (UserPattern user in users)
                listBox.Items.Add(user.Login);
        }

        class DictionaryAsArrayResolver : DefaultContractResolver
        {
            protected override JsonContract CreateContract(Type objectType)
            {
                if (objectType.GetInterfaces().Any(i => i == typeof(IDictionary) ||
                    (i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IDictionary<,>))))
                {
                    return base.CreateArrayContract(objectType);
                }

                return base.CreateContract(objectType);
            }
        }

        private void modeling_Click(object sender, EventArgs e)
        {
            //считываю заполненное поле
            Generate(int.Parse(textBox.Text));
        }

        static Random random = new Random();

        private void Generate(int value)
        {
            List<UserActivity> ua = new List<UserActivity>();

            for (int k = 0; k < users.Count; k++)
            {
                UserActivity generatedUser = new UserActivity();

                generatedUser.login = users[k].Login;

                List<Session> sessions = new List<Session>();

                for (int i = 0; i < value; i++)
                {
                    Session session = new Session();

                    List<Letter> letterList = new List<Letter>();

                    letterList.Clear();

                    for (int j = 0; j < users[k].expectedValues.Count; j++)
                    {
                        Letter letter = new Letter();
                        letter.Key = users[k].expectedValues.ElementAt(j).Key;
                        letter.Value = Box_Muller(users[k].expectedValues.ElementAt(j).Value, Math.Sqrt(users[k].Dispersions.ElementAt(j).Value));

                        letterList.Add(letter);
                    }

                    session.Letters = letterList;

                    sessions.Add(session);
                }

                generatedUser.sessions = sessions;

                //CalculateDispersion(ref generatedUser);

                ua.Add(generatedUser);
            }

            generatedUsers = ua;

            WriteTOJson(generatedUsers);

            MessageBox.Show("Сессии успешно сгенерированы");

            textBox.Clear();
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

        static void WriteTOJson(List<UserActivity> users)
        {
            File.WriteAllText(generated, String.Empty);

            using (StreamWriter file = File.CreateText(generated))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, users);
            }
        }

        //static void CalculateDispersion(ref UserActivity user)
        //{
        //    Dictionary<string, double> dispersions = new Dictionary<string, double>();

        //    for (int i = 0; i < user.sessions[0].letters.Count; i++)
        //    {
        //        double averageSumm = 0;

        //        for (int j = 0; j < user.sessions.Count; j++)
        //        {
        //            averageSumm += user.sessions[j].letters.ElementAt(i).value;
        //        }

        //        double average = averageSumm / user.sessions.Count;

        //        double summ = 0;

        //        for (int j = 0; j < user.sessions.Count; j++)
        //        {
        //            summ += Math.Pow(user.sessions[j].letters.ElementAt(i).value - average, 2);
        //        }

        //        dispersions.Add(user.sessions[0].letters.ElementAt(i).key, summ / user.sessions.Count);
        //    }

        //    user.dispersions = dispersions;
        //}
    }
}
