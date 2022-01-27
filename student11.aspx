<%@ Page Language="C#" AutoEventWireup="true" CodeFile="student11.aspx.cs" Inherits="student11" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 100%;
        }
        
        #Button1
        {
            width: 108px;
        }
        #Button3
        {
            width: 110px;
            z-index: 1;
            left: 168px;
            top: 244px;
            position: absolute;
        }
        #Button4
        {
            width: 95px;
            z-index: 1;
            left: 299px;
            top: 280px;
            position: absolute;
        }
        .style2
        {
            height: 27px;
            width: 460px;
        }
        #Button5
        {
            width: 196px;
        }
        #Button6
        {
            width: 169px;
        }
        .style3
        {
            width: 460px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        student1111</div>
    <asp:Image ID="Image1" runat="server" Height="140px" 
        ImageUrl="~/Image/DEO6.jpg" Width="930px" />
    <table class="style1">
        <tr>
            <td class="style3">
                <asp:Button ID="Button1" runat="server" 
                    PostBackUrl="~/Default.aspx" Text="Home" Width="200px" />
                <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="XX-Large" 
                    PostBackUrl="~/studentpassword.aspx">Change password</asp:LinkButton>
                <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Logout" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:LinkButton ID="LinkButton2" runat="server" Font-Size="X-Large" 
                    PostBackUrl="~/onlineexamc.aspx" onclick="LinkButton2_Click">Online Examination</asp:LinkButton>
            </td>
            <td>
                <asp:LinkButton ID="LinkButton5" runat="server" 
                    PostBackUrl="~/changeimage.aspx">Change image</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/ebook2.aspx">library</asp:HyperLink>
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                    Text="view syllabus" />  
                    
            </td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" 
                    NavigateUrl="~/studpersonalinfo.aspx">studentinfo</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/chating1.aspx">Chating</asp:LinkButton>
                <asp:Button ID="Button4" runat="server" Text="view examdate" 
                    onclick="Button4_Click" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Image ID="Image2" runat="server" Height="87px" Width="163px" />
                <asp:Button ID="Button2" runat="server" 
                    style="z-index: 1; left: 610px; top: 243px; position: absolute" 
                    Text="Syllabus" />
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/facdetails.aspx" 
                    style="z-index: 1; left: 745px; top: 247px; position: absolute; width: 119px">Faculty Details</asp:HyperLink>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/feedback1.aspx" 
                    style="z-index: 1; left: 479px; top: 317px; position: absolute">feedback</asp:HyperLink>
            </td>
        </tr>
    </table>
&nbsp;&nbsp;&nbsp;&nbsp;
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
