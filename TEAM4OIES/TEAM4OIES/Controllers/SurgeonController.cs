using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.Diagnostics;

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
        public void RunDiccom()
        {
            System.Diagnostics.ProcessStartInfo processInfo;
            System.Diagnostics.Process process;


            //string pathname = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string pathname = @"C:\Users\Daniel\Desktop\GITHUB\COSC_4351\TEAM4OIES\TEAM4OIES\bin";
            pathname += @"\DICCOMcleaner\DicomCleaner.bat";

           // Process.Start(pathname);
            processInfo = new System.Diagnostics.ProcessStartInfo(pathname);

           // processInfo.RedirectStandardError = true;
            //processInfo.RedirectStandardOutput = true;
            //processInfo.UseShellExecute = false;
           // processInfo.CreateNoWindow = true;
           // processInfo.UseShellExecute = false;

            process = Process.Start(processInfo);
            //process.WaitForExit();


           

           // process = System.Diagnostics.Process.Start(processInfo);
           // process.WaitForExit();




        }
    }
}
