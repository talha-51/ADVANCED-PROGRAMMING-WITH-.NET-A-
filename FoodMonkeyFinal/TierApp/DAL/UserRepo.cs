using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo : IRepository<user, int>
    {
        FoodMonkeyEntities db;
        public UserRepo(FoodMonkeyEntities db)
        {
            this.db = db;
        }

        public void Add(user e)
        {
            db.users.Add(e);
            db.SaveChanges();
        }

        public void Delete(int Id)
        {
            var s = db.users.FirstOrDefault(e => e.id == Id);
            db.users.Remove(s);
            db.SaveChanges();
        }

        public void Edit(user e)
        {
            var s = db.users.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<user> Get()
        {
            return db.users.ToList();
        }

        public user Get(int Id)
        {
            return db.users.FirstOrDefault(e => e.id == Id);
        }
    }
}