using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weeeb.Models
{
    public class CartItem
    {
        public Products Product { get; set; }
        public int Quantity { get; set; }
    }
}
