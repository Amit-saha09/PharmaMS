using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeService
    {
        public static List<EmployeeModel> GetAllEmployee()
        {
            var data = EmployeeRepo.GetAllEmployee();
            var em = AutoMapper.Mapper.Map<List<Employee>, List<EmployeeModel>>(data);
            return em;
        }

        public static EmployeeModel GetEmployeebyID(int id)
        {
            var data = EmployeeRepo.GetEmployeebyID(id);
            var em = AutoMapper.Mapper.Map<Employee, EmployeeModel>(data);
            return em;
        }

        public static EmployeeModel GetEmployeebyloginID(int id)
        {
            var data = EmployeeRepo.GetEmployeebyloginID(id);
            var em = AutoMapper.Mapper.Map<Employee, EmployeeModel>(data);
            return em;
        }

        public static List<EmployeeModel> GetEmployeeByName(string id)
        {
            var data = EmployeeRepo.GetEmployeeByName(id);
            var em = AutoMapper.Mapper.Map<List<Employee>, List<EmployeeModel>>(data);
            return em;
        }

        public static void AddEmployee(EmployeeModel em)
        {
            var data = AutoMapper.Mapper.Map<EmployeeModel, Employee>(em);
            EmployeeRepo.AddEmployee(data);
        }

        public static void DeleteEmployee(int id)
        {
            Employee data = EmployeeRepo.GetEmployeebyID(id);
            EmployeeRepo.DeleteEmployee(data);
        }

        public static void UpdateEmployeeInfo(EmployeeModel em)
        {
            var data = AutoMapper.Mapper.Map<EmployeeModel, Employee>(em);
            EmployeeRepo.UpdateEmployeeInfo(data);
        }
    }
}
