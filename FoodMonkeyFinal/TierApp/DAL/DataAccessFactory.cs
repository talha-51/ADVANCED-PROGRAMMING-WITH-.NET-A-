using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static FoodMonkeyEntities db;
        static DataAccessFactory()
        {
            db = new FoodMonkeyEntities();
        }
        public static IRepository<user, int> UserDataAcees()
        {
            return new UserRepo(db);
        }
        public static IRepository<announcement, int> announcementDataAccess()
        {
            return new announcementRepo(db);
        }
        public static IRepository<order, int> orderDataAccess()
        {
            return new orderRepo(db);
        }
        public static IRepository<report, int> reportDataAccess()
        {
            return new reportRepo(db);
        }
    }
}
