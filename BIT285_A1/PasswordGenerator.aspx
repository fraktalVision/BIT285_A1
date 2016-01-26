<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordGenerator.aspx.cs" Inherits="BIT285_A1.PasswordGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Automatic Password Generator</h1>
            <p>
                Having a hard time coming up with a new password?<br />
                Enter your information below to automatically generate a password!
            </p>

            <asp:Table runat="server" ID="info">
                <asp:TableRow>
                    <asp:TableCell>
                    <asp:Label runat="server" Text="Last Name:"/>
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox runat="server" ID="lastName" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                    <asp:Label runat="server" Text="Birth Year:"/>
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox runat="server" ID="birthYear" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                    <asp:Label runat="server" Text="Favorite Color:"/>
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox runat="server" ID="favColor" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />

            <asp:Button runat="server" ID="suggest" Text="Suggest Passwords >>>" OnClick="suggest_Click" />
            
            <asp:DropDownList runat="server" ID="passwords">
                <asp:ListItem>Possible Passwords</asp:ListItem>
            </asp:DropDownList>
            <br/>

            <asp:Label runat="server" ID="test" Text=""/>
        </div>
    </form>
</body>
</html>
