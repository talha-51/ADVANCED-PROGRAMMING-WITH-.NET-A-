using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class orderModel
    {
        public int order_id { get; set; }
        public int restaurant_id { get; set; }
        public string restaurant_name { get; set; }
        public int customer_id { get; set; }
        public int price_on_selling_time { get; set; }
        public int amount { get; set; }
        public string area { get; set; }
        public string address { get; set; }
    }
}
