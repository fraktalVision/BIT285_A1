<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BIT285_A1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Please Login</h1>
            
            <asp:Label runat="server" ID="error" Visible="False" Text="Error Logging In" style="color: red; text-decoration: underline;" />
            <br/>

            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                    <asp:Label runat="server" Text="User Name:"/>
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox runat="server" ID="userName" />
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" Text="Password:"/>
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox runat="server" ID="password" TextMode="Password" />
                    </asp:TableCell></asp:TableRow></asp:Table><asp:HyperLink ID="newAccount" runat="server" Text="need a new account?" NavigateUrl="~/PasswordGenerator.aspx" />
            <br/><br/>
            <asp:Button runat="server" ID="btnLogin" Text="Login" OnClick="btnLogin_Click"/></div>
    </form>
</body>
</html>
