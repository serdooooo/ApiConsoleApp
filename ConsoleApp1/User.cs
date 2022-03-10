using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User : UserDatum
    {

    }

    public class Root
    {
        public List<User> data { get; set; }
    }
}
