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

        [Route("name")]
        [HttpGet]
        public List<string> GetMedicineByName()
        {
            return MedicineService.GetMedicineByName();
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
    }
}
