using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class RequeststatuDetail
    {
        public int id { get; set; }
        public string status { get; set; }

        public virtual ICollection<RequestMedicineModel> RequestMedicines { get; set; }
    }
}
