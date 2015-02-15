<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    About Us
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>About</h2>
    <p>
        <em>Welcome to COSC 4351 Team Project for Team 4.</em><br/><br/>
        
        <em>Team Project for Dr. Hilford's COSC 4351 Class.</em><br/><br/>

        This semester's Team Project is an international online database system to be used to store, manage, visualize, and <br/>
        query EVAR (EndoVascular Aneurysm Repair) data (in the form of medical images), metadata, segmentations (2D or 3D reconstruction <br/>
        of the "raw" medical images), CFD (Computational Fluid Dynamics) simulations,<br/> 
        etc. It will become the largest such system in the world.<br/>
    </p>
</asp:Content>
