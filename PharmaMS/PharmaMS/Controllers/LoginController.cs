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

        [Route("user")]
        public LoginModel GetLogin([FromBody]LoginModel user)
        {
            return LoginService.GetLogin(user);
        }

        [Route("user/add")]
        public void AddUser(LoginModel n)
        {
            LoginService.AddUser(n);
        }

        [Route("user/update/{id}")]
        public void UpdateUser([FromBody]LoginModel n, [FromUri] int id)
        {
            //LoginService.UpdateUser(n);
        }

        [Route("user/delete/{id}")]
        public void DeleteUser([FromUri] int id)
        {
            LoginService.DeleteUser(id);
        }
    }
}
