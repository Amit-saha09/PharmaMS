using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class CartitemRepo
    {
        static PharmaAssistEntities1 context;
        static CartitemRepo()
        {
            context = new PharmaAssistEntities1();
        }
        public static void AddCartitem(Cartitem model)
        {
            context.Cartitems.Add(model);
            context.SaveChanges();
        }
        public static List<Cartitem> GetAllCartitems()
        {
            var data = context.Cartitems.ToList();
            return data;
        }
        public static Cartitem GetCartitem(int id)
        {
            var data = context.Cartitems.FirstOrDefault(e => e.id == id);
            return data;
        }
        public static void DeleteCartitem(Cartitem id)
        {
            context.Cartitems.Remove(id);
            context.SaveChanges();
        }

        public static void UpdateCartitemInfo(Cartitem ci)
        {
            var oldData = (from a in context.Cartitems where a.id == ci.id select a).FirstOrDefault();
            oldData.cart_id = ci.cart_id;
            oldData.med_id = ci.med_id;
            oldData.quantity = ci.quantity;
        }
    }
}
