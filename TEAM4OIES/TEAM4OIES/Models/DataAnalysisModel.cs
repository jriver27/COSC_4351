using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace TEAM4OIES.Models
{
    public class DataAnalysisModel
    {
        
        
        public Patient getPatientStats(int patientIDp)
        {

            Patient patientFound=new Patient();  
            UC9DataContext db = new UC9DataContext();
            var correctPatient = db.Patients.Single(u => u.patient_id == patientIDp);
           
           
            return correctPatient;
          //Javier, this function returns the patient with the matching id
        }
        public int getAge(int ageinDB, DateTime dateofSurg)
        {
            
            
            return ageinDB+ (DateTime.Now.Year-dateofSurg.Year);
        }
        public List<Study> getCTScans(int patientIDp)
        {
            
            UC9DataContext db = new UC9DataContext();
            var allScans = from scan in db.Studies
                           where scan.patient_id == patientIDp
                           select scan;
            return allScans.ToList();
            //Jaiver, this function returns all the ct scans under a patient
        }
        public List<Series> getSeries(int studyiD)
        {
            UC9DataContext db = new UC9DataContext();
            var allScans = from scan in db.Series
                           where scan.study_id == studyiD
                           select scan;
            return allScans.ToList();
            //Jaiver, this function returns all the series under a study
            
        }
        public List<Slice> getSlices(int seriesID)
        {
            UC9DataContext db = new UC9DataContext();
            var allScans = from scan in db.Slices
                           where scan.series_id == seriesID
                           select scan;
            return allScans.ToList();
            //Jaiver, this function returns all the slices under a series
            //Total # of slides=size of this list    
        }
        public double getROIend(double thickness, int illiacbif)
        {
             return Math.Round(10/thickness+illiacbif);
            
            //returns ROI end
        }
        public double totSlidesROI(int ROIbegin, int ROIend, double thickness)
        {
            return Math.Round((ROIend - ROIbegin) * thickness);
            //return totalSlides
        }
        public double ROIlen(double totSlides, double thickness)
        {
            return totSlides / thickness;
            //returns ROI length(cm)
        }

        //Everything done except for getdelay, getthick, getpixellen
   } 
}