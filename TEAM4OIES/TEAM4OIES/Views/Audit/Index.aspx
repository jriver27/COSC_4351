﻿<%--Name of Artifact: Index.aspx
    Programmers Name: Paul Miller
    Date of Code: 04/27/2015
    Date of Approval:
    SQA Name:--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterUserPage.master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Audit Table
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Audit Table</h2>
<form action="Audit/DispTable" method="POST">
  Date of Audit 
  <input type="date" name="Auditdate" value="Auditdate" />
  <input type="submit" value="Display Table">
</form>
    
</asp:Content>
