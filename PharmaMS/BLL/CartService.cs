using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CartService
    {
        /*  static CartService()
          {

              AutoMapper.Mapper.Initialize(config => config.AddProfile<MapperConfig.AutoMapperSettings>());
          }*/
        public static void AddCart(CartModel model)
        {
            var data = AutoMapper.Mapper.Map<CartModel, Cart>(model);
            CartRepo.AddCart(data);
        }
        public static CartModel GetCart(int id)
        {
            var data = CartRepo.GetCart(id);
            var ct = AutoMapper.Mapper.Map<Cart, CartModel>(data);
            return ct;
        }
        public static List<CartModel> GetAllCarts()
        {
            var data = CartRepo.GetAllCarts();
            var ct = AutoMapper.Mapper.Map<List<Cart>, List<CartModel>>(data);
            return ct;
        }
        public static void DeleteCart(int id)
        {
            Cart data = CartRepo.GetCart(id);
            CartRepo.DeleteCart(data);
        }

        public static void UpdateCart(CartModel em)
        {
            var data = AutoMapper.Mapper.Map<CartModel, Cart>(em);
            CartRepo.UpdateCart(data);
        }

    }
}