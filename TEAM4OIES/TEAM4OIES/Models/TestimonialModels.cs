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
            string connectionString = "Data Source=sqlserver.cs.uh.edu,1044;Initial Catalog=TEAM4OIES;User ID=TEAM4OIES;Password=TEAM4OIES#";
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    try
                    {
                        cnn.Open();
                        SqlCommand insertTest = new SqlCommand("INSERT INTO Testimonial (content, tDate, surgeonID) VALUES(@content, @tDate, @surgeonID);", cnn);
                        DateTime date = DateTime.Now;
                        insertTest.Parameters.AddWithValue("@tDate", date);
            testimonialRowAdapter.InsertQuery(content, date, surgeon_ID);
                        insertTest.Parameters.AddWithValue("@surgeonID", surgeon_ID);

                        insertTest.ExecuteNonQuery();
                        insertTest.Parameters.Clear();
                        cnn.Close();
                        return true;
                    }
                    catch (Exception e)
        public List<Testimonials> displaySurgeonName()
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
                            };
            
            return testList2;
             
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
                return false;
        }
   }
}
