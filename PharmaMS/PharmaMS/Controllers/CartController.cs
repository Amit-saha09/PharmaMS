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
<<<<<<< HEAD
        [Route("api/Cart/Delete/{id}")]
=======
        [Route("delete/{id}")]
>>>>>>> d40c6b51c0213c3393f7f0d0d52b3f332ae94dae
        public void DeleteCart([FromUri] int id)
        {
            CartService.DeleteCart(id);
        }

        [Route("update/{id}")]
<<<<<<< HEAD
        public void PutCartInfo([FromBody] CartModel n, [FromUri] int id)
        {
            CartModel medInfo = new CartModel();
            medInfo = CartService.GetCart(id);
            medInfo.customer_id = n.customer_id;
            medInfo.cartstatus_id = n.cartstatus_id;
           

            CartService.UpdateCartInfo(medInfo);
=======
        public void PutCart([FromBody] CartModel n, [FromUri] int id)
        {
            CartModel emInfo = new CartModel();
            emInfo = CartService.GetCart(id);
            emInfo.cartstatus_id = n.cartstatus_id;
            emInfo.customer_id = n.customer_id;
         

            CartService.UpdateCart(emInfo);
>>>>>>> d40c6b51c0213c3393f7f0d0d52b3f332ae94dae
        }
    }
}