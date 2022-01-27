<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Entermarks.aspx.cs" Inherits="Entermarks" %>

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
        }
        .style3
        {
            width: 266px;
        }
        .style4
        {
            height: 45px;
        }
        .style5
        {
            width: 266px;
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    semester no</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox22" runat="server" Width="198px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    department</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox23" runat="server" Width="196px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Exam id</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox24" runat="server" Width="199px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Exam name</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox25" runat="server" Width="197px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    subject name</td>
                <td class="style5">
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="57px" Width="191px">
                    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="style4">
                </td>
                <td class="style4">
                </td>
                <td class="style4">
                </td>
                <td class="style4">
                </td>
                <td class="style4">
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Exam date</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox27" runat="server" Width="147px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
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
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2" colspan="3">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        Height="130px" Width="205px">
                        <Columns>
                            <asp:BoundField DataField="regno" HeaderText="Register number" />
                            <asp:BoundField DataField="name" HeaderText="Name" />
                            <asp:TemplateField HeaderText="Mark">
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBox26" runat="server" Height="18px" Width="140px"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Ok" />
    </form>
</body>
</html>
