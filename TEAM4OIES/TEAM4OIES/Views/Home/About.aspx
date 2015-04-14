<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    About Us
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 >About</h2>
    <p>
        Welcome to the EVAR Team Project for Team 4, where our number one goal is to

        abide by HIPAA reulations. HIPAA is maintained by ALWAYS anonymizing patient name and date of birth. Within our website is a large variety of resources and data that is used to

        store, manage, visualize, and query EVAR (EndoVascular Aneurysm Repair) data (in the form of medical images), metadata, segmentations (2D or 3D reconstruction of the "raw" medical images), CFD (Computational Fluid Dynamics) simulations, etc.
        To become our valued member, click register to start today! 
    </p>
  <asp:Image id="Image1" runat="server"
           AlternateText="Image text"
           ImageAlign="AbsMiddle"
            Width="564"  
            Height="423" 
           ImageUrl="http://i.imgur.com/wmUbdrg.png"/>

</asp:Content>
