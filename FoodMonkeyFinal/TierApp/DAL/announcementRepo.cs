using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class announcementRepo : IRepository<announcement, int>
    {
        FoodMonkeyEntities db;
        public announcementRepo(FoodMonkeyEntities db)
        {
            this.db = db;
        }

        public void Add(announcement e)
        {
            db.announcements.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.announcements.FirstOrDefault(e => e.ann_id == id);
            db.announcements.Remove(s);
            db.SaveChanges();
        }

        public void Edit(announcement e)
        {
            var s = db.announcements.FirstOrDefault(en => en.ann_id == e.ann_id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<announcement> Get()
        {
            return db.announcements.ToList();
        }

        public announcement Get(int id)
        {
            return db.announcements.FirstOrDefault(e => e.ann_id == id);
        }
    }
}
