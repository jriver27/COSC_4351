using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEAM4OIES.Controllers
{
    public class AuditController : Controller
    {
        //
        // GET: /Audit/

        public ActionResult Index()
        {

            TEAM4OIES.Models.AuditService audit = new TEAM4OIES.Models.AuditService();
            audit.addtoAudit(4, "Paul", "audit", "cookie", "full");
            return View();
        }

    }
}
