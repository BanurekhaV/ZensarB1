<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      Enter your Name : <asp:TextBox ID="txtName" runat="server" /><br />
       Enter a Number to find the Square <asp:TextBox ID="txtnumber" runat="server" />
        <br /><br />
        <asp:Button ID="msgbtn" Text="For Message" OnClick="msgbtn_click" runat="server" />
        <asp:Button ID="sqbtn" Text="For Square" OnClick="sqbtn_click" runat="server" /><br /><br />

        <asp:Label ID="Label1" runat="server" ></asp:Label>
    </form>
</body>
</html>
