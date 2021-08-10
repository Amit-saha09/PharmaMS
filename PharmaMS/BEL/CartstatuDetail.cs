using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CartstatuDetail
    {
        public int id { get; set; }
        public string status { get; set; }

        public virtual ICollection<CartModel> Carts { get; set; }
    }
}
