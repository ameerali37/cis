using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class student11 : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        string k = Session["image"].ToString();
        Image2.ImageUrl = "Image/" + k;
       

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
      
        

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string uname = Session["uname"].ToString();
        SqlCommand cmd = new SqlCommand("select * from stud3 where unm='" + uname + "'", cn);
        cn.Open();
        cmd.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        string a = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
        cn.Close();
        SqlCommand cmd1 = new SqlCommand("select * from syllabus where dept='" + a + "'", cn);
        cn.Open();
        cmd1.ExecuteNonQuery();
        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        string b = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
        Response.Redirect("syllabus1/" + b);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string uname = Session["uname"].ToString();
        SqlCommand cmd = new SqlCommand("select * from stud3 where unm='" + uname + "'", cn);
        cn.Open();
        cmd.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        string a = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
        cn.Close();
        SqlCommand cmd1 = new SqlCommand("select * from examdate where dept='" + a + "'", cn);
        cn.Open();
        cmd1.ExecuteNonQuery();
        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        string b = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
        Response.Redirect("examdate1/" + b);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }
}
