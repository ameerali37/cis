using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class viewfeedback : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        string fname = Session["uname"].ToString();
        //Response.Write(fname);
        cn.Open();
        SqlCommand cmd = new SqlCommand("select * from fac3 where unm='" + fname + "'", cn);
        //cn.Open();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);


        string facname = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

        cn.Close();
        //Response.Write(dep);
        cn.Open();
        SqlDataAdapter da1 = new SqlDataAdapter("select * from feedback where facname='" + facname + "'", cn);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        GridView1.DataSource = ds1;
        GridView1.DataBind();

        cn.Close();
    }
}