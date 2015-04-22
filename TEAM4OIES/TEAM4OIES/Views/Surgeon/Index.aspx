<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Surgeon</h2>

    <p> To anonymize data click 

        <asp:Hyperlink id="AnonymizeLink" runat="server" 
        NavigateUrl="http://www.dclunie.com/pixelmed/software/webstart/DicomCleaner.html"
        Text="HERE" BackColor= "#0000FF" /> <br /><br />
        Instructions on how to use the anonymization tool can be found 
        <asp:Hyperlink id="InstructionsLink" runat="server" 
        NavigateUrl="http://www.dclunie.com/pixelmed/software/webstart/DicomCleanerUsage.html"
        Text="HERE" BackColor= "#0000FF" />


        Upload Anonymized zip </p>

        
       <%  using (Html.BeginForm("Index", "Surgeon", FormMethod.Post, new { enctype = "multipart/form-data" })) %>
<% { %>
    <input type="file" name="file" />
    <input type="submit" value="OK" />
<% } %>

</asp:Content>








