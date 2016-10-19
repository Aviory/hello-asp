<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UI.aspx.cs" Inherits="HelloASP.NET.UI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="rp" runat="server">
            <HeaderTemplate>
                id&nbsp;fname&nbsp;lname&nbsp;age
            </HeaderTemplate>
            <ItemTemplate>
                <br/>
                <div style="background-color:lightblue">
                    <%# Eval("id") %>&nbsp;&nbsp;&nbsp;<%# Eval("fname") %>&nbsp;&nbsp;&nbsp;&nbsp;
                    <%# Eval("lname") %>&nbsp;&nbsp;&nbsp;<%# Eval("age") %></div><hr />
            </ItemTemplate>
        </asp:Repeater>
        <br />
        <br />
    </div>
        <asp:TextBox ID="tbId" runat="server">1</asp:TextBox>
        <asp:TextBox ID="tbFname" runat="server">1</asp:TextBox>
        <asp:TextBox ID="tbLName" runat="server">1</asp:TextBox>
        <asp:TextBox ID="tbAge" runat="server">1</asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox1" runat="server" OnTextChanged="SelectDB" >
                <asp:ListItem>Mock</asp:ListItem>
                <asp:ListItem>MS_SQL</asp:ListItem>
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        <asp:Button ID="btnRefresh" runat="server" OnClick="btnRefreshs" Text="refresh" Width="57px" style="height: 26px" />
        <br />
        <br />
        <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="create" Width="57px" />
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="update" OnClick="btnUpdate_Click" />
        <br />
        <asp:Button ID="btnDelite" runat="server" Text="delite" Width="57px" OnClick="btnDelite_Click" />
        <br />
    </form>
</body>
</html>
