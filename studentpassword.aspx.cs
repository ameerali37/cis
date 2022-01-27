using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class studentpassword : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        string fname = Session["uname"].ToString();
        
        SqlCommand cmd = new SqlCommand("update register set psd='"+TextBox2.Text+"' where unm='"+fname+"'",cn);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
        Response.Write("Password changed successfully");

            

    }
}
