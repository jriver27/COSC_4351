using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.Diagnostics;
using TEAM4OIES.DataSet1TableAdapters;


namespace TEAM4OIES.Controllers
{
    public class SurgeonController : Controller
    {
        //
        // GET: /Surgeon////

        public ActionResult Index()
        {
            return View();
        }


        // This action handles the form POST and the upload
        //[HttpPost]
        //public ActionResult Index(HttpPostedFileBase file)
        //{
            //// Verify that the user selected a file
            //if (file != null && file.ContentLength > 0)
            //{
            //    // extract only the fielname
            //    var fileName = System.IO.Path.GetFileName(file.FileName);
            //    // store the file inside ~/App_Data/uploads folder
            //    var path = System.IO.Path.Combine(Server.MapPath("~/zip/"), fileName);
            //    file.SaveAs(path);
            //}
            //// redirect back to the index action to show the form once again
            //return RedirectToAction("Surgeon");
        //}

        private void AddPatient()
        {
         // This function is only being called to add a test patient.   
            DataSet1TableAdapters.PatientTableAdapter patientTableAdapter = new PatientTableAdapter();
            patientTableAdapter.InsertQuery(12345, 9876, "Female", new DateTime(2000,1,1), new DateTime(2015,1,1), 1);
        }

        public ActionResult SurgeonDataAnalysisInputForm()
        {
            return View();
        }
    }
}
