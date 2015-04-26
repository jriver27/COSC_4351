using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEAM4OIES.Models
{
    public class SurgeonModels
    {
        public Boolean addToSurgeon (int userType, 
            String firstName, String lastName, String userName, 
            String password, String email,
            int institutionID, Boolean online, Boolean active)
        {
            DataSet1TableAdapters.SurgeonTableAdapter surgeonRow = new DataSet1TableAdapters.SurgeonTableAdapter();
            surgeonRow.InsertQuery(userType, firstName, lastName, userName, password, email, institutionID, online, active);
            return true;
        }
    }
}