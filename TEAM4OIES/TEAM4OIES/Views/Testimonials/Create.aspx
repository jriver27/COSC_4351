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
   <form action="submit/" method="post" id="testimonial">

   <p>
   <div class="editor-label"><b>Name:</b></div>
   <div class ="editor-field">
   <input type=text name="name" id="name" style="width: 200px"/>
   </div>
   </p>

   <p>
   <div class="editor-label"><b>Email:</b></div>
   <div class ="editor-field">
   <input type=text name="email" id="email" style="width: 200px"/>
   </div>
   </p>

   <p>
   <div class="editor-label"><b>Comments:</b></div>
   <div class="editor-field">
   <textarea name="comment" rows="6" cols="55" id="comments"></textarea>
   </div>
   </p>

    <p>
    <input type="submit" value="Submit" /></p>
    </form>


	   </body>
   </html>
</asp:Content>
