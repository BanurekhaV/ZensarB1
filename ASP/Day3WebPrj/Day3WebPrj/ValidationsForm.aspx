<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationsForm.aspx.cs" Inherits="Day3WebPrj.ValidationsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align:center">Registration Form</h2>
           User Name :&nbsp; <asp:TextBox ID="Uname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Cannot Be Blank" ForeColor="Red" ControlToValidate="Uname" ValidationGroup="Regn">*</asp:RequiredFieldValidator>
            <br />
           Password : &nbsp;<asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Password" ControlToValidate="Password" ForeColor="Red" ValidationGroup="Regn">*</asp:RequiredFieldValidator>
            <br />
           Confirm password :  <asp:TextBox ID="ConfirmPswd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Does Not Match" ControlToCompare="Password" ControlToValidate="ConfirmPswd" ForeColor="Red" ValidationGroup="Regn">*</asp:CompareValidator>
            <br />
           Age : <asp:TextBox ID="Age" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age has to be between 21 and 55" ControlToValidate="Age" ForeColor="Red" MaximumValue="55" MinimumValue="21" Type="Integer" ValidationGroup="Regn">*</asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Age" ErrorMessage="Age is must" ForeColor="Red" ValidationGroup="Regn">*</asp:RequiredFieldValidator>
            <br />
           Email : <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter Email in the Correct Format" ControlToValidate="Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Regn">*</asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Email" ErrorMessage="Enter Email" ForeColor="Red" ValidationGroup="Regn">*</asp:RequiredFieldValidator>
            <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" ValidationGroup="Regn" />
        </div>
        
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="Regn" />
        <div>
            <h2 style="text-align:center">Login Form</h2>
           Login Name : <asp:TextBox ID="Loginname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Loginname" ErrorMessage="Enter Login" ForeColor="Red" ValidationGroup="Login">*</asp:RequiredFieldValidator>
            <br />
            <br />
           Password : <asp:TextBox ID="psswd" runat="server"></asp:TextBox>
           
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="psswd" ErrorMessage="Password Must" ForeColor="Red" ValidationGroup="Login">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="LoginBtn" runat="server" Text="Login" ValidationGroup="Login" />
           
        </div>
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="Login" />
    </form>
</body>
</html>
