<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<script runat="server">

    protected void btnUpload_Click(object sender, EventArgs e)
    {

    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
   
<% using (Html.BeginForm("FileUpload", "ReadDICOM", 
                    FormMethod.Post, new { enctype = "multipart/form-data" }))
        {%>
        <input name="uploadFile" type="file" />
        <input type="submit" value="Upload File" />
<%} %>
 </asp:Content>
