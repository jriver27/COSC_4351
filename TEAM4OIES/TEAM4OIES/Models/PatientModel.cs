using System;

namespace TEAM4OIES.Models
{
    //Name of Code Artifact: PatientModel
    //Programmer's Name:Javier Rivera
    //Date it was coded: 04/29/2014
    //Date Approved:
    //SQA Approver:
    public class PatientModel
    {
        public string PatienId { get; set; }

        public string PatientNumber { get; set; }
        public DateTime PatientDOB { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
    }
}