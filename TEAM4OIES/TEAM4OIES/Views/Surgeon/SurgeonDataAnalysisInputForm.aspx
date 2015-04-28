<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	SurgeonDataAnalysisInputForm
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Surgeon Data Analysis Input Form</h2>
    
    <div class="pull-right">
        <form class="form-group">
            <div class="pull-right">
                <label>Request Patient from Database<input type="text"/></label>
            </div>
            <div class="container">
                <label>Patient Number<input type="text" value=""/></label>
                <label>Patient D.O.B.<input type="datetime" value=""/></label><label>Sex<input type="text" value=""/></label>
                <label>Patient Age<input type="number" value=""/></label>
            </div>
            <div class="container, input-group">
                // Box of CT Scans goes here
                // User selects one
            </div>
            
            <div class="container">
                <label>CT Scan Date<input type="date" value=""/></label>
                <label>CT Id<input type="text" value=""/></label>
                <label>Delay<input type="text" value=""/></label>
            </div>
           
            <div class="container">
                // Box of CT Series goes here
                // User selects one
            </div>
            
            <div class="container">
                //Total # of slices // Thickness // sllice
                // ROI begins   // Iliac Bif   // ROI ends
                
                // Total sent in ROI    // Lenght ROI       //sometihing

            </div>
            <button class="pull-right">
                Submit
            </button>
        </form>
    </div>

</asp:Content>
