using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
    [Serializable]
    public class Dentistry
    {
        Random r;
        public List<User> Users { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Service> Services { get; set; }
        //public List<Appointment> Appointments { get; set; }

        public Dentistry()
        {
            Users = new List<User>();
            Doctors = new List<Doctor>();
            r = new Random();
            //Appointments = new List<Appointment>();
        }

        public void Save()
        {
            new Dao(this).Save();
        }

        public void Load()
        {
            new Dao(this).Load();
        }

        public void FillTD (int n)
        {   
            Doctors = new List<Doctor>();
            string[] names = new string[5] {"Джон Сноу","Мария Ивнова","Иван Олегов","Заур Гозеев","Василий Петров"};
            DateTime t = DateTime.Now;

            for(int i =0; i<=n; ++i)
            {
                var d = new Doctor();
                d.Name_Acives = names[i % names.Length];
                string path = $"{i % names.Length}.jpg";
                d.Image = new System.Drawing.Bitmap(System.IO.Path.GetFullPath(path));
                d.Availible_days = new List<Day>();
                List<string> standarttime = new List<string>() { "10:00","11:00","12:00","13:00","14:00"};

                for (int j = 0; j <= 30 ; ++j)
                {
                    DateTime someday = DateTime.Today.AddDays(j);
                    if (someday.DayOfWeek != DayOfWeek.Saturday && someday.DayOfWeek != DayOfWeek.Sunday)
                        d.Availible_days.Add(new Day(someday, standarttime));
                }

                Doctors.Add(d);
            }


        }
    }
}
