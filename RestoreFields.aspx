<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestoreFields.aspx.cs" Inherits="RestoreFields.RestoreFields" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hdnUsername" runat="server" Value="" Visible="false"  ClientIDMode="Static">   </asp:HiddenField>
            <asp:HiddenField ID="hdnPassword" runat="server" Value="" Visible="false"  ClientIDMode="Static">   </asp:HiddenField>

            <asp:Label runat="server" ID="nameLabel" text="Enter your username: "></asp:Label>
            <asp:TextBox runat="server" ID="username"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="passwordLabel" text="Enter your password: "></asp:Label>
            <asp:TextBox runat="server" ID="password"></asp:TextBox>
            <br />

            <asp:Button ID="submitBtn" Text="Submit" runat="server" OnClick="Submit"/>
            <asp:Button ID="viewstateBtn" Text="Restore with View State" runat="server" OnClick="ViewStateRestore"/>
            <asp:Button ID="hiddenFieldBtn" Text="Restore with Hidden Fields" runat="server"  OnClick="HiddenFieldRestore"/>


        </div>
    </form>
    <script>
        let hiddenUsername = document.getElementById('hdnUsername');
        let hiddenPassword = document.getElementById('hdnPassword');

        let username = document.getElementById("username");
        let password = document.getElementById("password");

        hiddenUsername.value = username.innerText;
        hiddenPassword.value = password.innerText;

    </script>
</body>
</html>
