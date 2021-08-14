﻿using AutoMapper;
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
        }
    }
}
