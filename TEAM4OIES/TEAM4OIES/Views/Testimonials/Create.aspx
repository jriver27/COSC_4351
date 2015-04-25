<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Add Testimonial</h2>
    <html>
   <head>
   
   </head>
   <body>
<%--    <% using (Html.BeginForm("Testimonials","Testimonials"))
    {%>
        Name <%= Html.TextBox("name") %> <br />
        Comments : <%= Html.TextBox("comments") %> <br />        
        <input type="submit" name="submit" value="Submit" />
    <%}%>
--%>


   <form action="/Testimonials" name="add" method="post" runat="server" id="testimonial">

   <p>
   <div class="editor-label"><b>Name:</b></div>
   <div class ="editor-field">
   <input type="text" name="name" id="name" style="width: 200px" runat="server"/>
   </div>
   </p>

   <p>
   <div class="editor-label"><b>Comments:</b></div>
   <div class="editor-field">
   <textarea id="comments" name="comments" rows="6" cols="55"></textarea>
   </div>
   </p>

    <p>
    <input type="submit" id="buttonTest" name="buttonTest" runat="server" value="Submit"/></p>
    </form>  


    <%--<input type="submit" value="Submit" onclick="alert('Your testimonial has been submitted successfully!')"/></p>--%>
    
    <%--<script language="javascript" type="text/javascript">
        function showMessage() {
            alert('Your testimonial has been submitted successfully!');
        }</script>
--%>
	   </body>
   </html>
</asp:Content>
