using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class MedtypeDetail
    {
        public int id { get; set; }
        public string type { get; set; }

        public virtual ICollection<MedicineModel> Medicines { get; set; }

        public virtual ICollection<RequestMedicineModel> RequestMedicines { get; set; }
    }
}
