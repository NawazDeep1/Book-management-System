using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
    public class Order
    {
        public int OrderID { get; set; }

        public int ClientID { get; set; }

        public long BookID { get; set; }

        public int Quantity { get; set; }
    }
}
