using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MedicineService
    {
        public static List<MedicineModel> GetAllMedicine()
        {
            var data = MedicineRepo.GetAllMedicine();
            var med = AutoMapper.Mapper.Map<List<Medicine>, List<MedicineModel>>(data);
            return med;
        }

        public static MedicineModel GetMedicinebyID(int id)
        {
            var data = MedicineRepo.GetMedicineByID(id);
            var med = AutoMapper.Mapper.Map<Medicine, MedicineModel>(data);
            return med;
        }

        public static List<MedicineModel> GetMedicineByName(string id)
        {
            var data = MedicineRepo.GetMedicineByName(id);
            var med = AutoMapper.Mapper.Map<List<Medicine>, List<MedicineModel>>(data);
            return med;
        }

        public static void AddMedicine(MedicineModel med)
        {
            var data = AutoMapper.Mapper.Map<MedicineModel, Medicine>(med);
            MedicineRepo.AddMedicine(data);
        }

        public static void DeleteMedicine(int id)
        {
            Medicine data = MedicineRepo.GetMedicineByID(id);
            MedicineRepo.DeleteMedicine(data);
        }

        public static void UpdateMedicineInfo(MedicineModel med)
        {
            var data = AutoMapper.Mapper.Map<MedicineModel, Medicine>(med);
            MedicineRepo.UpdateMedicineInfo(data);
        }
    }
}
