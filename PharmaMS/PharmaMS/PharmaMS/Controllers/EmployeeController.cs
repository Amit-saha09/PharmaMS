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

    [RoutePrefix("api/employees")]
    public class EmployeeController : ApiController
        {
            [Route("")]
            [HttpGet]
            public List<EmployeeModel> GetAllEmployee()
            {
                return EmployeeService.GetAllEmployee();
            }

            [Route("{id}")]
            [HttpGet]
            public EmployeeModel GetEmployeebyID([FromUri]int id)
            {
                return EmployeeService.GetEmployeebyID(id);
            }

        [Route("login/{id}")]
        [HttpGet]
        public EmployeeModel GetEmployeebyloginID([FromUri] int id)
        {
            return EmployeeService.GetEmployeebyloginID(id);
        }

        [Route("name/{id}")]
            [HttpGet]
            public List<EmployeeModel> GetEmployeeByName([FromUri] string id)
            {
                return EmployeeService.GetEmployeeByName(id);
            }

            [Route("add")]
            [HttpPost]
            public void PostEmployee([FromBody]EmployeeModel em)
            {
                EmployeeService.AddEmployee(em);
            }

            [Route("delete/{id}")]
            public void DeleteEmployee([FromUri] int id)
            {
                EmployeeService.DeleteEmployee(id);
            }

        [Route("update/{id}")]
        [HttpPost]
        public void updateEmployeeInfo([FromBody] EmployeeModel n, [FromUri] int id)
        {
            EmployeeModel emInfo = new EmployeeModel();
            emInfo = EmployeeService.GetEmployeebyID(id);
            emInfo.name = n.name;
            emInfo.dob = n.dob;
            emInfo.bloodgroup = n.bloodgroup;
            emInfo.gender = n.gender;
            emInfo.contact = n.contact;
            emInfo.address = n.address;
            emInfo.salary = n.salary;
            emInfo.image = n.image;

            EmployeeService.UpdateEmployeeInfo(emInfo);
        }
    }
}
