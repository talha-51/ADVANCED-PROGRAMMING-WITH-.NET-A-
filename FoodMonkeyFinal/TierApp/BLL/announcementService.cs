using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class announcementService
    {
        public static List<announcementModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<announcement, announcementModel>();
            });
            var mapper = new Mapper(config);
            //var da = DataAccessFactory.UserDataAcees();
            var data = mapper.Map<List<announcementModel>>(DataAccessFactory.announcementDataAccess().Get());
            return data;
        }
        public static void Add(announcementModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<announcementModel, announcement>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<announcement>(s);
            DataAccessFactory.announcementDataAccess().Add(data);
            //DataAccessFactory.StudentDataAcees().Add(data);
        }

        public static void Delete(int s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<announcementModel, announcement>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<int>(s);
            DataAccessFactory.announcementDataAccess().Delete(data);
            //DataAccessFactory.StudentDataAcees().Add(data);
        }
    }
}