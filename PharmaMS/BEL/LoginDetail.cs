using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class LoginDetail
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int usertype_id { get; set; }
        public int loginaccess_id { get; set; }
        public int regstatus_id { get; set; }

        public virtual ICollection<CustomerModel> Customers { get; set; }
        public virtual ICollection<EmployeeModel> Employees { get; set; }
    }
}
