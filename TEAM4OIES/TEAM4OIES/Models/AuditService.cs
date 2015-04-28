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

    public class Audit
    {
        public int AuditID { private set; get; }
        public int UserID { private set; get; }
        public String Username { private set; get; }
        public DateTime Date { private set; get; }
        public String Tablename { private set; get; }
        public String Attribute { private set; get; }
        public String Access { private set; get; }
        public Audit(int AuditIDp, int userIDP, String usernamep, DateTime datep, String tablenamep, String attributep, String accessp)
        {
            AuditID = AuditIDp;
            UserID = userIDP;
            Username = usernamep;
            Date = datep;
            Tablename = tablenamep;
            Attribute = attributep;
            Access = accessp;
        }

    }

   
    public class AuditService 
    {
        public Boolean AddtoAudit(int UserID, String username, String tablename, String attribute, String access)
        {
            UC13TableAdapters.AuditTableAdapter auditRowAdapter = new UC13TableAdapters.AuditTableAdapter();
            DateTime date = DateTime.Now;
            auditRowAdapter.InsertQuery(UserID, username, date, tablename, attribute, access);
            return true;
        }
        
       
        public List<Audit> GetAuditList(UC13.AuditDataTable data)
        {
            List<Audit> auditList = new List<Audit>();
            for (int x = 0; x < data.Count; x++)
            {
                Audit currentAudit = new Audit(data[x].audit_id, data[x].UserID, data[x].username, data[x].date, data[x].table_, data[x].attribute, data[x].access);
                auditList.Add(currentAudit);
                
            }
            return auditList;
        }
        public UC13.AuditDataTable GetTableByDate(String date)
        {
            DateTime dateInDateTime=Convert.ToDateTime(date);
            UC13TableAdapters.AuditTableAdapter auditRowAdapter = new UC13TableAdapters.AuditTableAdapter();
            UC13.AuditDataTable getTable;
            String finalDate=GetRealDate(dateInDateTime);
            getTable = auditRowAdapter.GetDataBy2(finalDate);
            return getTable;

        }

        private string GetRealDate(DateTime date)
        {
            string thedate, themonth;
            if (date.Day.ToString().Count() < 2)
            {
                thedate = "0" + date.Day.ToString()+ "/";
            }
            else
            {
                thedate = date.Day.ToString() + "/";
            }
            if(date.Month.ToString().Count() < 2)
            {
                themonth = "0" + date.Month.ToString()+ "/";
            }
            else
            {
                themonth = date.Month.ToString() + "/";
            }
            return themonth+thedate + date.Year.ToString();




            
        }

    }

   
}
