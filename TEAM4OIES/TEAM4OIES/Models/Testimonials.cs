using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEAM4OIES.Models
{
    public class Testimonials
    {
        //public int testimonialID { private set; get; }
        public String content { private set; get; }
        public DateTime tDate{ private set; get; }
        //public int surgeonID { private set; get; }
        public String firstName { private set; get; }
        public String lastName { private set; get; }
        public Testimonials(String content_, DateTime tDate_, String firstName_, String lastName_)
        {
            firstName = firstName_;
            content = content_;
            tDate = tDate_;
            lastName = lastName_;
        }
        public Testimonials()
        {
           tDate= new DateTime();
            content=" ";
            firstName=" ";
            lastName=" ";
        }
    }
}