using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BEL;
using System.Web.Http.Cors;

namespace TierApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ReportController : ApiController
    {
        [Route("api/admin/reports")]
        [HttpGet]
        public List<reportModel> GetAll()
        {
            return reportService.Get();
        }
    }
}
