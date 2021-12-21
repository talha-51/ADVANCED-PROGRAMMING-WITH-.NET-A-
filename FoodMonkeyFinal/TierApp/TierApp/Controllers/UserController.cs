using BLL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TierApp.Controllers
{
    [EnableCors("*","*","*")]
    public class UserController : ApiController
    {
        [Route("api/admin/viewAllUser")]
        [HttpGet]
        public List<UserModel> GetAll()
        {
            return UserService.Get();
        }
        [Route("api/admin/addAdmin")]
        [HttpPost]
        public void Add(UserModel s)
        {
            UserService.Add(s);
        }
    }
}
