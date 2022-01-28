<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Application.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>Register</h1>
            <hr />
            <table>
            <asp:Label ID="Label1" runat="server" Text="Firstname"></asp:Label>
            <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>

            <asp:Label ID="Label2" runat="server" Text="Lastname"></asp:Label>
            <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>

            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>

            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtpwd" Textmode="Password" runat="server"></asp:TextBox>

            <asp:Label ID="Label5" runat="server" Text="Mobile"></asp:Label>
            <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>

            <asp:Label ID="Label6" runat="server" Text="Retyp Password"></asp:Label>
            <asp:TextBox ID="txtretypepwd" runat="server"></asp:TextBox>

            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            <asp:Button ID="btnReset" runat="server" Text="Reset" />

             <asp:Label Text="" ID="lblResult" runat="server" />

            <h2>User Details</h2>
                <hr />
                <asp:GridView ID="gvUserInfo" runat="server"></asp:GridView>







             </table >

        </div>
    </form>
</body>
</html>
