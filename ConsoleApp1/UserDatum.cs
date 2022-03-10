using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class UserDatum
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string status { get; set; }
    }
}
