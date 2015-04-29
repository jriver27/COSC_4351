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
            string[] filePaths = Directory.GetFiles(@"C:\Users\Admin\Downloads\CT Scan - Yusuf\CT Scan - Yusuf\DICOM", "*", SearchOption.AllDirectories);
            //int x=filePaths.Length;
            String value = "";
            var dcm = (DICOMObject)null;

            insertIntoPatientTable(filePaths[1]);
            insertIntoStudyTable(filePaths[1]);
            insertIntoSeriesTable(filePaths[1]);
            Console.Read();
            
             for (int x = 0; x < filePaths.Length; x++ )
             {
                 insertIntoSeriesTable(filePaths[x]);
                 //value = value + insertIntoStudyTable(filePaths[x])+"\n";
                  // value = value+ "\n "+dcm.FindFirst(TagHelper.).ToString();

             }

            
             //dcm.ToString();
            
             //var pName = dcm.FindFirst(TagHelper.SLICE_THICKNESS);
            // var xName = dcm.FindFirst(TagHelper.SERIES_DATE);

            // return xName.ToString();*/
            return value;//View();
        }

        public void insertIntoPatientTable(string filePath)
        {

            UC9DataContext dbContext = new UC9DataContext();

            var dcm = DICOMObject.Read(@filePath);
            var tag = dcm.FindFirst(TagHelper.PATIENT_ID);
            Patient newPatient = new Patient();

          
            newPatient.originalID = Convert.ToInt32(tag.DData);

            tag = dcm.FindFirst(TagHelper.PATIENT_SEX);
            newPatient.sex = Convert.ToString(tag.DData);

            tag = dcm.FindFirst(TagHelper.PATIENT_AGE);
            String temp = Convert.ToString(tag.DData);
            temp = temp.Substring(0, temp.Length - 1);
            newPatient.age = Convert.ToInt32(temp);

            newPatient.entryDate = DateTime.Now;
            newPatient.surgeonID = 1;
            newPatient.endograft_id = 2;

            dbContext.Patients.InsertOnSubmit(newPatient);
            dbContext.SubmitChanges();

        }


        public void insertIntoStudyTable(string filePath)
        {
            UC9DataContext dbContext = new UC9DataContext();
            var dcm = DICOMObject.Read(@filePath);
            var tag = dcm.FindFirst(TagHelper.STUDY_ID);
            Study newStudy = new Study();

            newStudy.originalID = Convert.ToInt16(tag.DData);

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

            newStudy.patient_id = 3;

            dbContext.Studies.InsertOnSubmit(newStudy);
            dbContext.SubmitChanges();

        }
        public void insertIntoSeriesTable(string filePath)
        {
            UC9DataContext dbContext = new UC9DataContext();
            var dcm = DICOMObject.Read(@filePath);
            var tag = dcm.FindFirst(TagHelper.SERIES_NUMBER);
            Series newSeries = new Series();

            newSeries.originalSeriesID = Convert.ToInt16(tag.DData);

            tag = dcm.FindFirst(TagHelper.SERIES_DESCRIPTION);
            newSeries.description = Convert.ToString(tag.DData);

            tag = dcm.FindFirst(TagHelper.SERIES_DATE);
            newSeries.entryDate = Convert.ToDateTime(Convert.ToString(tag.DData));

            tag = dcm.FindFirst(TagHelper.STUDY_ID);
            newSeries.study_id = 1;//Convert.ToInt32(tag.DData);

            dbContext.Series.InsertOnSubmit(newSeries);
            dbContext.SubmitChanges();
        }
    }
}