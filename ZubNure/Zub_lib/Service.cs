using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
    [Serializable]
    public class Service {

        public string Name { get; set; }
        public double Price { get; set; }

        public Service (string name, double price)
        {
            Name = name;
            Price = price;

        }
    }
}
