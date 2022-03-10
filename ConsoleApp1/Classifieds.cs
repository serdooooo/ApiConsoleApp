using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Classifieds
    {
        public class ClassifiedAttribute
        {
            public int id { get; set; }
            public int classifiedId { get; set; }
            public string attributeName { get; set; }
            public string attributeValue { get; set; }
        }

        public class Coordinate
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class Datum
        {
            public int id { get; set; }
            public int userId { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string currency { get; set; }
            public double price { get; set; }
            public string status { get; set; }
            public object createdDate { get; set; }
            public string publishedBy { get; set; }
            public string city { get; set; }
            public string category { get; set; }
            public List<ClassifiedAttribute> classifiedAttributes { get; set; }
            public Coordinate coordinate { get; set; }
        }

        public class Root
        {
            public List<Datum> data { get; set; }
        }

    }
}
