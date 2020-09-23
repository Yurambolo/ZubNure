using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
    class Appointment
    {
        public Doctor doctor { get; set; }
        public Service service { get; set; }

        public User user { get; set; }

        public Appointment (Doctor d, Service s, User u)
        {
            doctor = d;
            service = s;
            user = u;

        }
    }
}
