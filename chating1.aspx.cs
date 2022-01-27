using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class chating1 : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();
        string uname = Session["uname"].ToString();
        string regno = Session["regno"].ToString();

        SqlCommand cmd = new SqlCommand("update chat set status='1' where id='" + regno + "' and name='" + uname + "'", cn);
        cmd.ExecuteNonQuery();

        SqlCommand cmd1 = new SqlCommand("select id,name from chat where status='1' and id!='" + regno + "'", cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd1);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("select"))
        {
            Session["id"] = null;
            Session["name"] = null;
            int a = int.Parse(e.CommandArgument.ToString());
            Session["id"] = GridView1.Rows[a].Cells[1].Text;
            Session["name"] = GridView1.Rows[a].Cells[2].Text;


            SqlCommand cmd2 = new SqlCommand("insert into startchating values(@id,@name,@text1)", cn);
            cmd2.Parameters.AddWithValue("@id", Session["id"].ToString());
            cmd2.Parameters.AddWithValue("@name", Session["name"].ToString());
            cmd2.Parameters.AddWithValue("@text1", "");
            cmd2.ExecuteNonQuery();


            SqlDataAdapter daa = new SqlDataAdapter("select * from register where regno='" + Session["id"].ToString() + "'", cn);
            DataSet dss = new DataSet();
            daa.Fill(dss);
            string pqrs = dss.Tables[0].Rows[0].ItemArray.GetValue(7).ToString();
            Session["pqrs1"] = pqrs.ToString();

        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
