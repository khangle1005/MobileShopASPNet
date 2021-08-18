using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weeeb.Models
{
    public class Orders
    {
        public int order_id { get; set; }
        public int user_id { get; set; }
        public string order_date { get; set; }
        public int quantity { get; set; }
        public int total { get; set; }
        public int paid_status { get; set; }
        public int status { get; set; }

    }
}
