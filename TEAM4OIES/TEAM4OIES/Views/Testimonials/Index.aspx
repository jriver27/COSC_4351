<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Testimonials
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Testimonials</h2>
   <p>If you would like to add your testimonial, please click <a href="/Testimonials/Create">here!</a></p>
    <!DOCTYPE html>
  
    <form action="/Testimonials/Search" method="post">
    <input type="search" name="searchText" value="Search testimonials..." style="width: 200px"/>
    <input type="submit" name="searchButton" value="Search" />
    </form><br />

</td><td valign=top width=99 style="padding-top:3px;"><g:plusone size="medium"></g:plusone></td>
</tr>
   
 
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
<%foreach (var currentTest in (ViewData["testimonials"] as IEnumerable<object>)) 
  {%>
  <tr>
    <td>
       <% =currentTest.ToString()%>
    </td>
    <td>
       
    </td>
    <td>
      
    </td>
    <td>
       
    </td>

</tr>
<%} %>
</table>


	  
</asp:Content>
