<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

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
            width: 191px;
        }
        .style3
        {
            width: 328px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="Register number"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox1" runat="server" Width="208px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Check" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="205px" 
                    ontextchanged="TextBox2_TextChanged"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label6" runat="server" Text="Age"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox6" runat="server" Width="202px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label3" runat="server" Text="Department"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox3" runat="server" Width="204px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label4" runat="server" Text="Username"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox4" runat="server" Width="206px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox5" runat="server" Width="208px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                image</td>
            <td class="style3">
                <asp:FileUpload ID="FileUpload2" runat="server" />
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
                <asp:Button ID="Button1" runat="server" Text="Ok" onclick="Button1_Click" />
            </td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
