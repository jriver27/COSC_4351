<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterUserPage.master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Patient
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Patient</h2>
    <form id="Form1" runat="server">
        <div class="well">
                <input type="text" id="patientp" name="patientp" />
                <label> Please input Patient ID</label><br/>
                <button type="submit" id="patient submit" value="Submit Patient ID">Retrieve Patient</button>
        </div>
    </form>

</asp:Content>
