<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="gallery" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
    <div style="height: 375px"> 
       
        <table>
        <tr>
        
               
       
        <%
        string[] files = System.IO.Directory.GetFiles(Server.MapPath("Image"));
        for (int i = 0; i < files.Length; i++)
        {            
            string Path = files[i].Substring(files[i].LastIndexOf("\\")+1);
        
         %>  
         
         <td>
             <table class="style1">
                <tr>
                    <td>
                    <%
                    System.Data.SqlClient.SqlConnection cn=new System.Data.SqlClient.SqlConnection("Server=Localhost;Database=cis;integrated security=true");
            cn.Open();
            string desc = "imae";
            //System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("Select * from image where path='" + "Image / "+Path+"'", cn);
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("Select * from image ", cn);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)            
                desc = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                //Path = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
            
            %> 
                       <a href="<%Response.Write("Image/"+Path); %>"> <img src="<%Response.Write("Image/"+Path); %>" alt ="<%Response.Write(desc); %>"
                style="height: 155px; width: 160px" /></a></td>
                    
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
