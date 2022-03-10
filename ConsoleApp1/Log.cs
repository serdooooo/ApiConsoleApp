using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Log
    {
        public class Datum
        {
            public int id { get; set; }
            public int userId { get; set; }
            public string endpoint { get; set; }
            public object createdDate { get; set; }
        }

        public class Root
        {
            public List<Datum> data { get; set; }
        }
    }
}
