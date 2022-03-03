<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="postback.aspx.cs" Inherits="Day2WebPrj.postback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="Click to Count" />
            <br />
        </div>
        <p>
            <asp:TextBox ID ="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Get Data" />
    </form>
</body>
</html>
