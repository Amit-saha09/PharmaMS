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
    public class CartitemController : ApiController
    {
       // [EnableCorsAttribute("*", "*", "*")]

        [Route("api/Cartitem/GetAll")]
        public List<CartitemModel> GetAllCartitem()
        {
            return CartitemService.GetAllCartitem();
        }
        [Route("api/Cartitem/{id}")]
        public CartitemModel GetCartitem(int id)
        {
            return CartitemService.GetCartitem(id);
        }
        [Route("api/Cartitem/Add")]
        public void AddCartitem(CartitemModel model)
        {
            CartitemService.AddCartitem(model);
        }
        [Route("api/Cartitem/Delete/{id}")]

        public void DeleteCartitem([FromUri] int id)
        {
            CartitemService.DeleteCartitem(id);
        }

        [Route("api/Cartitem/update/{id}")]

        public void PutCartitemInfo([FromBody] CartitemModel n, [FromUri] int id)
        {
            CartitemModel ciInfo = new CartitemModel();
            ciInfo = CartitemService.GetCartitem(id);
            ciInfo.cart_id = n.cart_id;
            ciInfo.med_id = n.med_id;
            ciInfo.quantity = n.quantity;



            CartitemService.UpdateCartitemInfo(ciInfo);

        }
    }
}
