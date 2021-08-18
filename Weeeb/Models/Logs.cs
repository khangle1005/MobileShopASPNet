using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weeeb.Models
{
    public class Logs
    {
        public int id { get; set; }
        public string user_id { get; set; }
        public string action { get; set; }
        public DateTime date { get; set; }
    }
}
