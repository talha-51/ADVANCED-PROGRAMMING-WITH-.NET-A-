using FoodMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodMonkey.Repository
{
    public class UserRepository
    {
        static FoodMonkeyEntities db;

        static UserRepository()
        {
            db = new FoodMonkeyEntities();
        }

        public static user Get(int id)
        {
            var u = (from us in db.users
                     where us.id == id
                     select us).FirstOrDefault();
            return u;
        }

        public static user Authenticate(string email, string password)
        {
            var usr = (from us in db.users
                     where us.email == email &&
                     us.password == password
                     select us).FirstOrDefault();

            return usr;
        }

    }
}