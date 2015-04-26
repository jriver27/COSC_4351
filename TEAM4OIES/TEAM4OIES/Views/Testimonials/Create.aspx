
<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<TEAM4OIES.Models.Testimonials>>" %>
<%--Inherits="System.Web.Mvc.ViewPage<dynamic>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Testimonials</h2>
    <html>
    <head>
</td><td valign=top width=99 style="padding-top:3px;"><g:plusone size="medium"></g:plusone></td>
</tr>
   </head>
   <body>
   <table>
   <col width="130" />
   <col width="130" />
   <col width="250" />
   <col width="200" />
<tr>
    <th>
        First Name
    </th>
    <th>
        Last Name
    </th>
    <th>
        Comments
    </th>
    <th>
        Date
    </th>
</tr>
<%foreach (var currentVar in Model)
  {%>
  <tr>
    <td>
       <% =currentVar.firstName%>
    </td>
    <td>
       <% =currentVar.lastName%>
    </td>
    <td>
        <% =currentVar.content%>
    </td>
    <td>
        <% =currentVar.tDate%>
    </td>
</tr>
<%} %>
</table><br />
<form action="../Testimonials">
<input type="submit" value="Go Back">
</form>
	   </body>
   </html>
</asp:Content>