<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<script runat="server">

    protected void btnUpload_Click(object sender, EventArgs e)
    {

    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	﻿<!--Name of Artifact: UC7
    Programmers Name: Jainesh Mehta
    Date of Code: 04/27/2015
    Date of Approval:  April 29 2015
    SQA Name:Paul Miller-->
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
        <form action="/ReadDICOM/Submit" method=post>
    </br>
    <input type="file" id="ctrl" webkitdirectory directory multiple/>
    <input type=submit value="Submit" /><br/>
    <br />
    </form>
   

 </asp:Content>
