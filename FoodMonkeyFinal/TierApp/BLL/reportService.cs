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
    public class reportService
    {
        public static List<reportModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<report, reportModel>();
            });
            var mapper = new Mapper(config);
            //var da = DataAccessFactory.UserDataAcees();
            var data = mapper.Map<List<reportModel>>(DataAccessFactory.reportDataAccess().Get());
            return data;
        }
        public static void Add(reportModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<reportModel, order>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<report>(s);
            DataAccessFactory.reportDataAccess().Add(data);
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
