using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class UsertypeDetail
    {
        public int id { get; set; }
        public string type { get; set; }

        public virtual ICollection<LoginModel> Logins { get; set; }
    }
}
