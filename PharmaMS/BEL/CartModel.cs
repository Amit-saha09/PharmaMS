using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CartModel
    {
        public int id { get; set; }
        public string customer_name { get; set; }

        public int customer_id { get; set; }
        public string cartstatus_status { get; set; }
        public int cartstatus_id { get; set; }
    }
}
