using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class TourPackage
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public string Transport { get; set; }
        public string Food { get; set; }
        public double Price { get; set; }

        public TourPackage(string name, string type, int duration, string transport, string food, double price)
        {
            Name = name;
            Type = type;
            Duration = duration;
            Transport = transport;
            Food = food;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Type} ({Duration} days) - {Price}$";
        }
    }
}
