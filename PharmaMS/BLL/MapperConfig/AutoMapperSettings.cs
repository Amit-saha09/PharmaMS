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
            CreateMap<CartModel, Cart>()
                .ForMember(e => e.Cartitems, d => d.Ignore())
                .ForMember(e => e.Orders, d => d.Ignore());
            CreateMap<Cart, CartModel>();
            CreateMap<Cart, CartDetail>();


            CreateMap<LoginModel, Login>();

            CreateMap<Login, LoginModel>();
            CreateMap<Login, LoginDetail>();

            /* Do Not Delete
            CreateMap<Login, UsertypeModel>();
            CreateMap<Login, UsertypeDetail>();

            CreateMap<Login, LoginaccessModel>();
            CreateMap<Login, LoginaccessDetail>();

            CreateMap<Login, RegstatuModel>();
            CreateMap<Login, RegstatuDetail>();
            */
        }
    }
}
