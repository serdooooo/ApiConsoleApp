using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PaymentDetails
    {
        public class Datum
        {
            public int id { get; set; }
            public int classifiedId { get; set; }
            public object createdDate { get; set; }
            public double amount { get; set; }
            public int discount { get; set; }
        }

        public class Root
        {
            public List<Datum> data { get; set; }
        }
    }
}
