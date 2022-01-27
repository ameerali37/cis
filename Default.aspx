<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        #Button1
        {
            width: 108px;
        }
        #Button2
        {
            width: 106px;
        }
        #Button3
        {
            width: 110px;
        }
        #Button4
        {
            width: 95px;
        }
        #Button5
        {
            width: 196px;
        }
        #Button6
        {
            width: 169px;
        }
        .style1
        {
            width: 99%;
        }
        .style3
        {
            width: 160px;
        }
        .style4
        {
            height: 27px;
            width: 160px;
        }
        .style5
        {
            width: 131px;
        }
        .style6
        {
            height: 27px;
            width: 131px;
        }
        .style7
        {
            width: 105px;
        }
        .style8
        {
            height: 27px;
            width: 105px;
        }
        .style9
        {
            width: 126px;
        }
        .style10
        {
            height: 27px;
            width: 126px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="158px" 
            ImageUrl="~/Image/nature26.jpg" Width="928px" />
    
    </div>
    <table class="style1">
        <tr>
            <td class="style3">
                <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/Default.aspx">Home</asp:LinkButton>
            </td>
            <td class="style5">
                <asp:LinkButton ID="LinkButton6" runat="server" PostBackUrl="~/student.aspx">Add student</asp:LinkButton>
            </td>
            <td class="style7">
                <asp:LinkButton ID="LinkButton7" runat="server" PostBackUrl="~/faculty.aspx">Add faculty</asp:LinkButton>
            </td>
            <td class="style9">
                <asp:LinkButton ID="LinkButton8" runat="server" PostBackUrl="~/Addevent.aspx">Add new Event</asp:LinkButton>
            </td>
            <td>
                <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/gallery.aspx" 
                    onclick="LinkButton2_Click">Online exam</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/subject.aspx">Add subjects</asp:LinkButton>
            </td>
            <td class="style6">
                <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/EXAM.aspx">Add exam</asp:LinkButton>
            </td>
            <td class="style8">
                <asp:LinkButton ID="LinkButton4" runat="server" 
                    PostBackUrl="~/uploadimage.aspx" onclick="LinkButton4_Click">Upload image</asp:LinkButton>
            </td>
            <td class="style10">
                <asp:LinkButton ID="LinkButton9" runat="server" 
                    PostBackUrl="~/adminpassword.aspx">Change Password</asp:LinkButton>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
                    Text="upload ebook" />
            </td>
            <td class="style5">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="view ebook" />
            </td>
            <td class="style7">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/syllabus.aspx">syllabus</asp:HyperLink>
            </td>
            <td class="style9">
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/examdate.aspx">exam date</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
