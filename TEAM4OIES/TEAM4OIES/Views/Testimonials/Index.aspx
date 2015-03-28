<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Testimonials
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Testimonials Page</h2>
    <!DOCTYPE html>
   <html>
   <head>
    <script language="JavaScript">
        var TRange = null;

        function findString(str) {
            if (parseInt(navigator.appVersion) < 4) return;
            var strFound;
            if (window.find) {

                // CODE FOR BROWSERS THAT SUPPORT window.find

                strFound = self.find(str);
                if (!strFound) {
                    strFound = self.find(str, 0, 1);
                    while (self.find(str, 0, 1)) continue;
                }
            }
            else if (navigator.appName.indexOf("Microsoft") != -1) {

                // EXPLORER-SPECIFIC CODE

                if (TRange != null) {
                    TRange.collapse(false);
                    strFound = TRange.findText(str);
                    if (strFound) TRange.select();
                }
                if (TRange == null || strFound == 0) {
                    TRange = self.document.body.createTextRange();
                    strFound = TRange.findText(str);
                    if (strFound) TRange.select();
                }
            }
            else if (navigator.appName == "Opera") {
                alert("Opera browsers not supported, sorry...")
                return;
            }
            if (!strFound) alert("String '" + str + "' not found!")
            return;
        }
    </script> 
    <iframe id="srchform2" 
 src="javascript:'<html><body style=margin:0px; ><form action=\'javascript:void();\' onSubmit=if(this.t1.value!=\'\')parent.findString(this.t1.value);return(false); ><input type=text id=t1 name=t1 value=Text to find... size=20><input type=submit name=b1 value=Search></form></body></html>'" 
 width=350 height=34 border=0 frameborder=0 scrolling=no>
</iframe>
</td><td valign=top width=99 style="padding-top:3px;"><g:plusone size="medium"></g:plusone></td>
</tr>
   </head>
   <body>

   </body>
   </html>

</asp:Content>
