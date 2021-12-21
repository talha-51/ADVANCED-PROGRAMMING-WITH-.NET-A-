using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using BEL;

namespace BLL
{
    public class orderService
    {
        public static List<orderModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<order, orderModel>();
            });
            var mapper = new Mapper(config);
            //var da = DataAccessFactory.UserDataAcees();
            var data = mapper.Map<List<orderModel>>(DataAccessFactory.orderDataAccess().Get());
            return data;
        }
        public static void Add(orderModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<orderModel, order>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<order>(s);
            DataAccessFactory.orderDataAccess().Add(data);
            //DataAccessFactory.StudentDataAcees().Add(data);
        }

        public static void Delete(int s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<orderModel, order>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<int>(s);
            DataAccessFactory.orderDataAccess().Delete(data);
            //DataAccessFactory.StudentDataAcees().Add(data);
        }
    }
}
