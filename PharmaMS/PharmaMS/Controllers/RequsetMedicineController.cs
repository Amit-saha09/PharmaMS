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



    [RoutePrefix("api/requestmedicines")]
    public class RequestMedicineController : ApiController
    {
        [Route("")]
        [HttpGet]
        public List<RequestMedicineModel> GetAllRequestMedicine()
        {
            return RequestMedicineService.GetAllRequestMedicine();
        }



        [Route("{id}")]
        [HttpGet]
        public RequestMedicineModel GetRequestMedicineByID(int id)
        {
            return RequestMedicineService.GetRequestMedicinebyID(id);
        }



        [Route("name/{id}")]
        [HttpGet]
        public List<RequestMedicineModel> GetRequestMedicineByName([FromUri] string id)
        {
            return RequestMedicineService.GetRequestMedicineByName(id);
        }



        [Route("add")]
        [HttpPost]
        public void AddProduct(RequestMedicineModel med)
        {
            RequestMedicineService.AddRequestMedicine(med);
        }



        [Route("delete/{id}")]
        public void DeleteRequestMedicine([FromUri] int id)
        {
            RequestMedicineService.DeleteRequestMedicine(id);
        }



        [Route("update/{id}")]
        public void PutRequestMedicineInfo([FromBody] RequestMedicineModel n, [FromUri] int id)
        {
            RequestMedicineModel medInfo = new RequestMedicineModel();
            medInfo = RequestMedicineService.GetRequestMedicinebyID(id);
            medInfo.name = n.name;
            medInfo.quantity = n.quantity;
            medInfo.customer_id = n.customer_id;
            medInfo.medtype_id = n.medtype_id;
            medInfo.requeststatus_id = n.requeststatus_id;




            RequestMedicineService.UpdateRequestMedicineInfo(medInfo);
        }



        [Route("update/stockout/{id}")]
        public void PutRequestMedicineStockout([FromUri] int id)
        {
            RequestMedicineModel medInfo = new RequestMedicineModel();
            medInfo = RequestMedicineService.GetRequestMedicinebyID(id);
            medInfo.requeststatus_id = 2;



            RequestMedicineService.UpdateRequestMedicineInfo(medInfo);
        }




    }
}
