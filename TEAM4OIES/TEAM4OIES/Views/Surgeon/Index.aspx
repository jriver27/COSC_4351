<%--Name of Artifact: UC3
    Programmers Name: Daniel Gonzalez
    Date of Code: 04/27/2015
    Date of Approval:
    SQA Name:--%>


<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="System.Web.Mvc.Html" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Surgeon</h2>
         
        <div class="rightColumn">
            <asp:Hyperlink id="AnonymizeLink" runat="server" 
            NavigateUrl="http://www.dclunie.com/pixelmed/software/webstart/DicomCleaner.html"
            Text="To anonymize data click HERE" BackColor= "#CCFFCC" Font-Names="Aharoni" 
                ForeColor="Black" /> <br /><br />

        <asp:Hyperlink id="InstructionsLink" runat="server" 
            NavigateUrl="http://www.dclunie.com/pixelmed/software/webstart/DicomCleanerUsage.html"
            Text="Instructions on how to use the anonymization tool can be found HERE" BackColor= "#CCFFCC" Font-Names="Aharoni" ForeColor="Black" />
        
         <%--<%@ CodeBehind="Index.aspx.cs" Inherits="TEAM4OIES.Views.Surgeon.Index"{
          ((SurgeonController)this.ViewContext.Controller).AddPatient()};%>--%>
        </div>
        
       <%-- <% Html.RenderPartial("~/Views/Surgeon/Patients.ascx");%>--%>
        Upload Anonymized ZIP Below:</p> <br />
        <label>Upload Anonymized zip </label>

        
       <%  using (Html.BeginForm("Index", "Surgeon", FormMethod.Post, new { enctype = "multipart/form-data" })) %>
       <% { %>
    <p style="font-size: large"> Choose Anonymized Zip File: </p>
    <input type="file" name="file" style="font-size: large" /> <br />
        Select OK when ready to upload: 
    <input type="submit" value="OK" style="font-size: large" /> <br />
        <% } %>
        <%: Html.ActionLink("Data Analysis Input Form", "SurgeonDataAnalysisInputForm", "Surgeon",new{@style="color:#2b1faa"}) %>

</asp:Content>








