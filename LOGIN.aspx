<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LOGIN.aspx.cs" Inherits="LOGIN" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 118px;
        }
        .style3
        {
            width: 203px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="User name"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox1" runat="server" Width="188px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="187px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
    
        <asp:Button ID="Button1" runat="server" Text="login" onclick="Button1_Click" 
                    Width="79px" />
    
            </td>
            <td class="style3">
                <asp:Button ID="Button2" runat="server" PostBackUrl="~/register.aspx" 
                    Text="Register" Width="87px" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" PostBackUrl="~/Default.aspx" 
                    Text="View" Width="75px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
    
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
    
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
