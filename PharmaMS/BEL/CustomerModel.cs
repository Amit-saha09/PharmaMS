using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CustomerModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public System.DateTime dob { get; set; }
        public string bloodgroup { get; set; }
        public string gender { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string image { get; set; }
        public string login_email {get; set; }
        public int login_id { get; set; }
    }
}
