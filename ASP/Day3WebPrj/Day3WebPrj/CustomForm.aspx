<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomForm.aspx.cs" Inherits="Day3WebPrj.CustomForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" lang="Javascript">
        function IsEven(source, args) {
            if (args.Value == '') {
                args.IsValid = false;
            }
            else {
                if (args.Value % 2 == 0) {
                    args.IsValid = true;
                }
                else { args.IsValid = false; }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           Please Enter a Positive Even Number : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="IsEven" ControlToValidate="TextBox1"
                ErrorMessage="Number has to be Positive and  Even" ForeColor="Red" 
                OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="SaveBtn" runat="server" Text="Save" OnClick="SaveBtn_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
