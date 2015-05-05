<%--Name of Artifact: UC3
    Programmers Name: Daniel Gonzalez
    Date of Code: 04/27/2015
    Date of Approval: 04/29/2015  
    SQA Name:Linh Tong--%>


<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterUserPage.master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="System.Web.Mvc.Html" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Surgeon</h2>
         
        <div class="container-fluid">
            <asp:Hyperlink id="AnonymizeLink" runat="server" 
            NavigateUrl="http://www.dclunie.com/pixelmed/software/webstart/DicomCleaner.html"
            Text="To anonymize data click HERE" BackColor= "#CCFFCC" Font-Names="Aharoni" 
                ForeColor="Black" /> <br /><br />

            <asp:Hyperlink id="InstructionsLink" runat="server" 
                NavigateUrl="http://www.dclunie.com/pixelmed/software/webstart/DicomCleanerUsage.html"
                Text="Instructions on how to use the anonymization tool can be found HERE" BackColor= "#CCFFCC" Font-Names="Aharoni" ForeColor="Black" />
        </div>
        <h2>Upload Anonymized ZIP Below:</h2>
        <label>Upload Anonymized zip </label>

        
       <%  using (Html.BeginForm("Index", "Surgeon", FormMethod.Post, new { enctype = "multipart/form-data" })) %>
       <% { %>
    <br />
    <br />
    <h2>Visualize</h2>
            <div>
            <asp:Hyperlink id="VisualizeLink" runat="server" 
            NavigateUrl="http://sourceforge.net/projects/mito/files/latest/download"
            Text="To visualize the DICOM CLICK HERE" BackColor= "#CCFFCC" Font-Names="Aharoni" 
            ForeColor="Black"/>
            </div>
    <h2> Choose Anonymized Zip File: </h2>
    <input type="file" name="file" style="font-size: large" /> <br />
        Select OK when ready to upload: 
    <input type="submit" value="OK" style="font-size: large" /> <br />
        <% } %>
         <h3>Choose Anonymized Zip File: </h3> 
        <%: Html.ActionLink("Data Analysis Input Form", "SurgeonDataAnalysisInputForm", "Surgeon",new{@style="color:#2b1faa"}) %>

</asp:Content>








