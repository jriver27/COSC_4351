using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;

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

        public List<Testimonials> displaySurgeonName()
        {
            List<Testimonials> testimonialsList = new List<Testimonials>();
            DataSet1TableAdapters.TestimonialTableAdapter testNameAdapter = new DataSet1TableAdapters.TestimonialTableAdapter();
            DataSet1.TestimonialDataTable testSurgeonTable;
            DataSet1TableAdapters.SurgeonTableAdapter surgeonNameAdapter = new DataSet1TableAdapters.SurgeonTableAdapter();
            DataSet1.SurgeonDataTable getSurgeonTable;
            testSurgeonTable = testNameAdapter.GetDataBy1();            
            getSurgeonTable = surgeonNameAdapter.GetDataBy1(); //surgeonID is a primary key
            for (int i = 0; i < getSurgeonTable.Count; i++)
            {
                Testimonials currentTest = new Testimonials(testSurgeonTable[i].content, testSurgeonTable[i].tDate, getSurgeonTable[i].firstName, getSurgeonTable[i].lastName);
                testimonialsList.Add(currentTest);
            }
            return testimonialsList;
        }

        public DataSet1.TestimonialDataTable GetTable()
        {
            DataSet1TableAdapters.TestimonialTableAdapter testRowAdapter = new DataSet1TableAdapters.TestimonialTableAdapter();
            DataSet1.TestimonialDataTable getTable;
            getTable = testRowAdapter.GetData();
            return getTable;
        }

        public List<Testimonials> getTestimonial(String keyword)
        {
            List<Testimonials> testimonialsList = new List<Testimonials>();
            DataSet1TableAdapters.TestimonialTableAdapter testRowAdapter = new DataSet1TableAdapters.TestimonialTableAdapter();
            DataSet1.TestimonialDataTable getTable;
            DataSet1TableAdapters.SurgeonTableAdapter surgeonNameAdapter = new DataSet1TableAdapters.SurgeonTableAdapter();
            DataSet1.SurgeonDataTable getSurgeonTable;
            getTable = testRowAdapter.GetDataBy3(keyword);
            getSurgeonTable = surgeonNameAdapter.GetDataBy3(keyword); //surgeonID is a primary key
            for (int i = 0; i < getSurgeonTable.Count; i++)
            {
                Testimonials keywordTest = new Testimonials(getTable[i].content, getTable[i].tDate, getSurgeonTable[i].firstName, getSurgeonTable[i].lastName);
                testimonialsList.Add(keywordTest);
            }
            return testimonialsList;
        }
     }
}
