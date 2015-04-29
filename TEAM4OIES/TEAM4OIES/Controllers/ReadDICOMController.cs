using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using EvilDICOM.Core;
using EvilDICOM.Core.Helpers;

namespace TEAM4OIES.Controllers
{
    public class ReadDICOMController : Controller
    {
        //
        // GET: /ReadDICOM/

        public String Index()
        {
            //getting list of all the files.
            string[] filePaths = Directory.GetFiles(@"C:\Users\Admin\Downloads\CT Scan - Yusuf\CT Scan - Yusuf\DICOM","*",SearchOption.AllDirectories);
            //int x=filePaths.Length;
            String value = "";
            var dcm = (DICOMObject)null;

           insertIntoStudyTable(filePaths[1]);
            Console.Read();
           
            for (int x = 0; x < filePaths.Length; x++ )
            {
                //value = value + insertIntoStudyTable(filePaths[x])+"\n";
                dcm = DICOMObject.Read(@filePaths[x]);
               // value = value+ "\n "+dcm.FindFirst(TagHelper.).ToString();

            }

            
            //dcm.ToString();
            
            //var pName = dcm.FindFirst(TagHelper.SLICE_THICKNESS);
           // var xName = dcm.FindFirst(TagHelper.SERIES_DATE);

           // return xName.ToString();*/
            return value;//View();
        }
        public void insertIntoStudyTable(string filePath)
        {
             var dcm = DICOMObject.Read(@filePath);
             var tag = dcm.FindFirst(TagHelper.STUDY_ID) ;
             Study newStudy = new Study();
            
            newStudy.originalID= Convert.ToInt16(tag.DData);

            tag = dcm.FindFirst(TagHelper.STUDY_DESCRIPTION);
            newStudy.description = Convert.ToString(tag.DData);
            
            tag = dcm.FindFirst(TagHelper.MODALITY);
            newStudy.modality = Convert.ToString(tag.DData);
            
            tag = dcm.FindFirst(TagHelper.STUDY_DATE);
            newStudy.date = Convert.ToDateTime(Convert.ToString(tag.DData));

            tag = dcm.FindFirst(TagHelper.STUDY_ARRIVAL_TIME);
            newStudy.time = 000000;

            tag = dcm.FindFirst(TagHelper.REFERRING_PHYSICIAN_NAME);
            newStudy.referringPhysician = Convert.ToString(tag.DData);

            tag = dcm.FindFirst(TagHelper.ADDITIONAL_PATIENT_HISTORY);
            newStudy.additionalPatientHistory = Convert.ToString(tag.DData);

            newStudy.patient_id = 19;


            
        }

    }
}
