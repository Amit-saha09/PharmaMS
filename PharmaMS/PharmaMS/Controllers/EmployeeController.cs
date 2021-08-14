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
            public EmployeeModel GetEmployeebyID(int id)
            {
                return EmployeeService.GetEmployeebyID(id);
            }

            [Route("name")]
            [HttpGet]
            public List<string> GetEmployeeByName()
            {
                return EmployeeService.GetEmployeeByName();
            }

            /*[Route("add")]
            [HttpPost]
            public void AddEmployee(EmployeeModel em)
            {
                EmployeeService.AddEmployee(em);
            }*/

            [Route("delete/{id}")]
            public void DeleteEmployee([FromUri] int id)
            {
                EmployeeService.DeleteEmployee(id);
            }

        [Route("update/{id}")]
        public void PutEmployeeInfo([FromBody] EmployeeModel n, [FromUri] int id)
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
