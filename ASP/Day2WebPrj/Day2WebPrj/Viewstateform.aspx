<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewstateform.aspx.cs" Inherits="Day2WebPrj.Viewstateform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <asp:Label ID="Label1" runat="server" Text="User Name :"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
           <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Store" runat="server" Text="Store" OnClick="Store_Click" />
            <asp:Button ID="Load" runat="server" Text="Load" OnClick="Load_Click" />
            <br />
            <br />
        </div>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
