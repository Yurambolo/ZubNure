using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
    [Serializable]
    class Appointment
    {
        public Doctor doctor { get; set; }
        public Service service { get; set; }
        public DateTime time { get; set; }
        public User user { get; set; }

        public Appointment (User user, Doctor doctor, Service service, DateTime time)
        {
            this.doctor = doctor;
            this.service = service;
            this.user = user;
            this.time = time;

        }
    }
}
