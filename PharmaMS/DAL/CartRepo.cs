using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CartRepo
    {
        static PharmaAssistEntities1 context;
        static CartRepo()
        {
            context = new PharmaAssistEntities1();
        }
        public static void AddCart(Cart model)
        {
            context.Carts.Add(model);
            context.SaveChanges();
        }
        public static List<Cart> GetAllCarts()
        {
            var data = context.Carts.ToList();
            return data;

        }
        public static Cart GetCart(int id)
        {
            var data = context.Carts.FirstOrDefault(e => e.id == id);
            return data;
        }

    }
}