using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeRepo
    {
        static PharmaAssistEntities1 context;
        static EmployeeRepo()
        {
            context = new PharmaAssistEntities1();
        }

        public static List<Employee> GetAllEmployee()
        {
            return context.Employees.ToList();
        }

        public static Employee GetEmployeebyID(int id)
        {
            var data = context.Employees.FirstOrDefault(e => e.id == id);
            return data;
        }

        public static List<Employee> GetEmployeeByName(string id)
        {
            var data = context.Set<Employee>().Where(x => x.name.ToLower().Contains(id.ToLower())).ToList();
            return data;
        }

        public static void AddEmployee(Employee em)
        {
            //context.Employees.Add(em);
            //context.SaveChanges();

            using (var p2 = new PharmaAssistEntities1())
            {
                int e = p2.Database.ExecuteSqlCommand("INSERT INTO Employees VALUES ('"+em.name+ "', '" + em.dob + "', '" + em.bloodgroup + "', '" + em.gender + "', '" + em.contact + "', '" + em.address + "', '" + em.salary + "', '" + em.image + "', '" + em.login_id + "');");
            }
        }

        public static void DeleteEmployee(Employee id)
        {
            context.Employees.Remove(id);
            context.SaveChanges();
        }

        public static void UpdateEmployeeInfo(Employee em)
        {
            var oldData = (from a in context.Employees where a.id == em.id select a).FirstOrDefault();
            oldData.name = em.name;
            oldData.dob = em.dob;
            oldData.bloodgroup = em.bloodgroup;
            oldData.gender = em.gender;
            oldData.contact = em.contact;
            oldData.address = em.address;
            oldData.salary = em.salary;
            oldData.image = em.image;
            context.SaveChanges();
        }
    }
}
