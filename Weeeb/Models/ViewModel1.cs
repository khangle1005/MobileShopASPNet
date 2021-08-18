using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weeeb.Models
{
    public class ViewModel1
    {
        public IEnumerable<User_Info> sp1 { get; set; }
        public IEnumerable<Email_Info> sp2 { get; set; }
        public IEnumerable<Categories> sp3 { get; set; }
        public IEnumerable<Brands> sp4 { get; set; }
    }
}
