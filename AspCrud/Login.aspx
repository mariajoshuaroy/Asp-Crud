<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AspCrud.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="LOGIN"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" />&nbsp&nbsp<asp:Button ID="btn_cancel" runat="server" Text="Cancel" OnClick="btn_cancel_Click" />
            <br />
            <br />
            <asp:Button ID="btn_register" runat="server" Text="Register Here" OnClick="btn_register_Click" />
        </div>
    </form>
</body>
</html>
