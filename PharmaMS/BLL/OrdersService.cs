using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrdersService
    {
        public static void AddOrder(OrderModel model)
        {
            var data = AutoMapper.Mapper.Map<OrderModel, Order>(model);
            OrdersRepo.AddOrders(data);
        }
        public static OrderModel GetOrder(int id)
        {
            var data = OrdersRepo.GetOrder(id);
            var or = AutoMapper.Mapper.Map<Order, OrderModel>(data);
            return or;
        }
        public static List<OrderModel> GetAllOrders()
        {
            var data = OrdersRepo.GetAllOrders();
            var or = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(data);
            return or;
        }
        public static void DeleteOrders(int id)
        {
            Order data = OrdersRepo.GetOrder(id);
            OrdersRepo.DeleteOrders(data);
        }

        public static void UpdateOrders(OrderModel em)
        {
            var data = AutoMapper.Mapper.Map<OrderModel, Order>(em);
            OrdersRepo.UpdateOrders(data);
        }
    }
}