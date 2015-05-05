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
        //Name of Code Artifact: saveDate
        //Programmer's Name:Paul Miller
        //Date it was coded: 04/25/2014
        //Date Approved: 04/29/2014
        //SQA Approver: Linh Tong
        public String saveDate(FormCollection form)
        {
            String date = Request.Form["Auditdate"];
            return date;
        }
        //Name of Code Artifact: dispTable
        //Programmer's Name:Paul Miller
        //Date it was coded: 04/25/2014
        //Date Approved: 04/29/2014
        //SQA Approver: Linh Tong
        [HttpPost]
        public ActionResult DispTable(FormCollection form)
        {
            String name = Session["username"].ToString();
            char charTo = Session["userID"].ToString()[0];
            int ID = (int)(charTo) - 48;
            String date=saveDate(form);
            TEAM4OIES.Models.AuditService audit = new TEAM4OIES.Models.AuditService();
            audit.AddtoAudit(ID,name,"Audit", "None", "View");
            ViewData["audits"] = audit.GetAuditList(audit.GetTableByDate(date));
            return View();
        }
       

    }
}
