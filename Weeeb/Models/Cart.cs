using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weeeb.Models
{
    public class Cart
    {
        public int id { get; set; }
        public int p_id { get; set; }
        public string ip_add { get; set; }
        public string user_id { get; set; }
        public string qty { get; set; }
    }
}
