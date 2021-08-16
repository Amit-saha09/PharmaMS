using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class MedicineModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public string company { get; set; }
        public string description { get; set; }
        public string medtype_type { get; set; }
        public string medstatu_status{ get; set; }
        public int medtype_id { get; set; }
        public int medstatus_id { get; set; }

        
    }
}
