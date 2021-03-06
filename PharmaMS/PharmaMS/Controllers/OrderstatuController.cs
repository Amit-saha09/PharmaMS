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
    public class OrderstatuController : ApiController
    {
        [Route("api/Orderstatu/GetAll")]
        [HttpGet]
        public List<OrderstatuModel> GetAllOrderstatu()
        {
            return OrderstatuService.GetAllOrderstatu();
        }
        [Route("api/Orderstatu/{id}")]
        [HttpGet]
        public OrderstatuModel GetOrderstatu(int id)
        {
            return OrderstatuService.GetOrderstatu(id);
        }
        [Route("api/Orderstatu/Add")]
        [HttpPost]
        public void AddOrderstatu(OrderstatuModel model)
        {
            OrderstatuService.AddOrderstatu(model);
        }
        [Route("api/Orderstatu/Delete/{id}")]
        
        public void DeleteOrderstatu([FromUri] int id)
        {
            OrderstatuService.DeleteOrderstatu(id);
        }
        [Route("api/Orderstatu/update/{id}")]
       
        public void PutOrderstatu([FromBody] OrderstatuModel n, [FromUri] int id)
        {
            OrderstatuModel emInfo = new OrderstatuModel();
            emInfo = OrderstatuService.GetOrderstatu(id);
            emInfo.status = n.status;
            OrderstatuService.UpdateOrderstatu(emInfo);
        }
    }
}
