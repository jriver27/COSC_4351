<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%--Name of Artifact: DispTable.aspx
    Programmers Name: Paul Miller
    Date of Code: 04/27/2015
    Date of Approval:
    SQA Name:--%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Audit Table
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Audit Table</h2>
        
    <table>
        <tr>
            <th>
                Audit ID
            </th>
            <th>
                User ID
            </th>
            <th>
                Username
            </th>
            <th>
                date
            </th>
            <th>
                Table Name
            </th>
            <th>
                Attribute
            </th>
            <th>
                Access
            </th>
        </tr>
        <%foreach (var currentAudit in (ViewData["audits"] as IEnumerable<TEAM4OIES.Models.Audit>))
          {%>
        <tr>
            <td>
                <%=currentAudit.AuditID %>
            </td>
             <td>
                <%=currentAudit.UserID%>
            </td>
             <td>
                <%=currentAudit.Username %>
            </td>
               <td>
                <%=currentAudit.Date %>
            </td>
             <td>
                <%=currentAudit.Tablename %>
            </td>
             <td>
                <%=currentAudit.Attribute%>
            </td>
            
             <td>
                <%=currentAudit.Access %>
            </td>
        </tr>
        <%} %>
    </table>
<form action="../Audit">
<input type="submit" value="back">
</form>
</asp:Content>
