<%@ Page Language="C#" AutoEventWireup="true" CodeFile="faculty11.aspx.cs" Inherits="faculty11" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        #Button1
        {
            width: 108px;
        }
        #Button3
        {
            width: 110px;
        }
        #Button4
        {
            width: 95px;
        }
        .style2
        {
            height: 27px;
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
            width: 100%;
        }
        .style4
        {
            width: 152px;
        }
        .style5
        {
            width: 102px;
        }
        .style6
        {
            width: 181px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        faculty1111</div>
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <table class="style1">
                    <tr>
                        <td class="style6">
                            <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="X-Large" 
                                PostBackUrl="~/studentdetails.aspx">Student Details</asp:LinkButton>
                        </td>
                        <td class="style4">
                            <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" 
                                PostBackUrl="~/facultypassword.aspx">Change password</asp:LinkButton>
                        </td>
                        <td class="style5">
                            <asp:LinkButton ID="LinkButton3" runat="server" Font-Size="Large" 
                                PostBackUrl="~/Entermarks.aspx">Enter marks</asp:LinkButton>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style4">
                            &nbsp;</td>
                        <td class="style5">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/chating1.aspx">Chating</asp:LinkButton>
                        </td>
                        <td class="style4">
                            <asp:HyperLink ID="HyperLink1" runat="server" 
                                NavigateUrl="~/facultyinfoaspx.aspx">Personal info</asp:HyperLink>
                        </td>
                        <td class="style5">
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/viewfeedback.aspx">view feedback</asp:HyperLink>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style4">
                            &nbsp;</td>
                        <td class="style5">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ebook2.aspx">library</asp:HyperLink>
                        </td>
                        <td class="style4">
                            &nbsp;</td>
                        <td class="style5">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
