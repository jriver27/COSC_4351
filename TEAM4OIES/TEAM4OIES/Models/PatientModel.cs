using System;
using System.Collections.Generic;

namespace TEAM4OIES.Models
{
    //Name of Code Artifact: PatientModel
    //Programmer's Name:Javier Rivera
    //Date it was coded: 04/29/2014
    //Date Approved:
    //SQA Approver:
    public class PatientModel
    {
        public int PatienId { get; set; }
        public DateTime SurgeryDate { set; get; }
        public string PatientNumber { get; set; }
        public DateTime PatientDOB { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public IEnumerable<Study> StudiesId { set; get; }
    }
}