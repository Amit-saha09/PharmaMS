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
        [Route("delete/{id}")]
        public void DeleteCart([FromUri] int id)
        {
            CartService.DeleteCart(id);
        }

        [Route("update/{id}")]
        public void PutCart([FromBody] CartModel n, [FromUri] int id)
        {
            CartModel emInfo = new CartModel();
            emInfo = CartService.GetCart(id);
            emInfo.cartstatus_id = n.cartstatus_id;
            emInfo.customer_id = n.customer_id;
         

            CartService.UpdateCart(emInfo);
        }
    }
}