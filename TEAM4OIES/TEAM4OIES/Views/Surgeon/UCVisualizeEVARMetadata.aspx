<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	UCVisualizeEVARMetadata
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>UCVisualizeEVARMetadata</h2>
    
    <div id="dicomImage" style="width:512px;height:512px;">
    <script type="text/javascript">
        $(document).ready(function ()
        {
            var imageId = 'example://1';
            var element = document.getElementById('dicomImage');
            cornerstone.enable(element);
            cornerstone.loadImage(imageId).then(function (image)
            {
                cornerstone.displayImage(element, image);
            });
        });
    </script>
    </div>
</asp:Content>
