<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SampleASPNetApp._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>ASP AWS Demo Application - Ver 1.05</h1>
        <p class="lead">Demo application that is used for showcasing CI/CD automation in AWS.</p>
        <p>Page last updated: <%= this.CurrentDateTime %></p>
        <p>Retrieving page from server: <%=HttpContext.Current.Server.MachineName %></p>
    </div>
</asp:Content>
