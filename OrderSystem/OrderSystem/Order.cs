using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Order
    {
        public int OrderID { get; set; }
        public DateTime Ordershortdate { get; set; }
        public  DateTime Orderdate { get; set; }
        public string OrderProductName { get; set; }
        public int OrderPrice { get; set; }
        public int OrderCount { get; set; }
        public int OrderTotalPrice { get; set; }
    }
}
