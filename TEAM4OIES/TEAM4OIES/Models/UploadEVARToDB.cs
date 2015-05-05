/*Name of Artifact: UC7
    Programmers Name: Jainesh Mehta
    Date of Code: 04/27/2015
    Date of Approval: April 29 2015
    SQA Name:- Paul Miller*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Windows.Forms;


namespace TEAM4OIES.Models
{
    public class Endograft
    {
        public int endograftID { set; get; }
        public DateTime date { set; get; }
        public float diameter { set; get; }
        public float length { set; get; }
        public float unilateralLegDiameter { set; get; }
        public float unilateralLegLength { set; get; }
        public float controlaterLegDiameter { set; get; }
        public float controlaterLegLength { set; get; }
        public String entryPoint { set; get; }
        public int brandId { set; get; }

    }

}

