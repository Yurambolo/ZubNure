using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
   public class Service {

        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Time { get; set; }

        public Service (string name, double price)
        {
            Name = name;
            Price = price;

        }

        public Service(string name, double price, DateTime time) : this(name, price)
        {
            Time = time;
        }
    }
}
