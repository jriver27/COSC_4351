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

            
            return View("Index");
        }
        public String saveDate(FormCollection form)
        {
            String date = Request.Form["Auditdate"];
            return date;
        }
        [HttpPost]
        public ActionResult DispTable(FormCollection form)
        {
            TEAM4OIES.Models.AuditService audit = new TEAM4OIES.Models.AuditService();

            String date=saveDate(form);
            audit.AddtoAudit(1, "Auditor", "Audit", "None", "View");
            ViewData["audits"] = audit.GetAuditList(audit.GetTableByDate(date));
            return View();

        }
       

    }
}
