using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using TEAM4OIES.Models;
using System.Data.SqlClient;

namespace TEAM4OIES
{
    public partial class RegisterForm : System.Web.UI.Page
    {
        //creates a connection to the database
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TEAM4OIESConnectionString"].ConnectionString);

        //creates private database object
        SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["TEAM4OIESEntities"].ConnectionString);
        //private TEAM4OIESEntities db = new TEAM4OIESEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //opens connection to database
            con.Open();
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create surgeon object
            var surgeon = new RegisterModel();

            //text box in register form placed in to specified object
            surgeon.FirstName = firstName.Text;
            surgeon.LastName = lastName.Text;
            surgeon.UserName = username.Text;
            surgeon.Institution = institution.Text;
            surgeon.Email = email.Text;
            surgeon.Password = password.Text;

            //adds the enties to the tables
            //db.RegisterModel(surgeon);

            //need to add a check to prevent duplicate entry crash
            //saves entries to the database
            //db.SaveChanges();

            //closes connection
            con.Close();

            //shows the label saying "Registration Successful"
            Label1.Visible = true;
            Label1.Text = "Registration Successful";

            //Clears out the text enties in password
            //firstName.Text= "";
            //lastName.Text= "";
            password.Text = "";
            //userName.Text= "";
            //email.Text = "";
            //dateOfBirth.Text ="";

        }
    }
}