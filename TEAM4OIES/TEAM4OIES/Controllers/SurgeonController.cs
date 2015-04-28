using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;

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
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                string extension = Path.GetExtension(file.FileName);
                //make sure the extension isn't a zip
                if (extension!=".zip")
                {
                    UC4ZipAnonymizedPatientData(file);
                }
                else
                {
                    // extract only the fielname
                    var fileName = System.IO.Path.GetFileName(file.FileName);

                    // store the file inside ~/App_Data/uploads folder
                    var path = System.IO.Path.Combine(@"D:/COSC4351_Spring2015/TEAM4OIES/", fileName);
                    file.SaveAs(path);
                }
            }
            // redirect back to the index action to show the form once again
            return RedirectToAction("Index");
        }
        /*
         * UC4ZipAnonymizedPatientData
         * Sarah Moore
         * 4/27/2015
         * 
         * */
        private static void UC4ZipAnonymizedPatientData(HttpPostedFileBase file)
        {
            //while the file is open
            using (FileStream stream = System.IO.File.OpenRead(Path.GetFullPath(file.FileName)))
            {
                //create the stream of the zip file name
                FileStream outFile = System.IO.File.Create(file.FileName + ".zip");
                //compress the outfile
                GZipStream Compress = new GZipStream(outFile, CompressionMode.Compress);
                //copy data from the original file to the compressed file
                stream.CopyTo(Compress);
                string endDirectory = @"D:/COSC4351_Spring2015/TEAM4OIES/";
                //save the compressed file
                using (FileStream destinationStream = System.IO.File.Create(endDirectory))
                {
                    stream.CopyTo(destinationStream);
                }
            }
        }
    }
}

