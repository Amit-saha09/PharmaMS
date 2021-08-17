using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CartstatuService
    {/*
        static CartstatuService()
        {

            AutoMapper.Mapper.Initialize(config => config.AddProfile<MapperConfig.AutoMapperSettings>());
        }*/
        public static void AddCartstatu(CartstatuModel model)
        {
            var data = AutoMapper.Mapper.Map<CartstatuModel, Cartstatu>(model);
            CartstatuRepo.AddCartstatu(data);
        }

        public static CartstatuModel GetCartstatu(int id)
        {
            var data = CartstatuRepo.GetCartstatu(id);
            var ca = AutoMapper.Mapper.Map<Cartstatu, CartstatuModel>(data);
            return ca;
        }
        public static List<CartstatuModel> GetAllCartstatus()
        {
            var data = CartstatuRepo.GetAllCartstatus();
            var ca = AutoMapper.Mapper.Map<List<Cartstatu>, List<CartstatuModel>>(data);
            return ca;
        }
        public static void DeleteCartstatu(int id)
        {
            Cartstatu data = CartstatuRepo.GetCartstatu(id);
            CartstatuRepo.DeleteCartstatu(data);
        }
        public static void UpdateCartstatu(CartstatuModel em)
        {
            var data = AutoMapper.Mapper.Map<CartstatuModel, Cartstatu>(em);
            CartstatuRepo.UpdateCartstatu(data);
        }
    }
}