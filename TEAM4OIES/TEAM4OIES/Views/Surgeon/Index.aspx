<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Surgeon</h2>

    <asp:Hyperlink id="AnonymizeLink" runat="server" 
        NavigateUrl="http://www.dclunie.com/pixelmed/software/webstart/DicomCleaner.html"
        Text="Anonymize :)" BackColor= "#0000FF" />

</asp:Content>
