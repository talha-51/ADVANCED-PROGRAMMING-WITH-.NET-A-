using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class reportRepo : IRepository<report, int>
    {
        FoodMonkeyEntities db;
        public reportRepo(FoodMonkeyEntities db)
        {
            this.db = db;
        }

        public void Add(report e)
        {
            db.reports.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.reports.FirstOrDefault(e => e.rep_id == id);
            db.reports.Remove(s);
            db.SaveChanges();
        }

        public void Edit(report e)
        {
            var s = db.reports.FirstOrDefault(en => en.rep_id == e.rep_id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<report> Get()
        {
            return db.reports.ToList();
        }

        public report Get(int id)
        {
            return db.reports.FirstOrDefault(e => e.rep_id == id);
        }
    }
}
