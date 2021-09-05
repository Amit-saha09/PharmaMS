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

    [RoutePrefix("api/customers")]
    public class CustomerController : ApiController
    {
        [Route("")]
        [HttpGet]
        public List<CustomerModel> GetAllCustomer()
        {
            return CustomerService.GetAllCustomer();
        }

        [Route("{id}")]
        [HttpGet]
        public CustomerModel GetCustomerID([FromUri] int id)
        {
            return CustomerService.GetCustomerById(id);
        }
        [Route("login/{id}")]
        [HttpGet]
        public CustomerModel GetCustomerbyloginID([FromUri] int id)
        {
            return CustomerService.GetCustomerByloginId(id);
        }

        [Route("add")]
        [HttpPost]
        public void PostCustomer([FromBody] CustomerModel em)
        {
            CustomerService.AddCustomer(em);
        }

        [Route("delete/{id}")]
        public void DeleteCustomer([FromUri] int id)
        {
            CustomerService.DeleteCustomer(id);
        }

        [Route("update/{id}")]
        [HttpPost]
        public void UpdateCustomerInfo([FromBody] CustomerModel n, [FromUri] int id)
        {
            CustomerModel emInfo = new CustomerModel();
            emInfo = CustomerService.GetCustomerById(id);
            emInfo.name = n.name;
            emInfo.dob = n.dob;
            emInfo.bloodgroup = n.bloodgroup;
            emInfo.gender = n.gender;
            emInfo.contact = n.contact;
            emInfo.address = n.address;
            
            emInfo.image = n.image;

            CustomerService.UpdateCustomer(emInfo);
        }

    }
}
