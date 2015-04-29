<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TEAM4OIES.Models.RegisterModel>" %>

<asp:Content ID="registerTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Register
</asp:Content>

<asp:Content ID="registerContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <h2>Create a New Account</h2>
    <p>
        Use the form below to create a new account. 
    </p>
    <p>
        Passwords are required to be a minimum of <%: ViewData["PasswordLength"] %> characters in length.
    </p>
    <%--
    <% using (Html.BeginForm()) { %>
        <%: Html.ValidationSummary(true, "Account creation was unsuccessful. Please correct the errors and try again.") %>
        <div>
            <fieldset>
                <legend>Account Information</legend>
                
                <div class="editor-firstName">
                    <%: Html.LabelFor(m => m.FirstName) %>
                </div>
                <div class="editor-firstName">
                    <%: Html.TextBoxFor(m => m.FirstName) %>
                    <%: Html.ValidationMessageFor(m => m.FirstName) %>
                </div>
                
                <div class="editor-lastName">
                    <%: Html.LabelFor(m => m.LastName) %>
                </div>
                <div class="editor-lastName">
                    <%: Html.TextBoxFor(m => m.LastName) %>
                    <%: Html.ValidationMessageFor(m => m.LastName) %>
                </div>

                 <div class="editor-username">
                    <%: Html.LabelFor(m => m.UserName) %>
                </div>
                <div class="editor-username">
                    <%: Html.TextBoxFor(m => m.UserName) %>
                    <%: Html.ValidationMessageFor(m => m.UserName) %>
                </div>

                <div class="editor-institution">
                    <%: Html.LabelFor(m => m.Institution) %>
                </div>
                <div class="editor-institution">
                    <%: Html.TextBoxFor(m => m.Institution) %>
                    <%: Html.ValidationMessageFor(m => m.Institution) %>
                </div>

                <div class="editor-email">
                    <%: Html.LabelFor(m => m.Email) %>
                </div>
                <div class="editor-email">
                    <%: Html.TextBoxFor(m => m.Email) %>
                    <%: Html.ValidationMessageFor(m => m.Email) %>
                </div>
                
                <div class="editor-password">
                    <%: Html.LabelFor(m => m.Password) %>
                </div>
                <div class="editor-password">
                    <%: Html.PasswordFor(m => m.Password) %>
                    <%: Html.ValidationMessageFor(m => m.Password) %>
                </div>
                
                <div class="editor-confirmPassword">
                    <%: Html.LabelFor(m => m.ConfirmPassword) %>
                </div>
                <div class="editor-confirmPassword">
                    <%: Html.PasswordFor(m => m.ConfirmPassword) %>
                    <%: Html.ValidationMessageFor(m => m.ConfirmPassword) %>
                </div>
                
                <p>
                    <input type="submit" value="Register" />
                </p>
            </fieldset>
        </div>
    <% } %>--%>
    <% if (TempData["notice"] != null) { %>
        <p><%= Html.Encode(TempData["notice"]) %></p>
    <% } %>

    <% using(Html.BeginForm("LogInForm","Account")) %>
    <% { %>
        <p>
            First Name: <%= Html.TextBox("firstName") %>
        </p>
        <p>
            Last Name: <%= Html.TextBox("lastName") %>
        </p>
        <p>
            Username: <%= Html.TextBox("username") %>
        </p>
        <p>
            Password: <%= Html.TextBox("password") %>
        </p>
        <p>
            Email: <%= Html.TextBox("email") %>
        </p>
        <input type="submit" value="Submit" />
    <% } %>
    </form>
</asp:Content>
