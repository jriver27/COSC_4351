<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<nav class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <a class="navbar-brand" href="../Home/Index">TEAM4OIES </a>
                <a class="navbar-brand" href="../Home/About">About</a>  
                <a class="navbar-brand" href="../Testimonials">Testimonials</a> 
            </div>
            <div id="navbar" class="navbar-collapse collapse">
                <form class="navbar-form navbar-right" action ="" method="post" name="loginform">
                    <div class="form-group">
                    <input class="form-control" type="text" placeholder="Username"  name="username" id="username">
                    </div>
                    <div class="form-group">
                    <input class="form-control" type="password" placeholder="Password" name="password" id="password">
                    </div>
                    <button class="btn btn-success" type="submit">Sign in</button>
                </form>
            </div>
        </div>
    </nav>
    <div class="jumbotron">
        <div class="container">
            <h1>TEAM4OIES</h1>
            <p>Please Log into your account</p>
            <p>
            </p>
        </div>
    </div>

</asp:Content>
