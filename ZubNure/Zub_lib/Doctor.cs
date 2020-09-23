using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
    public class Doctor
    {
        public string Name_Acives { get; set; }
        public List<Service> Avalible_service { get; private set; }

        public List<Service> Booked_service { get; set; }

        public void Add(string name, double price, DateTime time)
        {
            Booked_service.Add(new Service(name, price, time));

        }

    }
}
