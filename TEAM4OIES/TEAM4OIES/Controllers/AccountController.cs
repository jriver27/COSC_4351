using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using TEAM4OIES.Models;

namespace TEAM4OIES.Controllers
{

    [HandleError]
    public class AccountController : Controller
    {

        public IFormsAuthenticationService FormsService { get; set; }
        public IMembershipService MembershipService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (FormsService == null) { FormsService = new FormsAuthenticationService(); }
            if (MembershipService == null) { MembershipService = new AccountMembershipService(); }

            base.Initialize(requestContext);
        }

        // **************************************
        // URL: /Account/LogOn
        // **************************************

        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (MembershipService.ValidateUser(model.Email, model.Password))
                {
                    FormsService.SignIn(model.Email, model.RememberMe);
                    if (!String.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The email or password provided is incorrect.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        // **************************************
        // URL: /Account/LogOff
        // **************************************

        public ActionResult LogOff()
        {
            //FormsService.SignOut();
            Session["username"] = null;
            Session["userID"] = null;
            return RedirectToAction("Index", "Home");
        }

        // **************************************
        // URL: /Account/Register
        // **************************************

        public ActionResult Register()
        {
            ViewData["PasswordLength"] = "6";
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                MembershipCreateStatus createStatus = MembershipService.CreateUser(model.UserName, model.Password, model.Email);

                if (createStatus == MembershipCreateStatus.Success)
                {
                    FormsService.SignIn(model.Email, false /* createPersistentCookie */);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", AccountValidation.ErrorCodeToString(createStatus));
                }
            }

            // If we got this far, something failed, redisplay form
            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;
            return View(model);
        }

        // **************************************
        // URL: /Account/ChangePassword
        // **************************************

        [Authorize]
        public ActionResult ChangePassword()
        {
            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                if (MembershipService.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword))
                {
                    return RedirectToAction("ChangePasswordSuccess");
                }
                else
                {
                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
                }
            }

            // If we got this far, something failed, redisplay form
            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;
            return View(model);
        }

        // **************************************
        // URL: /Account/ChangePasswordSuccess
        // **************************************

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }

        //Artifact Name: account login controller
        //DBA: Logan Stark
        //Date: 4/27/2015
        //approval: Linh Tong
        //approval date: 04/29/2015
        public ActionResult LogInform(String username, String password)
        {
            Session["username"] = username;
            TEAM4OIES.Models.AccountModels login = new TEAM4OIES.Models.AccountModels();
            String classify = login.accountLogin(username, password);
            Session["userID"] = classify.Substring(1);
            
            String name = Session["username"].ToString();
            char charTo = Session["userID"].ToString()[0];
            int ID = (int)(charTo) - 48;
            TEAM4OIES.Models.AuditService audit = new TEAM4OIES.Models.AuditService();
            audit.AddtoAudit(ID, name, "Surgeon", "userType,SurgeonID", "View");
            
            if (classify[0] == '2')
            {
                return RedirectToAction("Index","Audit");
            }
            else if (classify[0] == '1')
            {
                return RedirectToAction("Index", "Surgeon");
            }
            else if (classify[0] == '3')
            {
                Response.Redirect("http://account.zopim.com/signup?lang=en-us#login");
                return RedirectToAction("Home", "Index");
            }
            else
            {
                TempData["notice"] = "Error: Invalid username or password";
                return View("LogOn");
            }
        }
        //Artifact Name: Registration form
        //DBA: Logan Stark
        //Date: 4/27/2015
        //approval: Linh Tong
        //approval date: 04/29/2015
        public ActionResult RegistrationForm(String firstName, String lastName, String username, String password, String confirmPassword, String email, int institution_id)
        {
            /*Unneeded
            Session["firstName"] = firstName;
            Session["userType"] = 1;
            Session["lastName"] = lastName;
            Session["userName"] = username;
            Session["email"] = email;
            Session["institution_id"] = institution_id;
            */
            if (password.Length < 6)
            {
                TempData["notice"] = "Error: Password is too short";
                return View("Register");
            }

            
            TEAM4OIES.Models.AccountModels register = new TEAM4OIES.Models.AccountModels();
            bool success = register.createAccount(1, firstName, lastName, username, password, email, institution_id);
            if (success)
            {
                TEAM4OIES.Models.AuditService audit = new TEAM4OIES.Models.AuditService();
                audit.AddtoAudit(0, username, "Surgeon", "All", "Insert");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["notice"] = "Error: Registration Failed";
                return View("Register");
            }
        }

        //Artifact Name: username
        //DBA: Logan Stark
        //Date: 4/27/2015
        //approval: Linh Tong
        public String getUsername()
        {
            return Session["username"].ToString();
        }
        public int getUserID()
        {//'0' = 48 
            char charTO = Session["UserID"].ToString()[0];
            return (int)charTO - 48;
        }
    }
}
