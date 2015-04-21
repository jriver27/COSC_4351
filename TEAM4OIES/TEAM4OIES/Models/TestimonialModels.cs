using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace TEAM4OIES.Models
{
    public class TestimonialModels
    {
        //
        // GET: /TestimonialModels/

        public Boolean addToTestimonial(int testimonial_ID, String content, int surgeon_ID)
        {
            DateTime date = DateTime.Now;
            DataSet1TableAdapters.TestimonialTableAdapter testimonialRowAdapter = new DataSet1TableAdapters.TestimonialTableAdapter();
            testimonialRowAdapter.InsertQuery(testimonial_ID, content, date, surgeon_ID);
            return true;
        }


    }
}
