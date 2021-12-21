using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class orderRepo : IRepository<order, int>
    {
        FoodMonkeyEntities db;
        public orderRepo(FoodMonkeyEntities db)
        {
            this.db = db;
        }

        public void Add(order e)
        {
            db.orders.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.orders.FirstOrDefault(e => e.order_id == id);
            db.orders.Remove(s);
            db.SaveChanges();
        }

        public void Edit(order e)
        {
            var s = db.orders.FirstOrDefault(en => en.order_id == e.order_id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<order> Get()
        {
            return db.orders.ToList();
        }

        public order Get(int id)
        {
            return db.orders.FirstOrDefault(e => e.order_id == id);
        }
    }
}
