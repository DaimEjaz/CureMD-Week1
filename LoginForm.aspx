<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="LoginForm.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="nameLabel">Enter your username: </asp:Label>
            <asp:TextBox runat="server" ID="username"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="passLabel">Enter you password: </asp:Label>
            <asp:TextBox runat="server" ID="password"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="loginBtn" Text="Login" OnClick="Login"/>

            <p runat="server" id="lol"></p>

        </div>
    </form>
</body>
</html>
