<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterUserPage.master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	SurgeonDataAnalysisInputForm
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Surgeon Data Analysis Input Form</h2>
    
    <div class="container">
        <form id="savePatientinfoForm"  class="pull-left" runat="server">
            <div class="container">
                <div class="pull-right">
                    
                   <%-- <label> Enter Paitent id</label>
                    <% using (Html.BeginForm("GetCTScans", "Surgeon")) 
                      { %>
                    <%= Html.TextBox("Id") %>
                    <input type="submit" value="submit"/>
                    <% } %>--%>
                </div>
                <br/>
                <div class="container">
                    <label>Patient Number  <input type="text" value=""/></label>
                    <label>Patient D.O.B.  <input type="date" value=""/> </label><label>Sex  <input type="text" value=""/></label>
                    <label>Patient Age<input type="number" value=""/></label>
                </div>
                <br/>
                <div class="container">
                    <div class="well" style="border: solid">
                    // Box of CT Scans goes here
                    // User selects one

                    </div>
                </div>
                <br/>
                <div class="container">
                    <label>CT Scan Date<input type="date" value=""/></label>
                    <label>CT Id<input type="text" value=""/></label>
                    <label>Delay<input type="text" value=""/></label>
                </div>
                <br/>
                <div class="container">
                    <div class="well" style="border: solid">
                    // Box of CT Series goes here
                    // User selects one
                    </div>
                </div>
                <br/>
                <div class="container">
                    <label>Total # of Slices <input type="text" value=""/></label> <label>Thickness <input type="text" value=""/></label><label>Pixel Size<input type="text" value=""/></label>
                    <label>ROI begin<input type="number" value=""/></label><label>Iliac Bif<input type="text" value=""/></label><label>ROI end<input type="number" value=""/></label>
                    <label>Total Slices in ROI<input type="number" value=""/></label><label>Length ROI(cm)<input type="number" value=""/></label><label>Commentsw<input type="text" value=""/></label>
                </div>
                <asp:Button ID="btnSavePatientInfo" Text="Save Patient Info" BorderColor="Blue" BorderStyle="Solid" BorderWidth="5px"  runat="server"/>
            </div>
        </form>
    </div>

</asp:Content>
