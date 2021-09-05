using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderstatuRepo
    {
        static PharmaAssistEntities1 context;
        static OrderstatuRepo()
        {
            context = new PharmaAssistEntities1();
        }
        public static void AddOrderstatu(Orderstatu model)
        {
            context.Orderstatus.Add(model);
            context.SaveChanges();
        }
        public static List<Orderstatu> GetAllOrderstatus()
        {
            var data = context.Orderstatus.ToList();
            return data;
        }
        public static Orderstatu GetOrderstatu(int id)
        {
            var data = context.Orderstatus.FirstOrDefault(e => e.id == id);
            return data;
        }
        public static void DeleteOrderstatu(Orderstatu id)
        {
            context.Orderstatus.Remove(id);
            context.SaveChanges();
        }
        public static void UpdateOrderstatu(Orderstatu em)
        {
            var oldData = (from a in context.Orderstatus where a.id == em.id select a).FirstOrDefault();
            oldData.status = em.status;
            context.SaveChanges();
        }
    }
}