using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class OrderList
    {
        public int OrderID { get; set; }
        public DateTime Ordershortdate { get; set; }
        public DateTime Orderdate { get; set; }
        public int OrderTotalPrice { get; set; }
    }
}
