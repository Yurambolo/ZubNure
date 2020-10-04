using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
    [Serializable]
    public class Appointment
    {
        public Doctor doctor { get; set; }
        public string time { get; set; }
        public User user { get; set; }

        public Appointment (User user, Doctor doctor, string time)
        {
            this.doctor = doctor;
            this.user = user;
            this.time = time;

        }
    }
}
