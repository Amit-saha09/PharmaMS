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
    public class OrdersController : ApiController
    {
        [Route("api/Order/GetAll")]
        [HttpGet]
        public List<OrderModel> GetAllOrders()
        {
            return OrdersService.GetAllOrders();
        }
        [Route("api/Order/{id}")]
        [HttpGet]
        public OrderModel GetOrder(int id)
        {
            return OrdersService.GetOrder(id);
        }
        [Route("api/Order/Add")]
        [HttpPost]
        public void AddOrder(OrderModel model)
        {
            OrdersService.AddOrder(model);
        }
    }
}