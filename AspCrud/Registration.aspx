<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="AspCrud.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Mobile"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="txt_mobile" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>&nbsp&nbsp
            <asp:RadioButton ID="rb_gender" runat="server" Text="Male" GroupName="gender"/>&nbsp
            <asp:RadioButton ID="rb_gender1" Text="Female" runat="server" GroupName="gender" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Username"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_submit" runat="server" Text="Submit" OnClick="btn_submit_Click" />&nbsp&nbsp<asp:Button ID="btn_Login" runat="server" Text="Login" OnClick="btn_Login_Click" />
        </div>
    </form>
</body>
</html>
