using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class CartitemService
    {
        public static void AddCartitem(CartitemModel model)
        {
            var data = AutoMapper.Mapper.Map<CartitemModel, Cartitem>(model);
            CartitemRepo.AddCartitem(data);
        }
        public static CartitemModel GetCartitem(int id)
        {
            var data = CartitemRepo.GetCartitem(id);
            var ca = AutoMapper.Mapper.Map<Cartitem, CartitemModel>(data);
            return ca;
        }
        public static List<CartitemModel> GetAllCartitem()
        {
            var data = CartitemRepo.GetAllCartitems();
            var ca = AutoMapper.Mapper.Map<List<Cartitem>, List<CartitemModel>>(data);
            return ca;
        }
        public static void DeleteCartitem(int id)
        {
            Cartitem data = CartitemRepo.GetCartitem(id);
            CartitemRepo.DeleteCartitem(data);
        }

        public static void UpdateCartitemInfo(CartitemModel ci)
        {
            var data = AutoMapper.Mapper.Map<CartitemModel, Cartitem>(ci);
            CartitemRepo.UpdateCartitemInfo(data);
        }
    }
}
