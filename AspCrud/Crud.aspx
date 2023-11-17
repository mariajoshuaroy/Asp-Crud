<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Crud.aspx.cs" Inherits="AspCrud.Crud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_logout" runat="server" Text="Logout" OnClick="btn_logout_Click" />
        </div>
        <br />
        <br />
        <br />
        <br />
        <div>
            &nbsp&nbsp&nbsp<asp:Label ID="Label4" runat="server" Text="Create"></asp:Label><br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Id"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Degree"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="txt_degree" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Place"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="txt_place" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_create" runat="server" Text="Create" OnClick="btn_create_Click" />&nbsp&nbsp<asp:Button ID="btn_clear" runat="server" Text="Clear" OnClick="btn_clear_Click" />
            <br /><br />
            <asp:Button ID="btn_update" runat="server" Text="Update" OnClick="btn_update_Click" />&nbsp&nbsp<asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
        </div>
        <br />
        <br />
        <br />
        <br />
       
        <div>

            <asp:GridView ID="gv_select" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gv_select_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Degree" HeaderText="Degree" SortExpression="Degree" />
                    <asp:BoundField DataField="Place" HeaderText="Place" SortExpression="Place" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Select Row" ShowHeader="True" Text="Select" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
