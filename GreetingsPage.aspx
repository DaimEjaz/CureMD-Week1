<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GreetingsPage.aspx.cs" Inherits="LoginForm.GreetingsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="greeting" runat="server"></h1>
            <asp:Label runat="server" ID="logout" >Click the button below to log-out the session</asp:Label>
            <asp:Button runat="server" ID="logoutBtn" Text="Logout" OnClick="Logout"/>
        </div>
    </form>
</body>
</html>
