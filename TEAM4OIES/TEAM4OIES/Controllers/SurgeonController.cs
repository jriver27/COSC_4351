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
using Ionic;
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

        /*
         * SurgeonDataAnalysisInputForm
         * Javier Rivera
         * 4/28/2015
         * 
         * */
        public ActionResult SurgeonDataAnalysisInputForm()
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
                if (extension != ".zip")
                {
                    UC4ZipAnonymizedPatientData(file);
                }
                else
                {
                    // extract only the fielname
                    var fileName = Path.GetFileName(file.FileName);

                    // store the file inside ~/App_Data/uploads folder
                    var path = Path.Combine(@"D:/COSC4351_Spring2015/TEAM4OIES/", fileName);
                    file.SaveAs(path);

                    //Unzip File using Ionic.Zip DLL
                    using (ZipFile zip1 = ZipFile.Read(fileName))
                    {
                        foreach (ZipEntry e in zip1)
                        {
                            e.Extract(path, ExtractExistingFileAction.OverwriteSilently);
                        }
                    }
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

