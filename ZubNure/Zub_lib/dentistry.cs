using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
    [Serializable]
    class Dentistry
    {
        public List<User> Users { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Appointment> Appointments { get; set; }

        public Dentistry()
        {
            Users = new List<User>();
            Doctors = new List<Doctor>();
            Appointments = new List<Appointment>();
        }

        public void Save()
        {
            new Dao(this).Save();
        }

        public void Load()
        {
            new Dao(this).Load();
        }
    }
}
