using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class RequestMedicineModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public string medtype_type { get; set; }
        public int medtype_id { get; set; }
        public string customer_name { get; set; }
        public int customer_id { get; set; }
        public string requeststatus_status { get; set; }
        public int requeststatus_id { get; set; }
    }
}
