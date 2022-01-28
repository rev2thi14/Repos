<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="DF.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>login</title>login
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="userid"></asp:Label>
            <asp:TextBox ID="txtuserid" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
            </table>
             <hr />
           <table>
            <h2>Admin </h2>
            <asp:GridView ID="gvAdmin" runat="server"></asp:GridView>
            
            <h2>new register </h2>
            <asp:GridView ID="gvnewregister" runat="server"></asp:GridView>
            </table>
        </div>
    </form>
</body>
</html>
