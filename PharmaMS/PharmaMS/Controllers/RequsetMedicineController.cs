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
        [Route("{id}")]
        [HttpGet]
        public List<RequestMedicineModel> GetAllRequestMedicine(int id)
        {
            return RequestMedicineService.GetAllRequestMedicine(id);
        }

        [Route("admin")]
        [HttpGet]
        public List<RequestMedicineModel> GetAllAdminRequestMedicine()
        {
            return RequestMedicineService.GetAllAdminRequestMedicine();
        }

        [Route("manager")]
        [HttpGet]
        public List<RequestMedicineModel> GetAllManagerRequestMedicine()
        {
            return RequestMedicineService.GetAllManagerRequestMedicine();
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
