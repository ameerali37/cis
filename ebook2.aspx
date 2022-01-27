<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ebook2.aspx.cs" Inherits="ebook2" %>

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
            width: 248px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div style="height: 375px"> 
        <table class="style1">
            <tr>
                <td class="style2">
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
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    image id&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="233px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    image name&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="239px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    imagedes&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="244px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    path&nbsp;</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
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
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Upload" 
                        Width="80px" />
                </td>
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
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <table>
        <tr>
        
               
       
        <%
        string[] files = System.IO.Directory.GetFiles(Server.MapPath("ebook"));
        for (int i = 0; i < files.Length; i++)
        {            
            string Path = files[i].Substring(files[i].LastIndexOf("\\")+1);
        
         %>  
         
         <td>
             <table class="style1">
                <tr>
                    <td>
    <div>
    
    </div>
    
                    </td>
                    
                    <td>
                    </td>
                    
                </tr>
                
                <tr>
                    <td>
                    <%
                    System.Data.SqlClient.SqlConnection cn=new System.Data.SqlClient.SqlConnection("Server=Localhost;Database=cis;integrated security=true");
            cn.Open();
            string desc = "imae";
            //System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("Select * from image where path='" + "Image / "+Path+"'", cn);
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("Select * from ebook ", cn);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)            
                desc = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                //Path = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
            
            %> 
                       <a href="<%Response.Write("ebook/"+Path); %>"> <img src="<%Response.Write("ebook/"+Path); %>" alt ="<%Response.Write(desc); %>"
                style="height: 100px; width: 100px" /></a></td>
                    
                </tr>
                
                 <tr>
                    <td>
                        <%Response.Write(Path); %> 
                    </td>                    
                </tr>
             </table>
         </td>
                    <%} %>  
                    
         </tr>
    </table>
            
        
    </div>
    </form>
</body>
</html>
