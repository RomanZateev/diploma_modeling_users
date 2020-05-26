using System.Collections.Generic;

namespace Modeling
{
    public class UserPattern
    {
        public string Login { get; set; }

        //public Dictionary<string, double> expectedValues { get; set; }
        public List<Letter> expectedValues { get; set; }

        //public Dictionary<string, double> dispersions { get; set; }
        public List<Letter> Dispersions { get; set; }

    }
}
