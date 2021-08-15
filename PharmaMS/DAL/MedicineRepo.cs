using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MedicineRepo
    {
        static PharmaAssistEntities1 context;
        static MedicineRepo()
        {
            context = new PharmaAssistEntities1();
        }

        public static List<Medicine> GetAllMedicine()
        {
            return context.Medicines.ToList();
        }

        public static Medicine GetMedicineByID(int id)
        {
            var data = context.Medicines.FirstOrDefault(e => e.id == id);
            return data;
        }

        public static List<Medicine> GetMedicineByName(string id)
        {
            var data = context.Set<Medicine>().Where(x => x.name.ToLower().Contains(id.ToLower())).ToList();
            return data;
        }

        public static void AddMedicine(Medicine med)
        {
            context.Medicines.Add(med);
            context.SaveChanges();
        }

        public static void DeleteMedicine(Medicine id)
        {
            context.Medicines.Remove(id);
            context.SaveChanges();
        }

        public static void UpdateMedicineInfo(Medicine med)
        {
            var oldData = (from a in context.Medicines where a.id == med.id select a).FirstOrDefault();
            oldData.name = med.name;
            oldData.quantity = med.quantity;
            oldData.price = med.price;
            oldData.company = med.company;
            oldData.description = med.description;
            oldData.medtype_id = med.medtype_id;
            oldData.medstatus_id = med.medstatus_id;
            context.SaveChanges();
        }
    }
}
