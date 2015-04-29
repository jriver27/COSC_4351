<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Testimonials
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Testimonials</h2>
    <!DOCTYPE html>
   <html>
   <head>
</td><td valign=top width=99 style="padding-top:3px;"><g:plusone size="medium"></g:plusone></td>
</tr>
   </head>
   <body>
    <label>Search Testimonials:</label><br />
    <p>
    <form action="/Testimonials/Search" method="post">
        <input type="search" name="searchText" value="" style="width: 200px"/>
        <input type="submit" name="searchButton" value="Search" />
    </form><br />
    </p>
    
    <label>Add Testimonials:</label><br />
    <form action="/Testimonials/Create" name="add" method="post" runat="server" id="testimonial">

   <p>
   <div class="editor-label">Comments:</div>
   <div class="editor-field">
   <textarea id="comments" name="comments" rows="6" cols="55"></textarea>
   </div>
   </p>

    <p>
    <input type="submit" id="buttonTest" name="buttonTest" runat="server" value="Submit"/></p>
    </form>  

    </body>
   </html>

</asp:Content>
