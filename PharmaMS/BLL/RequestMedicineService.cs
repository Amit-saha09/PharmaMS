using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RequestMedicineService
    {
        public static List<RequestMedicineModel> GetAllRequestMedicine()
        {
            var data = RequestMedicineRepo.GetAllRequestMedicine();
            var med = AutoMapper.Mapper.Map<List<RequestMedicine>, List<RequestMedicineModel>>(data);
            return med;
        }

        public static RequestMedicineModel GetRequestMedicinebyID(int id)
        {
            var data = RequestMedicineRepo.GetRequestMedicineByID(id);
            var med = AutoMapper.Mapper.Map<RequestMedicine, RequestMedicineModel>(data);
            return med;
        }

        public static List<RequestMedicineModel> GetRequestMedicineByName(string id)
        {
            var data = RequestMedicineRepo.GetRequestMedicineByName(id);
            var med = AutoMapper.Mapper.Map<List<RequestMedicine>, List<RequestMedicineModel>>(data);
            return med;
        }

        public static void AddRequestMedicine(RequestMedicineModel med)
        {
            var data = AutoMapper.Mapper.Map<RequestMedicineModel, RequestMedicine>(med);
            RequestMedicineRepo.AddRequestMedicine(data);
        }

        public static void DeleteRequestMedicine(int id)
        {
            RequestMedicine data = RequestMedicineRepo.GetRequestMedicineByID(id);
            RequestMedicineRepo.DeleteRequestMedicine(data);
        }

        public static void UpdateRequestMedicineInfo(RequestMedicineModel med)
        {
            var data = AutoMapper.Mapper.Map<RequestMedicineModel, RequestMedicine>(med);
            RequestMedicineRepo.UpdateRequestMedicineInfo(data);
        }
    }
}
