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
            Console.WriteLine(date.ToString());
            TEAM4OIESDataSet auditdataset= new TEAM4OIESDataSet();
            TEAM4OIESDataSet.AuditRow newAuditRow = auditdataset.Audit.NewAuditRow();
            newAuditRow.UserID = UserID;
            newAuditRow.date = date;
            newAuditRow.username = username;
            newAuditRow.table_ = tablename;
            newAuditRow.attribute = attribute;
            newAuditRow.access = access;
            auditdataset.Audit.Rows.Add(newAuditRow);
            return true;
        }
    }
   
}
