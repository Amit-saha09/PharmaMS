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

        public static LoginModel GetLogin(string email, string password)
        {
            var Logins = LoginRepo.GetUserLogin(email,password);
            var data = AutoMapper.Mapper.Map<Login, LoginModel>(Logins);
            return data;
        }

        public static LoginModel GetLoginByID(int id)
        {
            var Logins = LoginRepo.GetUserLoginByID(id);
            var data = AutoMapper.Mapper.Map<Login, LoginModel>(Logins);
            return data;
        }

        public static void AddUser(LoginCustomer lc)
        {
            Login n = new Login();
            n.email = lc.email;
            n.password = lc.password;
            n.loginaccess_id = lc.loginaccess_id;
            n.regstatus_id = lc.regstatus_id;
            n.usertype_id = lc.usertype_id;
            // var data = AutoMapper.Mapper.Map<LoginModel, Login>(n);
            LoginRepo.AddUser(n);

            var logid = LoginRepo.GetUserLogin(n.email, n.password);
            var employe = new Employee();
            employe.name = lc.name;
            employe.dob = lc.dob;
            employe.bloodgroup = lc.bloodgroup;
            employe.contact = lc.contact;
            employe.gender = lc.gender;
            employe.address = lc.address;
            employe.salary = lc.salary;
            employe.login_id = logid.id;

            EmployeeRepo.AddEmployee(employe);
        }
        public static void AddCustomerr(LoginCustomer cu)
        {
            Login x = new Login();
            x.email = cu.email;
            x.password = cu.password;
            x.loginaccess_id = cu.loginaccess_id;
            x.regstatus_id = cu.regstatus_id;
            x.usertype_id = cu.usertype_id;
            // var data = AutoMapper.Mapper.Map<LoginModel, Login>(n);
            LoginRepo.AddUser(x);

            var logid = LoginRepo.GetUserLogin(x.email, x.password);
            var custome = new Customer();
            custome.name = cu.name;
            custome.dob = cu.dob;
            custome.bloodgroup = cu.bloodgroup;
            custome.contact = cu.contact;
            custome.gender = cu.gender;
            custome.address = cu.address;
            custome.login_id = logid.id;
            CustomerRepo.AddCustomer(custome);

        }


        

        public static void UpdateUserInfo(LoginModel u)
        {
            var data = AutoMapper.Mapper.Map<LoginModel, Login>(u);
            LoginRepo.UpdateUserInfo(data);
        }

        public static void ApproveAllRegStatus()
        {
            LoginRepo.ApproveAllRegStatus();
        }

        public static void DeleteUser(int id)
        {
            Login data = LoginRepo.GetUserByID(id);
            LoginRepo.DeleteUser(data);
        }
    }
}
