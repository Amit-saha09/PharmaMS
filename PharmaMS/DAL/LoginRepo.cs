using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginRepo
    {
        static PharmaAssistEntities1 context;
        static LoginRepo()
        {
            context = new PharmaAssistEntities1();
        }

        public static List <Login> GetAllLogin()
        {
            return context.Logins.ToList();
        }

        public static Login GetUserLogin(Login user)
        {
            return context.Logins.FirstOrDefault(c => c.email == user.email && c.password == user.password);
        }

    }

}
