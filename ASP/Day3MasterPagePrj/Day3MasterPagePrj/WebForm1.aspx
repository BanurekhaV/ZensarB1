<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Day3MasterPagePrj.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentplaceholder" runat="server">
    <h1>My First content<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
</h1>
<p>&nbsp;</p>
</asp:Content>
