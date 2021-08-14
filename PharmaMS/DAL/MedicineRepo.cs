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

        public static List<string> GetMedicineByName()
        {
            var data = context.Medicines.Select(e => e.name).ToList();
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
    }
}
