/*
 * TM: Janaye Maggart
 * LogOnModel,Register Model CreateUser 
 * April 24, 2015
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
//using System.Data.EntityClient;
//using System.Data.Objects;
//using System.Data.Objects.DataClasses;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TEAM4OIES.Models
{

    #region Models
    [PropertiesMustMatch("NewPassword", "ConfirmPassword", ErrorMessage = "The new password and confirmation password do not match.")]
    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Current password")]
        public string OldPassword { get; set; }

        [Required]
        [ValidatePasswordLength]
        [DataType(DataType.Password)]
        [DisplayName("New password")]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Confirm new password")]
        public string ConfirmPassword { get; set; }
    }

    public class LogOnModel
    {
        [Required]
        [DisplayName("User name")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Remember me?")]
        public bool RememberMe { get; set; }
    }

    [PropertiesMustMatch("Password", "ConfirmPassword", ErrorMessage = "The password and confirmation password do not match.")]
    public class RegisterModel
    {
        [Required]
        [DisplayName("User name")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Institution")]
        public string Institution { get; set; }

        [Required]
        [DisplayName("Institution ID")]
        public string InstitutionID { get; set; }

        [Required]
        [DisplayName("InstitutionName")]
        public string InstitutionName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email address")]
        public string Email { get; set; }

        [Required]
        [ValidatePasswordLength]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Confirm password")]
        public string ConfirmPassword { get; set; }
    }
    #endregion

    #region Services
    // The FormsAuthentication type is sealed and contains static members, so it is difficult to
    // unit test code that calls its members. The interface and helper class below demonstrate
    // how to create an abstract wrapper around such a type in order to make the AccountController
    // code unit testable.

    public interface IMembershipService
    {
        int MinPasswordLength { get; }

        bool ValidateUser(string userName, string password);
        MembershipCreateStatus CreateUser(string userName, string password, string email);
        bool ChangePassword(string userName, string oldPassword, string newPassword);
    }

    public class AccountMembershipService : IMembershipService
    {
        private readonly MembershipProvider _provider;
        private bool isConnectionInitialized = false;
        private bool connectionClosed = true;
        private SqlConnection con;
        private string connectionString = "Server=sqlserver.cs.uh.edu,1044; User id=TEAM4OIES;Password=TEAM4OIES#;Database=TEAM4OIES";

        public AccountMembershipService()
            : this(null)
        {
        }

        public AccountMembershipService(MembershipProvider provider)
        {
            _provider = provider ?? Membership.Provider;
        }

        public int MinPasswordLength
        {
            get
            {
                return _provider.MinRequiredPasswordLength;
            }
        }

        //    //Artifact Name: account login model
        //    //DBA: Logan Stark
        //    //Date: 4/27/2015
        //    //approval:
        //    //approval date:
        //    public int accountLogin(String username,String password)
        //    {
        //        string connectionString = "Data Source=sqlserver.cs.uh.edu,1044;Initial Catalog=TEAM4OIES;User ID=TEAM4OIES;Password=TEAM4OIES#";


        //        using (SqlConnection cnn = new SqlConnection(connectionString))
        //        {
        //            try
        //            {
        //                cnn.Open()
        //                string sql = "SELECT Surgeon.userType FROM Surgeon WHERE Surgeon.username = @username AND Surgeon.password = @password”
        //                SqlCommand getClassification = new SqlCommand(sql,cnn);
        //                getClassification.Parameters.AddWithValue(“@username”,username);
        //                getClassification.Parameters.AddWithValue(“@password”,password);

        //                SqlDataReader reader = getClassification.ExecuteREader();
        //                if(reader.HasRows && reader.Read())
        //                {
        //                    return reader.getInt16();
        //                }

        //            finally
        //            {
        //                return -1;
        //            }
        //            }
        //        }
        //}

        public bool ValidateUser(string UserName, string Password)
        {
            if (String.IsNullOrEmpty(UserName)) throw new ArgumentException("Value cannot be null or empty.", "userName");
            if (String.IsNullOrEmpty(Password)) throw new ArgumentException("Value cannot be null or empty.", "password");

            //connection = new SqlConnection(connectionString);
            initializeConnection();
            try
            {
            SqlDataAdapter sqlid = new SqlDataAdapter("SELECT username, password FROM Surgeon WHERE username ='" + UserName + "'AND password ='" + Password + "'", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.DataTable dtemp = new System.Data.DataTable();
            sqlid.Fill(dt);

            return _provider.ValidateUser(UserName, Password);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        ////Artifact Name: register account model
        ////DBA: Logan Stark
        ////Date: 4/27/2015
        ////approval:
        ////approval date:
        //public Boolean createAccount(int userType, String firstName, String lastName,
        //String username,String password,String email, int institution_id)
        //{
        //    string connectionString = "Data Source=sqlserver.cs.uh.edu,1044;Initial Catalog=TEAM4OIES;User ID=TEAM4OIES;Password=TEAM4OIES#";
        //    using (SqlConnection cnn = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            cnn.Open();
        //            string sql = "INSERT INTO Surgeon (userType,firstName,lastName,username,password,email,institution_id) VALUES(@userType,@firstName,@lastName,@username,@password,@email,@institution_id)”;
        //            SqlCommand registerSurgeon= new SqlCommand(sql,cnn);
        //            registerSurgeon.Parameters.AddWithValue(“@userType”,userType);
        //            registerSurgeon.Parameters.AddWithValue(“@firstName”,firstName);
        //            registerSurgeon.Parameters.AddWithValue(“@lastName”,lastName);
        //            registerSurgeon.Parameters.AddWithValue(“@username”,username);
        //            registerSurgeon.Parameters.AddWithValue(“@password”,password);
        //            registerSurgeon.Parameters.AddWithValue(“@email”,email);
        //            registerSurgeon.Parameters.AddWithValue(“@institution_id”,institution_id);

        //            registerSurgeon.ExecuteNonQuery();
        //            cnn.Close();
        //            return true;
        //        }
        //        catch(Exception e)
        //        {
        //        }
        //        finally
        //        {
        //            cnn.Close();
        //        }
        //    }
        //}

        public MembershipCreateStatus CreateUser(string UserName, string Password, string Email)
        //public MembershipCreateStatus CreateUser(string userName, string password, string email)
        {
            if (String.IsNullOrEmpty(UserName)) throw new ArgumentException("Value cannot be null or empty.", "UserName");
            if (String.IsNullOrEmpty(Password)) throw new ArgumentException("Value cannot be null or empty.", "Password");
            if (String.IsNullOrEmpty(Email)) throw new ArgumentException("Value cannot be null or empty.", "Email");

            initializeConnection();
            //openConnection();
            string surgeonID = surgeonIDRandomSelector();
            RegisterModel model = new RegisterModel();

            while (!checkSurgeonIDUniqueness(surgeonID))
            {
                surgeonID = surgeonIDRandomSelector();
            }
            openConnection();
            MembershipCreateStatus status;
            try
            {
                _provider.CreateUser(UserName, Password, Email, null, null, true, null, out status);


                SqlDataAdapter sqlid = new SqlDataAdapter("SELECT username, password, email, firstName, lastName, institution_id FROM Surgeon WHERE username ='" + UserName + "'AND password ='" + Password + "'AND email ='" + Email + "'AND firstName ='" + model.FirstName + "'AND lastName ='" + model.LastName + "'AND institution_id ='" + model.InstitutionID + "'", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                //System.Data.DataTable dtemp = new System.Data.DataTable();
                sqlid.Fill(dt);
                if (dt.Rows.Count != 0)
                    return MembershipCreateStatus.DuplicateUserName;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Surgeon(surgeonID,username,password, email, firstName, lastName, institution_id) VALUES('" + surgeonID
                    + "','"
                    + UserName + "','"
                    + Password + "','"
                    + Email + "','"
                    + model.FirstName + "','"
                    + model.LastName + "','"
                    + model.InstitutionID + "')";

                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandType = System.Data.CommandType.Text;
                cmd2.CommandText = "INSERT INTO Institution(institution_id,institution) VALUES('" + model.InstitutionID
                    + "','"
                    + model.InstitutionName + "')";


                cmd.Connection = con;
                //con.Open();
                cmd.ExecuteNonQuery();
                //con.Close();
                closeConnection();

                return MembershipCreateStatus.Success;
            }
            catch (Exception ex)
            {
                return MembershipCreateStatus.ProviderError;
            }
        }

        public bool ChangePassword(string userName, string oldPassword, string newPassword)
        {
            if (String.IsNullOrEmpty(userName)) throw new ArgumentException("Value cannot be null or empty.", "userName");
            if (String.IsNullOrEmpty(oldPassword)) throw new ArgumentException("Value cannot be null or empty.", "oldPassword");
            if (String.IsNullOrEmpty(newPassword)) throw new ArgumentException("Value cannot be null or empty.", "newPassword");

            // The underlying ChangePassword() will throw an exception rather
            // than return false in certain failure scenarios.
            try
            {
                MembershipUser currentUser = _provider.GetUser(userName, true /* userIsOnline */);
                return currentUser.ChangePassword(oldPassword, newPassword);
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (MembershipPasswordException)
            {
                return false;
            }
        }

        private string surgeonIDRandomSelector()
        {
            string surgeonID = "";
            int randnum = 0;
            int numberOfDigits = 0;
            Random r = new Random();
            randnum = r.Next(1, 999);
            numberOfDigits = randnum.ToString().Length;

            if (numberOfDigits < 3)
            {
                int numberRemaining = 3 - numberOfDigits;
                for (int i = 0; i < numberRemaining; i++)
                {
                    surgeonID += "0";
                }
                surgeonID += randnum.ToString();
            }
            else
                surgeonID = randnum.ToString();
            return surgeonID;
        }

        private bool checkSurgeonIDUniqueness(string newSurgeonID)
        {
            initializeConnection();
            openConnection();
            SqlDataAdapter sqlid = new SqlDataAdapter("SELECT surgeonID FROM Surgeon WHERE surgeonID ='" + newSurgeonID + "'", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            //System.Data.DataTable dtemp = new System.Data.DataTable();
            sqlid.Fill(dt);
            int rowCount = dt.Rows.Count;
            closeConnection();
            if (rowCount != 0)
                return false;
            return true;
        }

        private bool openConnection()
        {
            if (connectionClosed)
            {
                con.Open();
                connectionClosed = false;
            }
            return true;
        }

        private bool closeConnection()
        {
            if (!connectionClosed)
            {
                con.Close();
                connectionClosed = true;
            }
            return true;
        }

        private bool initializeConnection()
        {
            if (!isConnectionInitialized)
                con = new SqlConnection(connectionString);
            return isConnectionInitialized = true;
        }
    }

    public interface IFormsAuthenticationService
    {
        void SignIn(string userName, bool createPersistentCookie);
        void SignOut();
    }

    public class FormsAuthenticationService : IFormsAuthenticationService
    {
        public void SignIn(string userName, bool createPersistentCookie)
        {
            if (String.IsNullOrEmpty(userName)) throw new ArgumentException("Value cannot be null or empty.", "userName");

            FormsAuthentication.SetAuthCookie(userName, createPersistentCookie);
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
    #endregion

    #region Validation
    public static class AccountValidation
    {
        public static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "Username already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A username for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public sealed class PropertiesMustMatchAttribute : ValidationAttribute
    {
        private const string _defaultErrorMessage = "'{0}' and '{1}' do not match.";
        private readonly object _typeId = new object();

        public PropertiesMustMatchAttribute(string originalProperty, string confirmProperty)
            : base(_defaultErrorMessage)
        {
            OriginalProperty = originalProperty;
            ConfirmProperty = confirmProperty;
        }

        public string ConfirmProperty { get; private set; }
        public string OriginalProperty { get; private set; }

        public override object TypeId
        {
            get
            {
                return _typeId;
            }
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentUICulture, ErrorMessageString,
                OriginalProperty, ConfirmProperty);
        }

        public override bool IsValid(object value)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(value);
            object originalValue = properties.Find(OriginalProperty, true /* ignoreCase */).GetValue(value);
            object confirmValue = properties.Find(ConfirmProperty, true /* ignoreCase */).GetValue(value);
            return Object.Equals(originalValue, confirmValue);
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class ValidatePasswordLengthAttribute : ValidationAttribute
    {
        private const string _defaultErrorMessage = "'{0}' must be at least {1} characters long.";
        private readonly int _minCharacters = Membership.Provider.MinRequiredPasswordLength;

        public ValidatePasswordLengthAttribute()
            : base(_defaultErrorMessage)
        {
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentUICulture, ErrorMessageString,
                name, _minCharacters);
        }

        public override bool IsValid(object value)
        {
            string valueAsString = value as string;
            return (valueAsString != null && valueAsString.Length >= _minCharacters);
        }
    }
    #endregion

}
