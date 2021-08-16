using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerService
    {
        public static List<CustomerModel> GetAllCustomer()
        {
            var data = CustomerRepo.GetAllCustomers();
            var em = AutoMapper.Mapper.Map<List<Customer>, List<CustomerModel>>(data);
            return em;
        }

        public static CustomerModel GetCustomerById(int id)
        {
            var data = CustomerRepo.GetCustomerById(id);
            var em = AutoMapper.Mapper.Map<Customer, CustomerModel>(data);
            return em;
        }

        public static List<string> GetCustomerNames()
        {
            var data = CustomerRepo.GeCustomerNames();
            return data;
        }

        public static void AddCustomer(CustomerModel em)
        {
            var data = AutoMapper.Mapper.Map<CustomerModel, Customer>(em);
            CustomerRepo.AddCustomer(data);
        }

        public static void DeleteCustomer(int id)
        {
            Customer data = CustomerRepo.GetCustomerById(id);
            CustomerRepo.DeleteCustomer(data);
        }

        public static void UpdateCustomer(CustomerModel em)
        {
            var data = AutoMapper.Mapper.Map<CustomerModel, Customer>(em);
            CustomerRepo.UpdateCustomerInfo(data);
        }
    }
}
