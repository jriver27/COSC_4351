<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterUserPage.master" 
Inherits="System.Web.Mvc.ViewPage<TEAM4OIES.Models.DataAnalysisModel>" 
%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	SurgeonDataAnalysisInputForm
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Surgeon Data Analysis Input Form</h2>
    
    <div class="container">
        <form id="savePatientinfoForm"  class="pull-left" runat="server">
            <div class="container">
                <%--PAUL TAKE A LOOK HERE 
                *********************--%>
                <div class="pull-right">
                    <form action="" method="post">
                        <label>Enter Patient id<input type="number"/></label>
                        <input type="submit" name="inputPatientIdButton" value="GetCtScans" />
                    </form>
                </div>
                <%--PAUL TAKE A LOOK HERE 
                *********************--%>
                <br/>
                <div class="container">
                    <label>Patient Number<input name="DataAnalysisModel.PatientNumber"/></label>
                    <label>Patient D.O.B.<input name="DataAnalysisModel.PatientDOB"/> </label><label>Sex  <input name="DataAnalysisModel.Sex"/></label>
                    <label>Patient Age<input name="DataAnalysisModel.Age"/></label>
                    
                    <label>Date Of Surgery<input name="DataAnalysisModel.DateOfSurgery"/></label><label>Graft Manufacturer<input name="DataAnalysisModel.GraftManufacturer"/></label>
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
                    <label>CT Scan Date<input name="DataAnalysisModel.CtScan"/></label>
                    <label>CT Id<input name="DataAnalysisModel.CTid"/></label>
                    <label>Delay<input name="DataAnalysisModel.Delay"/></label>
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
                    <label>Total # of Slices <input name="DataAnalysisModel.NumOfSlices"/></label> <label>Thickness <input name="DataAnalysisModel.Thickness"/></label><label>Pixel Size<input name="DataAnalysisModel.PixelSize"/></label>
                    <label>ROI begin<input type="number" value=""/></label><label>Iliac Bif<input name=""/></label><label>ROI end<input type="number" value=""/></label>
                    <label>Total Slices in ROI<input type="number" value=""/></label><label>Length ROI(cm)<input type="number" value=""/></label><label>Comments<input name=""/></label>
                </div>
                <asp:Button ID="btnSavePatientInfo" Text="Save Patient Info" BorderColor="Blue" BorderStyle="Solid" BorderWidth="5px"  runat="server"/>
            </div>
        </form>
    </div>

</asp:Content>
