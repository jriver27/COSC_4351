<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Search
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Search Results:</h2>
 <!DOCTYPE html>
   <html>
   <head>
</td><td valign=top width=99 style="padding-top:3px;"><g:plusone size="medium"></g:plusone></td>
</tr>
   </head>
   <body>
 <br />
<table>
<tr>
    <%--<th>
        Testimonial ID
    </th>--%>
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
<%foreach (var keywordTest in (ViewData["search"] as IEnumerable<TEAM4OIES.Models.Testimonials>)) 
  {%>
  <tr>
    <td>
       <% =keywordTest.firstName%>
    </td>
    <td>
       <% =keywordTest.lastName%>
    </td>
    <td>
        <% =keywordTest.content%>
    </td>
    <td>
        <% =keywordTest.tDate%>
    </td>

</tr>
<%} %>
</table>


	   </body>
   </html>

</asp:Content>
