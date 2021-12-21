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
    public class UserService
    {
        public static List<UserModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<user, UserModel>();
            });
            var mapper = new Mapper(config);
            //var da = DataAccessFactory.UserDataAcees();
            var data = mapper.Map<List<UserModel>>(DataAccessFactory.UserDataAcees().Get());
            return data;
        }
        public static List<string> GetNames()
        {
            //var data = DataAccessFactory.StudentDataAcees().Get().Select(e => e.Name).ToList();
            var data = DataAccessFactory.UserDataAcees().Get().Select(e => e.name).ToList();
            return data;
        }
        public static void Add(UserModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserModel, user>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<user>(s);
            DataAccessFactory.UserDataAcees().Add(data);
            //DataAccessFactory.StudentDataAcees().Add(data);
        }
    }
}
