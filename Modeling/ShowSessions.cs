using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Modeling
{
    public partial class ShowSessions : Form
    {
        static string generated = @"stats/generated.json";

        static List<Session> SessionsGlobal = new List<Session>();

        public ShowSessions(List<Session> sessions)
        {
            InitializeComponent();
            SessionsGlobal = sessions;

            foreach (Session session in sessions)
            {
                string jsonString;

                jsonString = JsonConvert.SerializeObject(session);

                Sessions.Items.Add(jsonString);
            }

            saveFileDialog.Filter = "JSON files(*.json)|*.json";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                generated = saveFileDialog.FileName;

            WriteToFile(SessionsGlobal);
        }

        static void WriteToFile(List<Session> users)
        {
            File.WriteAllText(generated, String.Empty);

            using (StreamWriter file = File.CreateText(generated))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, users);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
