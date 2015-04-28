<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<TEAM4OIES.Models.Testimonials>>" %>

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
<%foreach (var keywordTest in Model)
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

</table><br />
<form action="../Testimonials">
<input type="submit" value="Go Back">
</form>

	   </body>
   </html>

</asp:Content>
