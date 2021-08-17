using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrdersRepo
    {
        static PharmaAssistEntities1 context;
        static OrdersRepo()
        {
            context = new PharmaAssistEntities1();
        }
        public static void AddOrders(Order model)
        {
            context.Orders.Add(model);
            context.SaveChanges();
        }
        public static List<Order> GetAllOrders()
        {
            var data = context.Orders.ToList();
            return data;
        }
        public static Order GetOrder(int id)
        {
            var data = context.Orders.FirstOrDefault(e => e.id == id);
            return data;
        }
        public static void DeleteOrders(Order id)
        {
            context.Orders.Remove(id);
            context.SaveChanges();
        }
        public static void UpdateOrders(Order em)
        {
            var oldData = (from a in context.Orders where a.id == em.id select a).FirstOrDefault();
            oldData.appx_del_date = em.appx_del_date;
            oldData.cart_id = em.cart_id;
            oldData.employee_id = em.employee_id;
            oldData.orderstatus_id = em.orderstatus_id;
            context.SaveChanges();
        }
    }
}