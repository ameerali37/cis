<%@ Page Language="C#" AutoEventWireup="true" CodeFile="onlineexam1.aspx.cs" Inherits="onlineexam1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style4
        {
            width: 89px;
            height: 130px;
        }
        .style9
        {
            height: 130px;
            width: 371px;
        }
        .style5
        {
            height: 130px;
        }
        .style3
        {
            width: 89px;
        }
        .style10
        {
            width: 371px;
        }
        .style1
        {
            width: 100%;
        }
        </style>
     <meta http-equiv="refresh" content="10" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table class="style1">
        <tr>
            <td class="style4">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style9">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style5">
                <asp:Timer ID="Timer1" runat="server">
                </asp:Timer>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style10">
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="OPtion" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style10">
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="OPtion" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style10">
                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="OPtion" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style10">
                <asp:RadioButton ID="RadioButton4" runat="server" GroupName="OPtion" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Next" 
                    Width="81px" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
