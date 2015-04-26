using System;
using System.Data.SqlClient;

namespace TEAM4OIES.Models
{
    public class TestimonialModels
    {
        //
        // GET: /TestimonialModels/

        public Boolean AddToTestimonial(String content, int surgeonId)
        {
            const string connectionString = "Data Source=sqlserver.cs.uh.edu,1044;Initial Catalog=TEAM4OIES;User ID=TEAM4OIES;Password=TEAM4OIES#";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    SqlCommand insertTest = new SqlCommand("INSERT INTO Testimonial (content, tDate, surgeonID) VALUES(@content, @tDate, @surgeonID);", cnn);
                    DateTime date = DateTime.Now;
                    insertTest.Parameters.AddWithValue("@tDate", date);
                    insertTest.Parameters.AddWithValue("@content", content);
                    insertTest.Parameters.AddWithValue("@surgeonID", surgeonId);

                    insertTest.ExecuteNonQuery();
                    insertTest.Parameters.Clear();
                    cnn.Close();
                    return true;
                }
                catch (Exception)
                {
                    //Ignored
                }
                finally
                {
                    cnn.Close();
                }
            }
            return false;
        }

        public object GetTestimonial(string keyword)
        {
            throw new NotImplementedException();
        }

        public object DisplaySurgeonName()
        {
            throw new NotImplementedException();
        }
    }
}