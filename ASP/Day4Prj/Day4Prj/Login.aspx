<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Day4Prj.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <h3>Login Form</h3>
        <table>
            <tr>
                <td>UserName:</td>
                <td>
                    <asp:TextBox ID="UserName" runat="server" />
                </td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                    ControlToValidate="UserName" ErrorMessage="Name Cannot Be Empty"
                    runat="server"></asp:RequiredFieldValidator></td>
            </tr> 
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="Password" TextMode="Password" runat="server" /></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                    ControlToValidate="Password" ErrorMessage="Enter Password "
                    runat="server" /></td>
            </tr>
            <tr>
                <td>
                    Remember ?
                </td>
                <td><asp:CheckBox ID="RememberChk" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="SubmitBtn" OnClick="Login_click" Text="Log In" runat="server" /></td>
            </tr>
        </table>
        <p>
            <asp:Label ID="Display" ForeColor="Red" runat="server" />
        </p>
    </form>
</body>
</html>
