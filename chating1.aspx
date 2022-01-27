<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chating1.aspx.cs" Inherits="chating1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="Red" 
        Text="Chating"></asp:Label>
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None" 
        onrowcommand="GridView1_RowCommand">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:ButtonField CommandName="select" Text="Select" />
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="name" HeaderText="User Name" />
        </Columns>
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <br />
    <br />
    &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" 
        PostBackUrl="~/chating2.aspx" onclick="LinkButton1_Click">Start ChatingStart Chating</asp:LinkButton>
    </form>
</body>
</html>
