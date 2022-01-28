<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Application.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="EmailId"></asp:Label>
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>


            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtpwd" Textmode="Password" runat="server"></asp:TextBox>

            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />

            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Register</asp:HyperLink>

            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>

    </form>
</body>
</html>
