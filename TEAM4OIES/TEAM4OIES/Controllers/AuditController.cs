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

            ViewData["audits"] = audit.GetAuditList(audit.GetTable());
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
            
            ViewData["audits"] = audit.GetAuditList(audit.GetTableByDate(date));
            return View();

        }
       

    }
}
