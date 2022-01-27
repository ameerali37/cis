using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class facdetails : System.Web.UI.Page
{

    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();
        string unm = Session["uname"].ToString();

        SqlCommand cmd = new SqlCommand("select * from stud3 where unm='" + unm + "'", cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        string b = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
        SqlCommand cmd1 = new SqlCommand("select  name,dept as branch,subj as subject from fac3 where dept='" + b + "'", cn);
        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        GridView1.DataSource = ds1;
        GridView1.DataBind();
        cn.Close();
    }
}