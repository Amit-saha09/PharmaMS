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
    public class CartController : ApiController
    {
        [Route("api/Cart/GetAll")]
        [HttpGet]
        public List<CartModel> GetAllCarts()
        {
            return CartService.GetAllCarts();
        }
        [Route("api/Cart/{id}")]
        [HttpGet]
        public CartModel GetCart(int id)
        {
            return CartService.GetCart(id);
        }
        [Route("api/Cart/Add")]
        [HttpPost]
        public void AddCart(CartModel model)
        {
            CartService.AddCart(model);
        }
    }
}