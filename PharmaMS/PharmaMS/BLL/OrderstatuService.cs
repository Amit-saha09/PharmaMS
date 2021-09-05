using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderstatuService
    {
        public static void AddOrderstatu(OrderstatuModel model)
        {
            var data = AutoMapper.Mapper.Map<OrderstatuModel, Orderstatu>(model);
            OrderstatuRepo.AddOrderstatu(data);
        }
        public static OrderstatuModel GetOrderstatu(int id)
        {
            var data = OrderstatuRepo.GetOrderstatu(id);
            var or = AutoMapper.Mapper.Map<Orderstatu, OrderstatuModel>(data);
            return or;
        }
        public static List<OrderstatuModel> GetAllOrderstatu()
        {
            var data = OrderstatuRepo.GetAllOrderstatus();
            var or = AutoMapper.Mapper.Map<List<Orderstatu>, List<OrderstatuModel>>(data);
            return or;
        }
        public static void DeleteOrderstatu(int id)
        {
            var  data = OrderstatuRepo.GetOrderstatu(id);
            OrderstatuRepo.DeleteOrderstatu(data);
        }

        public static void UpdateOrderstatu(OrderstatuModel em)
        {
            var data = AutoMapper.Mapper.Map<OrderstatuModel, Orderstatu>(em);
            OrderstatuRepo.UpdateOrderstatu(data);
        }
    }
}