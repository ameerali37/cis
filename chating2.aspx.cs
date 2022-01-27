using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class chating2 : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
   

    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();   

        FillGrid();
        Label2.Text = Session["uname"].ToString();
        string pqrs2 = Session["pqrs1"].ToString();
        Image2.ImageUrl = "Image/" + pqrs2;

    }
    public void FillGrid()
    {
        try
        {
            //string id1 = Session["id"].ToString();
            //string name1 = Session["name"].ToString();
            string id = Session["id"].ToString();
            string name = Session["name"].ToString();

            SqlCommand cmd = new SqlCommand("select  * from startchating where id='" + id + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        catch
        {
            Response.Write("No User");
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("select"))
        {
            int a = int.Parse(e.CommandArgument.ToString());
            Session["id1"] = GridView1.Rows[a].Cells[1].Text;
            Session["name1"] = GridView1.Rows[a].Cells[2].Text;
           
        }
    }
    protected void Submitt_Click(object sender, EventArgs e)
    {
        //SqlCommand cmd2 = new SqlCommand("select * from startchating where id!='" + Session["id"].ToString() + "' and name!='" + Session["name"].ToString() + "'", cn);
        //SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
        //DataSet ds2 = new DataSet();
        //da2.Fill(ds2);
        //if (ds2.Tables[0].Rows.Count > 0)
        //{
        //    Session["toid"] = ds2.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
        //    Session["toname"] = ds2.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
        //}
        //SqlCommand cmd1 = new SqlCommand("update startchating set text1='" + TextBox1.Text + "' where id='" + Session["toid"].ToString() + "' and name='" + Session["toname"].ToString() + "'", cn);
        //cmd1.ExecuteNonQuery();

        //FillGrid();
        //TextBox1.Text = "";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        try
        {
            //SqlCommand cmd2 = new SqlCommand("select * from startchating where id!='" + Session["id"].ToString() + "' and name!='" + Session["name"].ToString() + "'", cn);
            //SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            //DataSet ds2 = new DataSet();
            //da2.Fill(ds2);
            //if (ds2.Tables[0].Rows.Count > 0)
            //{
            //    Session["toid"] = ds2.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            //    Session["toname"] = ds2.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
            //}
            SqlCommand cmd3 = new SqlCommand("update chat set status='0' where id='" + Session["regno"].ToString() + "'", cn);
            cn.Open();
            cmd3.ExecuteNonQuery();
            cn.Close();
            Response.Redirect("LOGIN.aspx");
        }
        catch
        {
            
            Response.Write("No user");
        }
    }
    protected void Submitt_Click1(object sender, EventArgs e)
    {        
        //SqlCommand cmd2 = new SqlCommand("select * from chat where id!='" + Session["id"].ToString() + "' and name!='" + Session["name"].ToString() + "' and status='1'", cn);
        //SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
        //DataSet ds2 = new DataSet();
        //da2.Fill(ds2);
        //if (ds2.Tables[0].Rows.Count > 0)
        //{
        //    string id = ds2.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
        //    string name = ds2.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();

        //    Session["toid"] = ds2.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
        //    Session["toname"] = ds2.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
        //}
        SqlCommand cmd1 = new SqlCommand("update startchating set text1='" + TextBox1.Text + "' where id='" + Session["regno"].ToString() + "'", cn);
        cmd1.ExecuteNonQuery();

        FillGrid();
        TextBox1.Text = "";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd3 = new SqlCommand("update chat set status='0' where id='" + Session["regno"].ToString() + "'", cn);
        
        cmd3.ExecuteNonQuery();
        SqlCommand cmd4 = new SqlCommand("delete from startchating where id='" + Session["regno"].ToString() + "'", cn);

        cmd4.ExecuteNonQuery();
        
        Response.Redirect("LOGIN.aspx");
    }
}
