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
        public static void DeleteCart(Cart id)
        {
            context.Carts.Remove(id);
            context.SaveChanges();
        }
<<<<<<< HEAD
        public static void UpdateCartInfo(Cart med)
        {
            var oldData = (from a in context.Carts where a.id == med.id select a).FirstOrDefault();
            oldData.cartstatus_id = med.customer_id;
            oldData.cartstatus_id = med.cartstatus_id;
           
=======
        public static void UpdateCart(Cart em)
        {
            var oldData = (from a in context.Carts where a.id == em.id select a).FirstOrDefault();
            oldData.cartstatus_id = em.cartstatus_id;
            oldData.customer_id = em.customer_id;
>>>>>>> d40c6b51c0213c3393f7f0d0d52b3f332ae94dae
            context.SaveChanges();
        }

    }
}