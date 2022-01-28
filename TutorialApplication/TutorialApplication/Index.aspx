<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TutorialApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tutorial Apllication</title>
    Tutorial Application
</head>
<body>
    <form id="form1" runat="server">
        <div> style="background-color:aqua;">
            <asp:Label ID="Label1" runat="server" Text="Tutorial Id"></asp:Label>
            <asp:TextBox ID="txtTutorialId" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="Tutorial Name"></asp:Label>
            <asp:TextBox ID="txtTutorialName" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtTutorialDesc" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label4" runat="server" Text="Published"></asp:Label>
            <asp:TextBox ID="txtPublished" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"/>
            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            <hr />
            <h2>Tutorial Details</h2>
            <asp:GridView ID="gvTutorialDetails" runat="server"></asp:GridView>
        </div>
        
    </form>
</body>
</html>
