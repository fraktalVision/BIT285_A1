<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewAccount.aspx.cs" Inherits="BIT285_A1.NewAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
        // updates the requiredfieldvalidator based on the checkbox's state
        function Update()
        {
            var enable = event.srcElement.checked;
            var validator = document.getElementById('emailValidator');
            ValidatorEnable(validator, enable);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>New Account Information</h1>

            <asp:Table runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                    <asp:Label runat="server" Text="First Name"/>&nbsp;
                    </asp:TableCell><asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="firstName" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="firstName" Text="*required" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                    <asp:Label runat="server" Text="Last Name"/> &nbsp;
                    </asp:TableCell><asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="lastName" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="lastName" Text="*required" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                    <asp:Label runat="server" Text="Email Address"/> &nbsp;
                    </asp:TableCell><asp:TableCell runat="server">
                        <asp:TextBox runat="server" ID="email" />
                        <asp:RequiredFieldValidator runat="server" ID="emailValidator" ControlToValidate="email" Text="*required"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                    <asp:Label runat="server" Text="Program Option"/> &nbsp;&nbsp;&nbsp;
                    </asp:TableCell><asp:TableCell runat="server">
                        <asp:DropDownList runat="server" ID="programs">
                            <asp:ListItem>Web Developer Degree</asp:ListItem>
                            <asp:ListItem>ETSP Degree</asp:ListItem>
                            <asp:ListItem>Network Technology Degree</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                    &nbsp;
                    </asp:TableCell><asp:TableCell runat="server">
                        <asp:CheckBox runat="server" ID="sendEmails" Text="email me program updates" OnClick="Update();"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            <asp:Button runat="server" ID="create" Text="create account" OnClick="create_Click" />&nbsp;
            <asp:Button runat="server" ID="reset" Text="reset" OnClick="reset_Click" />
        </div>
    </form>
</body>
</html>
