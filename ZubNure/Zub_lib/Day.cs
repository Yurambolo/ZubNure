using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zub_lib
{
    [Serializable]
    public class Day
    {
        public DateTime date { get; set; }
        public List<string> time { get; set; }

        public Day(DateTime date, List<string> time)
        {
            this.date = date;
            this.time = new List<string>(time);
        }

    }
}
