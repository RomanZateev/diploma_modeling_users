using System;
using System.Collections.Generic;
using System.Linq;

namespace Modeling
{
    public class SessionModeling
    {
        private UserPattern pattern;

        static readonly Random random = new Random();

        public SessionModeling(UserPattern _pattern)
        {
            pattern = _pattern;
        }

        public SessionModeling()
        {

        }

        //генерация сессий
        public void Generate(int value)
        {
            List<Session> sessions = new List<Session>();

            for (int i = 0; i < value; i++)
            {
                Session session = new Session(pattern.Login);

                List<Letter> letters = new List<Letter>();

                foreach (Letter ExpectedValue in pattern.ExpectedValues)
                {
                    Letter letter = new Letter
                    {
                        Key = ExpectedValue.Key,
                        Value = BoxMuller(ExpectedValue.Value, Math.Sqrt(pattern.Dispersions.FirstOrDefault(x => x.Key.Equals(ExpectedValue.Key)).Value))
                    };

                    letters.Add(letter);
                }

                session.Letters = letters;

                sessions.Add(session);
            }

            ShowSessions showSessions = new ShowSessions(sessions);
            showSessions.Show();
        }

        private double BoxMuller(double m, double sigma)
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