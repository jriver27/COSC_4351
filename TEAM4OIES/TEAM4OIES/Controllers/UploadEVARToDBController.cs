/*Name of Artifact: UC7
    Programmers Name: Jainesh Mehta
    Date of Code: 04/27/2015
    Date of Approval:
    SQA Name:-  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEAM4OIES.Models;
using EvilDICOM.Core;
using EvilDICOM.Core.Helpers;
namespace TEAM4OIES.Controllers
{
    public class UploadEVARToDBController : Controller
    {
        public ActionResult Index()
        {

            return View();

        }

        public ActionResult Submit()
        {
             var dcm = DICOMObject.Read(@"C:\Users\Admin\Downloads\CT Scan - Yusuf\CT Scan - Yusuf\DICOM\PA000000\ST000000\SE000000\IM000000");
            dcm.ToString();
            Console.Read();

            var holder = dcm.FindFirst(TagHelper.PATIENT_ID);
            UC9DataContext dbContext = new UC9DataContext();
            
           
            Endograft newEndo = new Endograft()
            {
                dateOfSurgery = Convert.ToDateTime(Convert.ToString(Request.Form["DateOfSurgery"])),
                diameter = Convert.ToSingle(Request.Form["BodyDiameter"]),
                length = Convert.ToSingle(Request.Form["BodyLength"]),
                unilateralLegDiameter = Convert.ToSingle(Request.Form["UnilateralLegDiameter"]),
                unilateralLegLength = Convert.ToSingle(Request.Form["UnilateralLegLength"]),
                controlaterLegDiameter = Convert.ToSingle(Request.Form["ContralateralLegDiameter"]),
                controlaterLegLength = Convert.ToSingle(Request.Form["ContralateralLegLength"]),
                entryPoint = 10,//Request.Form["EntryPoint"].ToString(),
                brand_id = Convert.ToInt16(Request.Form["BrandID"])
            };
            Brand newBrand = new Brand()
            {
                brand1 = Convert.ToString(Request.Form["Brand"])
            };
            String filepath = Convert.ToString(Request.Form["dcmfile"]);
            dbContext.Brands.InsertOnSubmit(newBrand);
            dbContext.SubmitChanges();
            dbContext.Endografts.InsertOnSubmit(newEndo);
            dbContext.SubmitChanges();
            return View();
        }

    }
}