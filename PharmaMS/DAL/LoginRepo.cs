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

        public static Login GetUserLoginByID(int id)
        {
            return context.Logins.FirstOrDefault(c => c.id == id);
        }

        public static void AddUser(Login n)
        {
            context.Logins.Add(n);
            context.SaveChanges();
        }

        public static void UpdateUserInfo(Login u)
        {
            /*using (var p2 = new PharmaAssistEntities1())
            {
                int e = p2.Database.ExecuteSqlCommand("UPDATE Logins SET password = '" + u.password + "' WHERE id = '" + u.id + "'");
            }*/
            var oldData = (from a in context.Logins where a.id == u.id select a).FirstOrDefault();
            oldData.password = u.password;
            oldData.loginaccess_id = u.loginaccess_id;
            oldData.regstatus_id = u.regstatus_id;
            context.SaveChanges();
           // context.Logins.
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