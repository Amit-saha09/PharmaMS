using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class LoginModel
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int usertype_id { get; set; }
        public int loginaccess_id { get; set; }
        public int regstatus_id { get; set; }

        public virtual LoginaccessModel Loginaccess { get; set; }
        public virtual RegstatuModel Regstatu { get; set; }
        public virtual UsertypeModel Usertype { get; set; }
    }
}
