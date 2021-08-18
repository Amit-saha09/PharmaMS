using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PharmaMS.Controllers
{
    [EnableCorsAttribute("*", "*", "*")]

    [RoutePrefix("api/logins")]
    public class LoginController : ApiController
    {
        [Route("")]
        public List<LoginModel> GetLogins()
        {
            return LoginService.GetLogins();
        }

        /*
        [Route("user/email/{email}/password/{password}")]
        public LoginModel GetUser([FromUri]string email, [FromUri] string password)
        {
            LoginModel user = new LoginModel();
            user.email = email;
            user.password = password;
            return LoginService.GetLogin(user);
        }
        */


        [Route("get/{email}/{password}")]
        public LoginModel GetLogin(string email, string password)
        {
            return LoginService.GetLogin(email,password);
        }

        [Route("user")]
        public LoginModel GetLoginByID([FromUri] int id)
        {
            return LoginService.GetLoginByID(id);
        }

        //Only for employee adding
        [Route("user/add")]
        public void AddUser([FromBody]LoginCustomer lc)
        {
            lc.usertype_id = 2;
            lc.regstatus_id = 1;
            lc.loginaccess_id = 1;
            LoginService.AddUser(lc);
        }
        [Route("user/customer/add")]
        public void AddCustomerr([FromBody] LoginCustomer cu)
        {
            cu.usertype_id = 4;
            cu.regstatus_id = 1;
            cu.loginaccess_id = 1;
            LoginService.AddCustomerr(cu);
        }

        //Only for customer reagistration
        [Route("user/add/registration")]
       // public void AddRegistration([FromBody] LoginModel n)
        //{
       //     n.loginaccess_id = 2;
       //     n.regstatus_id = 3;

         //   LoginService.AddUser(n);
       // }

        [Route("user/update/password/{id}")]
        public void PutUserPassword([FromBody]LoginModel n, [FromUri] int id)
        {
            LoginModel userInfo = new LoginModel();
            userInfo = LoginService.GetLoginByID(id);
            userInfo.password = n.password;

            LoginService.UpdateUserInfo(userInfo);
        }

        [Route("user/update/access/enable/{id}")]
        public void PutUserAccessEnable([FromUri] int id)
        {
            LoginModel userInfo = new LoginModel();
            userInfo = LoginService.GetLoginByID(id);
            userInfo.loginaccess_id = 1;

            LoginService.UpdateUserInfo(userInfo);
        }

        [Route("user/update/access/disable/{id}")]
        public void PutUserAccessDisable([FromUri] int id)
        {
            LoginModel userInfo = new LoginModel();
            userInfo = LoginService.GetLoginByID(id);
            userInfo.loginaccess_id = 2;

            LoginService.UpdateUserInfo(userInfo);
        }

        [Route("user/update/registration/approve/{id}")]
        public void PutUserRegApprove([FromUri] int id)
        {
            LoginModel userInfo = new LoginModel();
            userInfo = LoginService.GetLoginByID(id);
            userInfo.loginaccess_id = 1;
            userInfo.regstatus_id = 1;

            LoginService.UpdateUserInfo(userInfo);
        }

        [Route("user/update/registration/approve/all")]
        public void PutUserRegApproveAll()
        {
            LoginService.ApproveAllRegStatus();
        }

        [Route("user/update/registration/reject/{id}")]
        public void PutUserRegReject([FromUri] int id)
        {
            LoginModel userInfo = new LoginModel();
            userInfo = LoginService.GetLoginByID(id);
            userInfo.regstatus_id = 2;

            LoginService.UpdateUserInfo(userInfo);
        }

        [Route("user/delete/{id}")]
        public void DeleteUser([FromUri] int id)
        {
            LoginService.DeleteUser(id);
        }
    }
}
