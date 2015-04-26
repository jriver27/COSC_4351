using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEAM4OIES.Models
{
    public class InstitutionModels
    {
        public Boolean addToInstitution(int institutionID, String institution)
        {
            DataSet1TableAdapters.InstitutionTableAdapter institutionRowAdapter = new DataSet1TableAdapters.InstitutionTableAdapter();
            institutionRowAdapter.InsertQuery(institution);
            return true;
        }
    }
}