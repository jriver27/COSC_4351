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
                if (extension!=".zip")
                {
                    FileStream stream = System.IO.File.OpenRead(Path.GetFullPath(file.FileName));

                    FileStream outFile = System.IO.File.Create(file.FileName + ".zip");
                    
                    GZipStream Compress = new GZipStream(outFile, CompressionMode.Compress);

                }
                // extract only the fielname
                var fileName = System.IO.Path.GetFileName(file.FileName);

                // store the file inside ~/App_Data/uploads folder
                var path = System.IO.Path.Combine(@"D:/COSC4351_Spring2015/TEAM4OIES/"
, fileName);
                file.SaveAs(path);
            }
            // redirect back to the index action to show the form once again
            return RedirectToAction("Index");
        }
    }
}

