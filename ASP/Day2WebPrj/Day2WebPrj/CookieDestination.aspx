<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieDestination.aspx.cs" Inherits="Day2WebPrj.CookieDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="GetData" runat="server" OnClick="GetData_Click" Text="GetData" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
