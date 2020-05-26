using System;
using System.Collections.Generic;
namespace Modeling
{
    public class UserActivity
    {
        public string login { get; set; }

        public List<Session> sessions { get; set; }

        //public Dictionary<string, double> dispersions { get; set; }
    }
}
