<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="TEAM4OIES.RegisterForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 40%;
        }
        .style2
        {
            width: 114px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="style1" align="center">
            <tr>
                <td class="style2">
                    First Name:</td>
                <td>
                    <asp:TextBox ID="firstName" runat="server" Width="190px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Last Name:</td>
                <td>
                    <asp:TextBox ID="lastName" runat="server" Width="190px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Username:</td>
                <td>
                    <asp:TextBox ID="username" runat="server" Width="190px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Institution:</td>
                <td>
                    <asp:TextBox ID="institution" runat="server" Width="190px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Email:</td>
                <td>
                    <asp:TextBox ID="email" runat="server" Width="190px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Password:</td>
                <td>
                    <asp:TextBox ID="password" runat="server" Width="190px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="registerButton" runat="server" onclick="Button1_Click" 
                        Text="Register" Width="190px" />
    <asp:Label ID="Label1" runat="server" ForeColor="Green" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:TEAM4OIESConnectionString %>" 
                        InsertCommand=" INSERT INTO Surgeon(firstName, lastName, username, institution, email, password) " 
                        ProviderName="<%$ ConnectionStrings:TEAM4OIESConnectionString.ProviderName %>" 
                        SelectCommand="SELECT firstName, lastName, userName, institution, email, password FROM Surgeon">
                    </asp:SqlDataSource>
    
    </form>
</body>
</html>
