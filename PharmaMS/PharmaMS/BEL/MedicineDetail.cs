using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class MedicineDetail
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public string company { get; set; }
        public string description { get; set; }
        public int medtype_id { get; set; }
        public int medstatus_id { get; set; }

        public virtual ICollection<CartitemModel> Cartitems { get; set; }
    }
}
