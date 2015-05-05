<%--Name of Artifact: Index.aspx
    Programmers Name: Paul Miller
    Date of Code: 04/27/2015
    Date of Approval: 04/29/2015
    SQA Name:Linh Tong--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterUserPage.master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Audit Table
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Audit Table</h2>
<% using (Html.BeginForm("DispTable", "Audit")) %>
<% { %>
  Date of Audit 
  <input type="date" name="Auditdate" value="Auditdate" />
  <input type="submit" value="Display Table" />
<% } %>
    
</asp:Content>
