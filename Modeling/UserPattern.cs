using System.Collections.Generic;

namespace Modeling
{
    public class UserPattern
    {
        public string Login { get; set; }

        public List<Letter> ExpectedValues { get; set; }

        public List<Letter> Dispersions { get; set; }

    }
}
