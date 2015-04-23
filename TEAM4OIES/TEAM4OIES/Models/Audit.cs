using System;
using System.Web;

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
            AuditID=AuditIDp;
            UserID=userIDP;
            Username=usernamep;
            Date=datep;
            Tablename=tablenamep;
            Attribute=attributep;
            Access=accessp;
        }

    }

}
           

