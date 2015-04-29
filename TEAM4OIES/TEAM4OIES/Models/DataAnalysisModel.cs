using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using TEAM4OIES;

namespace TEAM4OIES.Models
{
    public class DataAnalysisModel
    {
        public int PatienId;
        
        public string PatientNumber { get; set; }
        public DateTime PatientDOB { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }

        public IEnumerable CtScansEnumerable { get; set; }

        public DateTime DateOfSurgery { set; get; }
        public string GraftManufacturer { set; get; }

        public DateTime CtScan { get; set; }
        public int CTid { get; set; }
        public int Delay { get; set; }

        public IEnumerable CtSeriesEnumerable { get; set; }

        public int NumOfSlices { get; set; }
        public int Thickness { get; set; }
        public int PixelSize{ get; set; }
        
        public Patient GetPatientStats(int patientIDp)
        {
            Patient patientFound=new Patient();  
            UC9DataContext db = new UC9DataContext();
            var correctPatient = db.Patients.Single(u => u.patient_id == patientIDp);
           
           
            return correctPatient;
          //Javier, this function returns the patient with the matching id
        }
        public int GetAge(int ageinDB, DateTime dateofSurg)
        {
            return ageinDB+ (DateTime.Now.Year-dateofSurg.Year);
        }
        public List<Study> GetCtScans(int patientIDp)
        {
            
            UC9DataContext db = new UC9DataContext();
            var allScans = from scan in db.Studies
                           where scan.patient_id == patientIDp
                           select scan;
            return allScans.ToList();
            //Jaiver, this function returns all the ct scans under a patient
        }
        public List<Series> GetSeries(int studyiD)
        {
            UC9DataContext db = new UC9DataContext();
            var allScans = from scan in db.Series
                           where scan.study_id == studyiD
                           select scan;
            return allScans.ToList();
            //Jaiver, this function returns all the series under a study
            
        }
        public List<Slice> GetSlices(int seriesID)
        {
            UC9DataContext db = new UC9DataContext();
            var allScans = from scan in db.Slices
                           where scan.series_id == seriesID
                           select scan;
            return allScans.ToList();
            //Jaiver, this function returns all the slices under a series
            //Total # of slides=size of this list    
        }
        public double GetRoIend(double thickness, int illiacbif)
        {
             return Math.Round(10/thickness+illiacbif);
            
            //returns ROI end
        }
        public double TotSlidesRoi(int ROIbegin, int ROIend, double thickness)
        {
            return Math.Round((ROIend - ROIbegin) * thickness);
            //return totalSlides
        }
        public double ROIlen(double totSlides, double thickness)
        {
            return totSlides / thickness;
            //returns ROI length(cm)
        }
        public int getDelay(DateTime surgery, DateTime scan)
        {
            return (surgery - scan).Days;
        }

        //Everything done except for getdelay
   } 
}