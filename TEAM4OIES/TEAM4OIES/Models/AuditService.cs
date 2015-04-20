using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Windows.Forms;



namespace TEAM4OIES.Models
{
   
    public class AuditService 
    {
        public Boolean addtoAudit(int UserID, String username, String tablename, String attribute, String access)
        {
            DateTime date = DateTime.Now;
            DataSet1TableAdapters.AuditTableAdapter auditRowAdapter = new DataSet1TableAdapters.AuditTableAdapter();
            auditRowAdapter.InsertQuery(UserID, username, date, tablename, attribute, access);
            return true;
        }
    }
   
}
