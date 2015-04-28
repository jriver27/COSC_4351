using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.Diagnostics;
using System.IO.Compression;
using TEAM4OIES.DataSet1TableAdapters;
using System.IO;
using Ionic.Zip;




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

        //Name of Artifact: UC5
        //Programmers Name: Daniel Gonzalez
        //Date of Code: 04/27/2015
        //Date of Approval:
        //SQA Name:

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
                    FileStream stream = System.IO.File.OpenRead(Path.GetFullPath(file.FileName));

                    FileStream outFile = System.IO.File.Create(file.FileName + ".zip");
                    
                    GZipStream Compress = new GZipStream(outFile, CompressionMode.Compress);

                }

                // store the file inside D:/COSC4351_Spring2015/TEAM4OIES/ folder
                var path = System.IO.Path.Combine(@"D:/COSC4351_Spring2015/TEAM4OIES/", fileName);
                
                //Unzip File using Ionic.Zip DLL
                using(ZipFile zip1 = ZipFile.Read(fileName))
                {
                    foreach(ZipEntry e in zip1)
                    {
                        e.Extract(path, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
            return RedirectToAction("Index");
        }
        public ActionResult SurgeonDataAnalysisInputForm()
        {
            return View();
        }
    }
}

