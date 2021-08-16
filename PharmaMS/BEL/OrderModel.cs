using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderModel
    {
        public int id { get; set; }
        public int cart_id { get; set; }
        public string orderstatus_status { get; set; }
        public int orderstatus_id { get; set; }
        public string employee_type { get; set; }
        public int employee_id { get; set; }
    }
}
