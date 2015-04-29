<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterUserPage.master" Inherits="System.Web.Mvc.ViewPage<TEAM4OIES.Models.PatientModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	PatientInfoActionResult
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>PatientInfoActionResult</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">PatienId</div>
        <div class="display-field"><%: Model.PatienId %></div>
        
        <div class="display-label">SurgeryDate</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.SurgeryDate) %></div>
        
        <div class="display-label">PatientNumber</div>
        <div class="display-field"><%: Model.PatientNumber %></div>
        
        <div class="display-label">PatientDOB</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.PatientDOB) %></div>
        
        <div class="display-label">Sex</div>
        <div class="display-field"><%: Model.Sex %></div>
        
        <div class="display-label">Age</div>
        <div class="display-field"><%: Model.Age %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

