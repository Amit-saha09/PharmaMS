using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepo
    {
        static PharmaAssistEntities1 context;
        static CustomerRepo()
        {
            context = new PharmaAssistEntities1();
        }
        public static void AddCustomer(Customer model)
        {
            context.Customers.Add(model);
            context.SaveChanges();
        }
        public static List<Customer> GetAllCustomers()
        {
            var data = context.Customers.ToList();
            return data;
        }
        public static Customer GetCustomerById(int id)
        {
            var data = context.Customers.FirstOrDefault(e => e.id == id);
            return data;
        }

        public static List<string> GeCustomerNames()
        {
            var data = context.Customers.Select(e => e.name).ToList();
            return data;
        }
        public static void DeleteCustomer(Customer id)
        {
            context.Customers.Remove(id);
            context.SaveChanges();
        }
        public static void UpdateCustomerInfo(Customer em)
        {
            var oldData = (from a in context.Customers where a.id == em.id select a).FirstOrDefault();
            oldData.name = em.name;
            oldData.dob = em.dob;
            oldData.bloodgroup = em.bloodgroup;
            oldData.gender = em.gender;
            oldData.contact = em.contact;
            oldData.address = em.address;
           
            oldData.image = em.image;
            context.SaveChanges();
        }
    }
}
