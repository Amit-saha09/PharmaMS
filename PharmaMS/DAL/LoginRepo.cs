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

        public static List<Login> GetAllLogin()
        {
            return context.Logins.ToList();
        }

        public static Login GetUserLogin(string email, string password)
        {
            return context.Logins.FirstOrDefault(c => c.email == email && c.password == password);
        }

        public static void AddUser(Login n)
        {
            context.Logins.Add(n);
            context.SaveChanges();
        }

        public static void UpdateUser(Login u)
        {
            //context.Logins.
            context.SaveChanges();
        }

        public static void DeleteUser(Login d)
        {
            context.Logins.Remove(d);
            context.SaveChanges();
        }

        public static Login GetUserByID(int id)
        {
            return context.Logins.FirstOrDefault(c => c.id == id);
        }
    }

}