using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CartDetail
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public int cartstatus_id { get; set; }

        public virtual ICollection<CartitemModel> Cartitems { get; set; }
        public virtual ICollection<OrderModel> Orders { get; set; }
    }
}
