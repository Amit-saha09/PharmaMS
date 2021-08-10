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

        [Route("user/email/{email}/password/{password}")]
        public LoginModel GetUser([FromUri]string email, [FromUri] string password)
        {
            LoginModel user = new LoginModel();
            user.email = email;
            user.password = password;
            return LoginService.GetLogin(user);
        }
    }
}
