using System;

namespace TEAM4OIES.Models
{
    //Name of Code Artifact: CTScanModel
    //Programmer's Name:Javier Rivera
    //Date it was coded: 04/29/2014
    //Date Approved:
    //SQA Approver:
    public class CTScanModel
    {
        public DateTime DateOfSurgery { set; get; }
        public string GraftManufacturer { set; get; }

        public DateTime CtScan { get; set; }
        public int CTid { get; set; }
        public int Delay { get; set; }
    }
}