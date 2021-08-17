using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CartstatuRepo
    {
        static PharmaAssistEntities1 context;
        static CartstatuRepo()
        {
            context = new PharmaAssistEntities1();
        }
        public static void AddCartstatu(Cartstatu model)
        {
            context.Cartstatus.Add(model);
            context.SaveChanges();
        }
        public static List<Cartstatu> GetAllCartstatus()
        {
            var data = context.Cartstatus.ToList();
            return data;
        }
        public static Cartstatu GetCartstatu(int id)
        {
            var data = context.Cartstatus.FirstOrDefault(e => e.id == id);
            return data;
        }
        public static void DeleteCartstatu(Cartstatu id)
        {
            context.Cartstatus.Remove(id);
            context.SaveChanges();
        }
    }
}