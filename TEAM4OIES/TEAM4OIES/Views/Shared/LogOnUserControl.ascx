<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Session["UserID"] != null) {
%>
        Welcome <b><%: Session["username"] %></b>!
         <%: Html.ActionLink("Log Off", "LogOff", "Account") %> 
<%
    }
    else {
%> 
         <%: Html.ActionLink("Log In", "LogOn", "Account") %> 
<%
    }
%>
