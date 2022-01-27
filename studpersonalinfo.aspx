<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studpersonalinfo.aspx.cs" Inherits="studpersonalinfo" %>

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
            width: 208px;
        }
    </style>
</head>
<body>
   
    <form id="form1" runat="server">
    <div>
    <table class="style1">
            <tr>
                <td class="style2">
                    Reg no</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Date of Birth</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Gender</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Branch</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    email</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Address</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Edit" 
                        Width="61px" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Mobile No</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Edit" 
                        Width="62px" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Username</td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Edit" 
                        Width="61px" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Password</td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    <asp:Button ID="Button6" runat="server" onclick="Button6_Click" Text="Edit" 
                        Width="61px" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Image</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Edit" onclick="Button1_Click" 
                        style="height: 26px" />
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click1" 
                        style="z-index: 1; left: 404px; top: 324px; position: absolute; width: 83px" 
                        Text="submit" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
