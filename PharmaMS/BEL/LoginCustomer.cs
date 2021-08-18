using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class LoginCustomer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public DateTime dob { get; set; }

        public string bloodgroup { get; set; }

        public string gender { get; set; }

        public string contact { get; set; }

        public string address { get; set; }

        public int salary { get; set; }

        public int login_id { get; set; }

        public int usertype_id { get; set; }
        public int loginaccess_id { get; set; }
        public int regstatus_id { get; set; }




    }
}
