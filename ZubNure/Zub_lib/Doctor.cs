using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
    [Serializable]
    public class Doctor
    {
        public string Name_Acives { get; set; }
        public List<Service> Avalible_service { get; private set; }
        public List<DateTime> Availible_time { get; set; }
        public List<DateTime> Booked_time { get; set; }

        public void Book(DateTime time)
        {
            Booked_time.Add(time);
            Availible_time.Remove(time);
        }

    }
}
