using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weeeb.Models
{
    public class Order_info
    {
        public int order_info_id { get; set; }
        public int order_id { get; set; }
        public int user_id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string note { get; set; }
    }
}
