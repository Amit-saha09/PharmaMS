using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PharmaMS.Controllers
{
    [EnableCorsAttribute("*", "*", "*")]

    [RoutePrefix("api/medicines")]
    public class MedicineController : ApiController
    {
        [Route("")]
        [HttpGet]
        public List<MedicineModel> GetAllMedicine()
        {
            return MedicineService.GetAllMedicine();
        }

        [Route("{id}")]
        [HttpGet]
        public MedicineModel GetMedicineByID(int id)
        {
            return MedicineService.GetMedicinebyID(id);
        }

        [Route("name/{id}")]
        [HttpGet]
        public List<MedicineModel> GetMedicineByName([FromUri] string id)
        {
            return MedicineService.GetMedicineByName(id);
        }

        [Route("add")]
        [HttpPost]
        public void AddProduct(MedicineModel med)
        {
            MedicineService.AddMedicine(med);
        }

        [Route("delete/{id}")]
        public void DeleteMedicine([FromUri] int id)
        {
            MedicineService.DeleteMedicine(id);
        }

        [Route("update/{id}")]
        public void PutMedicineInfo([FromBody] MedicineModel n, [FromUri] int id)
        {
            MedicineModel medInfo = new MedicineModel();
            medInfo = MedicineService.GetMedicinebyID(id);
            medInfo.name = n.name;
            medInfo.quantity = n.quantity;
            medInfo.price = n.price;
            medInfo.company = n.company;
            medInfo.description = n.description;
            medInfo.medtype_id = n.medtype_id;

            MedicineService.UpdateMedicineInfo(medInfo);
        }

        [Route("update/stockout/{id}")]
        public void PutMedicineStockout([FromUri] int id)
        {
            MedicineModel medInfo = new MedicineModel();
            medInfo = MedicineService.GetMedicinebyID(id);
            medInfo.medstatus_id = 2;

            MedicineService.UpdateMedicineInfo(medInfo);
        }

        [Route("update/notforsale/{id}")]
        public void PutMedicineNotForSale([FromUri] int id)
        {
            MedicineModel medInfo = new MedicineModel();
            medInfo = MedicineService.GetMedicinebyID(id);
            medInfo.medstatus_id = 3;

            MedicineService.UpdateMedicineInfo(medInfo);
        }
    }
}
