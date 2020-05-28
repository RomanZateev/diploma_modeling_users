using System;
using System.Collections.Generic;
using System.Linq;

namespace Modeling
{
    public class SessionModeling
    {
        public List<UserPattern> Patterns;

        public static List<Session> NewSessions = new List<Session>();

        static readonly Random random = new Random();

        public SessionModeling(List<UserPattern> userPatterns)
        {
            Patterns = userPatterns;
        }

        //генерация сессий
        public void Generate(int value)
        {
            List<Session> sessions = new List<Session>();

            for (int i = 0; i < value; i++)
            {
                int mod = i % Patterns.Count;

                var pattern = Patterns[mod];

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
