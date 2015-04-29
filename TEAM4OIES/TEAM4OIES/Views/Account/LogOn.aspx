<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TEAM4OIES.Models.LogOnModel>" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Log On
</asp:Content>

<asp:Content ID="loginContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Log On</h2>
    <p>
        Please enter your username and password if you have an account. Otherwise, use this link -> <%: Html.ActionLink("Register", "Register") %>
    </p>
    <%--
    <% using (Html.BeginForm()) { %>
        <%: Html.ValidationSummary(true, "Login was unsuccessful. Please correct the errors and try again.") %>
        <div>
            <fieldset>
                <legend>Account Information</legend>
                
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
                
                <div class="editor-rememberMe">
                    <%: Html.CheckBoxFor(m => m.RememberMe) %>
                    <%: Html.LabelFor(m => m.RememberMe) %>
                </div>
                
                <p>
                    <input type="submit" value="Log On" />
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
            Username: <%= Html.TextBox("username") %>
        </p>
        <p>
            Password: <%= Html.Password("password") %>
        </p>
        <input type="submit" value="Log In" />
    <% } %>

</asp:Content>
