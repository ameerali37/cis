<%@ Page Language="C#" AutoEventWireup="true" CodeFile="student.aspx.cs" Inherits="Default2" %>

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
            width: 211px;
        }
        .style3
        {
            width: 160px;
        }
        .style4
        {
            width: 211px;
            height: 26px;
        }
        .style5
        {
            height: 26px;
        }
        .style6
        {
            width: 160px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="register no:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="176px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="173px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                department</td>
            <td class="style5">
                <asp:TextBox ID="TextBox3" runat="server" Width="175px"></asp:TextBox>
            </td>
            <td class="style5">
                </td>
            <td class="style5">
                </td>
            <td class="style5">
                </td>
            <td class="style6">
                </td>
        </tr>
        <tr>
            <td class="style4">
                semester</td>
            <td class="style5">
                <asp:TextBox ID="TextBox14" runat="server" Width="171px"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Date of birth</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="171px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label6" runat="server" Text="Parent's name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Width="171px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Parent&#39;s mob.no:</td>
            <td>
                <asp:TextBox ID="TextBox11" runat="server" Width="169px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Parent&#39;s email</td>
            <td class="style5">
                <asp:TextBox ID="TextBox13" runat="server" Width="167px"></asp:TextBox>
            </td>
            <td class="style5">
                </td>
            <td class="style5">
                </td>
            <td class="style5">
                </td>
            <td class="style6">
                </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label7" runat="server" Text="Mark percentage in +2"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label8" runat="server" Text="Mark percentage in 10th"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" Height="25px" Width="168px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label9" runat="server" Text="Year of admission"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server" Width="168px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label10" runat="server" Text="email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox12" runat="server" Width="173px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Height="95px" Width="176px" 
                    TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label5" runat="server" Text="Phone no:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="175px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
    </table>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" Text="Ok" 
        Width="82px" />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Next" 
        Width="87px" />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
