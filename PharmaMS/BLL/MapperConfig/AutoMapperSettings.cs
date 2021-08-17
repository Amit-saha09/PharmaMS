using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
           
            


            CreateMap<RequestMedicineModel, RequestMedicine>()
                    .ForMember(a => a.Customer, b => b.Ignore())
                    .ForMember(a => a.Medtype, a => a.Ignore())
                    .ForMember(a => a.Requeststatu, a => a.Ignore());



            CreateMap<LoginModel, Login>()
                .ForMember(e => e.Loginaccess, d => d.Ignore())
                .ForMember(e => e.Regstatu, d => d.Ignore())
                .ForMember(e => e.Usertype, d => d.Ignore());

            CreateMap<Login, LoginModel>();
            CreateMap<Login, LoginDetail>();
            CreateMap<LoginModel, LoginDetail>();

            /* Do Not Delete
            CreateMap<Login, UsertypeModel>();
            CreateMap<Login, UsertypeDetail>();

            CreateMap<Login, LoginaccessModel>();
            CreateMap<Login, LoginaccessDetail>();

            CreateMap<Login, RegstatuModel>();
            CreateMap<Login, RegstatuDetail>();
            */

            CreateMap<MedicineModel, Medicine>()
                .ForMember(e => e.Medtype, m => m.Ignore())
                .ForMember(e => e.Medstatu, m => m.Ignore());

            CreateMap<Medicine, MedicineModel>();
            CreateMap<Medicine, MedicineDetail>();
            CreateMap<MedstatuModel, MedicineDetail>();

            //CreateMap<EmployeeModel, Employee>().ForMember(e => e.login_id, m => m.Ignore());
            CreateMap<EmployeeModel, Employee>();
            CreateMap<Employee, EmployeeModel>();
            CreateMap<Employee, EmployeeDetail>();
            CreateMap<EmployeeDetail, Employee>();
            CreateMap<EmployeeModel, EmployeeDetail>();
            CreateMap<EmployeeDetail, EmployeeModel>();

            //cart status
            CreateMap<CartstatuModel, Cartstatu>();//ForMember(e => e.Carts, sm =>sm.Ignore());

            CreateMap<Cartstatu, CartstatuDetail>();
            CreateMap<Cartstatu, CartstatuModel>();
            CreateMap<CartstatuModel, CartstatuDetail>();

            //cart
            CreateMap<Cart, CartModel>();//.ForMember(e => e.customer_id, sm => sm.Ignore()).ForMember(e => e.cartstatus_id, sm => sm.Ignore());
            CreateMap<CartModel, Cart>().ForMember(e => e.Customer, sm => sm.Ignore()).ForMember(e => e.Cartstatu, sm => sm.Ignore());
            // .ForMember(e => e.customer_id, sm => sm.Ignore());//.ForMember(e => e.cartstatus_id, sm => sm.Ignore());


            CreateMap<CartModel, CartDetail>();
            CreateMap<Cart, CartDetail>();
            // CreateMap<Cart, CartModel>();
            // CreateMap<CartModel, Cart>();

            //Order status
            CreateMap<OrderstatuModel, Orderstatu>();

            CreateMap<Orderstatu, OrderstatuDetail>();
            CreateMap<Orderstatu, OrderstatuModel>();
            CreateMap<OrderstatuModel, OrderstatuDetail>();
            //Order
            CreateMap<OrderModel, Order>();
            CreateMap<Order, OrderModel>();
        }
    }
}
