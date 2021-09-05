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
    public class CartController : ApiController
    {
        [Route("api/Cart/GetAll")]
        [HttpGet]
        public List<CartModel> GetAllCarts()
        {
            return CartService.GetAllCarts();
        }
        [Route("api/Cart/pending/{id}")]
        [HttpGet]
        public CartModel GetCart(int id)
        {

            var p=  CartService.GetCart(id);
            if (p != null)
            {
                return p;
            }
            else
            {
                var q = new CartModel();
                q.cartstatus_id = 3;
                q.customer_id = id;
                AddCart(q);
                return CartService.GetCart(id);
            }
        }


        [Route("api/Cart/Add")]
        [HttpPost]
        public void AddCart(CartModel model)
        {
            CartService.AddCart(model);
        }

        [Route("api/Cart/Delete/{id}")]

        public void DeleteCart([FromUri] int id)
        {
            CartService.DeleteCart(id);
        }


        [Route("api/Cart/Update/{id}")]


        public void PutCartInfo([FromBody] CartModel n, [FromUri] int id)
        {
            CartModel medInfo = new CartModel();
            medInfo = CartService.GetCart(id);
            medInfo.customer_id = n.customer_id;
            medInfo.cartstatus_id = n.cartstatus_id;
           

            CartService.UpdateCartInfo(medInfo);

       }
    }
}