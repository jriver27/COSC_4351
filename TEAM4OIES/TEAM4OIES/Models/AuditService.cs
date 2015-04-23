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
        public Boolean AddtoAudit(int UserID, String username, String tablename, String attribute, String access)
        {
            DateTime date = DateTime.Now;
            DataSet1TableAdapters.AuditTableAdapter auditRowAdapter = new DataSet1TableAdapters.AuditTableAdapter();
            auditRowAdapter.InsertQuery(UserID, username, date, tablename, attribute, access);
            return true;
        }
        public DataSet1.AuditDataTable GetTable()
        {
            DataSet1TableAdapters.AuditTableAdapter auditRowAdapter = new DataSet1TableAdapters.AuditTableAdapter();
            DataSet1.AuditDataTable getTable;
            getTable=auditRowAdapter.GetDataBy1();
            return getTable;
           
        }
        public String DisplayRow(DataSet1.AuditDataTable data,int index)
        {
            String row =data[index].audit_id.ToString()+ " ";
            row = row + data[index].UserID.ToString()+ " ";
            row = row + data[index].username+ " ";
            row = row + data[index].date.ToString()+ " ";
            row = row + data[index].table_+ " ";
            row = row + data[index].attribute+ " ";
            row = row + data[index].access+ " ";
            return row;
        }
        public List<Audit> GetAuditList(DataSet1.AuditDataTable data)
        {
            List<Audit> auditList = new List<Audit>();
            for (int x = 0; x < data.Count; x++)
            {
                Audit currentAudit = new Audit(data[x].audit_id, data[x].UserID, data[x].username, data[x].date, data[x].table_, data[x].attribute, data[x].access);
                auditList.Add(currentAudit);
            }
            return auditList;
        }
        public DataSet1.AuditDataTable GetTableByDate(String date)
        {
            DateTime dateInDateTime=Convert.ToDateTime(date);
            DataSet1TableAdapters.AuditTableAdapter auditRowAdapter = new DataSet1TableAdapters.AuditTableAdapter();
            DataSet1.AuditDataTable getTable;
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
