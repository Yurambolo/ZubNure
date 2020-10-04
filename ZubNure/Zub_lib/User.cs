using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public User (string name, string mobile, string email)
        {
            Name = name;
            Mobile = mobile;
            Email = email;
        }


    }
}
