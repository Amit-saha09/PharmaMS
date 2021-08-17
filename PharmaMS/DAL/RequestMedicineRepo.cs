using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RequestMedicineRepo
    {

        static PharmaAssistEntities1 context;
        static RequestMedicineRepo()
        {
            context = new PharmaAssistEntities1();
        }

        public static List<RequestMedicine> GetAllRequestMedicine()
        {
            return context.RequestMedicines.ToList();
        }

        public static RequestMedicine GetRequestMedicineByID(int id)
        {
            var data = context.RequestMedicines.FirstOrDefault(e => e.id == id);
            return data;
        }

        public static List<RequestMedicine> GetRequestMedicineByName(string id)
        {
            var data = context.Set<RequestMedicine>().Where(x => x.name.ToLower().Contains(id.ToLower())).ToList();
            return data;
        }

        public static void AddRequestMedicine(RequestMedicine med)
        {
            context.RequestMedicines.Add(med);
            context.SaveChanges();
        }

        public static void DeleteRequestMedicine(RequestMedicine id)
        {
            context.RequestMedicines.Remove(id);
            context.SaveChanges();
        }

        public static void UpdateRequestMedicineInfo(RequestMedicine med)
        {
            var oldData = (from a in context.RequestMedicines where a.id == med.id select a).FirstOrDefault();
            oldData.name = med.name;
            oldData.quantity = med.quantity;
            oldData.medtype_id = med.medtype_id;
            oldData.customer_id = med.customer_id;
            oldData.requeststatus_id = med.requeststatus_id;
          
            context.SaveChanges();
        }

    }
}
