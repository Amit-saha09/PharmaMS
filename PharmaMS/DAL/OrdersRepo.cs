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

    }
}