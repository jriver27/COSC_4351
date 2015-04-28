using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEAM4OIES.Misc
{
    //Name of Code Artifact:class TableNames
    //Programmer's Name:Javier Rivera
    //Date it was coded: 04/28/2014
    //Date Approved:
    //SQA Approver:
    public static class TableNames
    {
        public static string Brand { get; private set; }
        public static string Endograft { get; private set; }
        public static string Testimonial { get; private set; }
        public static string Surgeon { get; private set; }
        public static string Institution { get; private set; }
        public static string Audit { get; private set; }
        public static string Patient { get; private set; }
        public static string Study { get; private set; }
        public static string Slice { get; private set; }
        public static string Series { get; private set; }

        static TableNames()
        {
            Brand = "Brand";
            Endograft = "Endograft";
            Testimonial = "Testimonials";
            Surgeon = "Surgeon";
            Institution = "Institution";
            Audit = "Audit";
            Patient = "Patient";
            Study = "Study";
            Slice = "Slice";
            Series = "Series";
        }
    }
}