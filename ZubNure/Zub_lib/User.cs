using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
    class User
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public DateTime Birthday { get; set; }

        public User (string name, string mobile, DateTime time)
        {
            Name = name;
            Mobile = mobile;
            Birthday = time;
        }


    }
}
