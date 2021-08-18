using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weeeb.Models
{
    public class Order_items
    {
        public int order_items_id { get; set; }
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int qty { get; set; }
        public int unit_price { get; set; }
    }
}
