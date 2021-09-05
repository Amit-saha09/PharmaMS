using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PharmaMS.Controllers
{
    public class CartstatuController : ApiController
    {
        [Route("api/Cartstatu/GetAll")]

        [HttpGet]
        public List<CartstatuModel> GetAllCartstatus()
        {
            return CartstatuService.GetAllCartstatus();
        }
        [Route("api/Cartstatu/{id}")]
        [HttpGet]

        public CartstatuModel GetCartstatu(int id)
        {
            return CartstatuService.GetCartstatu(id);
        }
        [Route("api/Cartstatu/Add")]
        [HttpPost]

        public void AddCartstatu(CartstatuModel model)
        {
            CartstatuService.AddCartstatu(model);
        }

        [Route("api/Cartstatu/Delete/{id}")]
        [HttpPost]

        public void DeleteCartstatu([FromUri] int id)
        {
            CartstatuService.DeleteCartstatu(id);
        }
        [Route("update/{id}")]
        public void PutCartstatu([FromBody] CartstatuModel n, [FromUri] int id)
        {
            CartstatuModel emInfo = new CartstatuModel();
            emInfo = CartstatuService.GetCartstatu(id);
            emInfo.status = n.status;

            CartstatuService.UpdateCartstatu(emInfo);
        }

    }
}