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
        //Name of Code Artifact:addToTestimonial
        //Programmer's Name:Linh Tong
        //Date it was coded: 04/25/2014
        //Date Approved:
        //SQA Approver:
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
                    insertTest.Parameters.AddWithValue("@content", content);
                    insertTest.Parameters.AddWithValue("@surgeonID", surgeon_ID);

                    insertTest.ExecuteNonQuery();
                    insertTest.Parameters.Clear();
                    cnn.Close();
                    return true;
                }
                catch 
                {
                    // ignored
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