<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IntroForm.aspx.cs" Inherits="Day1WebPrj.IntroForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 118px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server">Enter Name:</asp:Label>&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" />
           
            </div>
    </form>
</body>
</html>
&nbsp;