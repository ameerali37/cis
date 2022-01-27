using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class studpersonalinfo : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    string ab;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] == null)
        {
            Response.Write("Login first");
            Response.Redirect("login.aspx");
        }
        else
        {

            string a = Session["uname"].ToString();
            con.Open();
            SqlCommand com = new SqlCommand("select * from stud3 where unm='" + a.ToString() + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                TextBox1.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                ab = TextBox1.Text;
                TextBox2.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                TextBox3.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                TextBox4.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
                TextBox5.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
                TextBox6.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
                TextBox7.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
                TextBox8.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(7).ToString();
                TextBox9.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                TextBox10.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(9).ToString();

            }
            con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
       // TextBox7.Text = "";
        //TextBox7.Text = "";
      /*  TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        TextBox3.Enabled = false;
        TextBox4.Enabled = false;
        TextBox5.Enabled = false;

        Button2.Visible = true;
        */
    }
   
    protected void Button2_Click1(object sender, EventArgs e)
    {
        string k = TextBox7.Text;
        string l = TextBox8.Text;
        SqlCommand cmd6 = new SqlCommand("update stud3 set address='" + k.ToString() + "' where regno='" + ab.ToString() + "'", con);
        con.Open();
        int st=cmd6.ExecuteNonQuery();
        if (st > 0)
        {
            con.Close();
        }
        else
        {
            Response.Write("not edited");
        }
        SqlCommand cmd7 = new SqlCommand("update stud3 set mobno='" + l.ToString() + "' where regno='" + ab.ToString() + "'", con);
        con.Open();
        cmd7.ExecuteNonQuery();

        con.Close();
        SqlCommand cmd8 = new SqlCommand("update stud3 set unm='" + TextBox9.Text + "' where regno='" + ab.ToString() + "'", con);
        con.Open();
        cmd8.ExecuteNonQuery();
        con.Close();
        SqlCommand cmd9 = new SqlCommand("update stud3 set pwd='" + TextBox10.Text + "' where regno='" + ab.ToString() + "'", con);
        con.Open();
        cmd9.ExecuteNonQuery();
        con.Close();
        Response.Write("Success");
       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox7.Text = "";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox8.Text = "";
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        TextBox9.Text = "";
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        TextBox10.Text = "";
    }
}