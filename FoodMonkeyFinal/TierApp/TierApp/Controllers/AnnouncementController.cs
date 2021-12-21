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
    [EnableCors("*", "*", "*")]
    public class AnnouncementController : ApiController
    {
        [Route("api/admin/announcement")]
        [HttpGet]
        public List<announcementModel> GetAll()
        {
            return announcementService.Get();
        }

        [Route("api/admin/addAnnouncement")]
        [HttpPost]
        public void Add(announcementModel s)
        {
            announcementService.Add(s);
        }

        /*[Route("api/admin/deleteAnnouncement/{id}")]
        [HttpGet]
        public List<int> Delete(id)
        {
            return announcementService.Delete(id);
        }*/
    }
}
