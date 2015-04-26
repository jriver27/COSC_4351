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
using System.Data.Entity;
namespace TEAM4OIES.Models
{
    public class TestimonialModels
    {
        //
        // GET: /TestimonialModels/

        public Boolean addToTestimonial(String content, int surgeon_ID)
        {
            
            DateTime date = DateTime.Now;
            DataSet1TableAdapters.TestimonialTableAdapter testimonialRowAdapter = new DataSet1TableAdapters.TestimonialTableAdapter();
            testimonialRowAdapter.InsertQuery(content, date, surgeon_ID);
            return true;
        }

       public object displaySurgeonName()
        {
          
            List<Testimonials> testList = new List<Testimonials>();
            Testimonials currTestimmonial = new Testimonials();
            DataClasses1DataContext db =new DataClasses1DataContext();
            var testList2 = from currTest in db.Testimonials
                            join currSurgeon in db.Surgeons
                            on currTest.surgeonID equals currSurgeon.surgeonID
                            select new
                            {
                                currTest.tDate,
                                currTest.content,
                                currSurgeon.firstName,
                                currSurgeon.lastName,
                            };
            
            return testList2;
             
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
