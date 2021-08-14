using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginService
    {
        public static List<LoginModel> GetLogins()
        {
            var Logins = LoginRepo.GetAllLogin();
            var data = AutoMapper.Mapper.Map<List<Login>, List<LoginModel>>(Logins);
            return data;
        }

        public static LoginModel GetLogin(LoginModel user)
        {
            var Logins = LoginRepo.GetUserLogin(user.email, user.password);
            var data = AutoMapper.Mapper.Map<Login, LoginModel>(Logins);
            return data;
        }

        public static void AddUser(LoginModel n)
        {
            var data = AutoMapper.Mapper.Map<LoginModel, Login>(n);
            LoginRepo.AddUser(data);
        }

        public static void UpdateUser(LoginModel u, int id)
        {
            var data = AutoMapper.Mapper.Map<LoginModel, Login>(u);
            //LoginRepo.UpdateUser(data, id);
        }

        public static void DeleteUser(int id)
        {
            Login data = LoginRepo.GetUserByID(id);
            LoginRepo.DeleteUser(data);
        }
    }
}
