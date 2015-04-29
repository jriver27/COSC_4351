using System;
using System.Collections.Generic;
using System.Data.Common;
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
using TEAM4OIES.Models;
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

        //Name of Code Artifact:SurgeonDataAnalysisInputForm
        //Programmer's Name:Javier Rivera
        //Date it was coded: 04/28/2015
        //Date Approved: 04/29/2015  
        //SQA Approver: Paul Miller
        public ActionResult SurgeonDataAnalysisInputForm()
        {
            return View();
        }

        //Name of Code Artifact:Patient
        //Programmer's Name:Javier Rivera
        //Date it was coded: 04/29/2015
        //Date Approved: 04/29/2015  
        //SQA Approver: Paul Miller
        public ActionResult Patient()
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

                    // store the file inside D:/COSC4351_Spring2015/TEAM4OIES/ folder
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
         * SQA: Linh Tong
         * Date: 04/29/2015  */

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

        //Name of Code Artifact:GetCTScans
        //Programmer's Name:Javier Rivera, Paul Miller
        //Date it was coded: 04/28/2014
        //Date Approved: 04/29/2015  
        //SQA Approver: Paul Miller
        public ActionResult GetCtScans(String patientp)
        {
            DataAnalysisModel model = new DataAnalysisModel();
            model.PatienId = patientp;
            
            string accessType = "Retrieving CTScans for patient: " + patientp;
            new AuditService().AddtoAudit(1, "JavierRivera", Misc.TableNames.Study, "Series", accessType);

            model.CtScansEnumerable = new DataAnalysisModel().GetCtScans(Int32.Parse(patientp));

            accessType = "Retrieving patient " + patientp;
            new AuditService().AddtoAudit(1, "JavierRivera", Misc.TableNames.Patient, "Patient", accessType);

            Patient patient = new DataAnalysisModel().GetPatientStats(Int32.Parse(patientp));
            model.PatientNumber = patient.originalID.ToString();
            //model.Age = new DataAnalysisModel().GetAge(patient.age,patient.entryDate).ToString();
            model.DateOfSurgery = patient.entryDate;
            model.GraftManufacturer = patient.Endograft.Brand.ToString();

            return View("SurgeonDataAnalysisInputForm", model);
        }

        //Name of Code Artifact:GetPatientInfo
        //Programmer's Name:Javier Rivera
        //Date it was coded: 04/28/2014
        //Date Approved: 04/29/2015  
        //SQA Approver: Paul Miller
        [HttpPost]
        public ActionResult PatientInfoActionResult(FormCollection form)
        {
            string accessType = "Retrieving patient " + Request.Form["patientId"];
            new AuditService().AddtoAudit(1, "JavierRivera", Misc.TableNames.Patient, "Patient", accessType);

            Patient patient = new DataAnalysisModel().GetPatientStats(Int32.Parse(Request.Form["patientId"]));
            PatientModel patientModel = new PatientModel();

            patientModel.SurgeryDate = patient.entryDate;
            patientModel.Age = patient.age;
            patientModel.PatienId = patient.patient_id;
            patientModel.Sex = patient.sex;
            patientModel.StudiesId = patient.Studies;

            return View(patientModel);
        }
    }
}