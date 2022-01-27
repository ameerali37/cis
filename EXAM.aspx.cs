using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class EXAM : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //SqlCommand cmd = new SqlCommand("insert into exam1 values(@test,@regno,@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@total,@percent)", cn);
        //cmd.Parameters.AddWithValue("@test", TextBox11.Text);
        //cmd.Parameters.AddWithValue("@regno", TextBox10.Text);
        //cmd.Parameters.AddWithValue("@a1", TextBox1.Text);
        //cmd.Parameters.AddWithValue("@a2", TextBox2.Text);

       // cmd.Parameters.AddWithValue("@a3", TextBox3.Text);
        //cmd.Parameters.AddWithValue("@a4", TextBox4.Text);
        //cmd.Parameters.AddWithValue("@a5", TextBox5.Text);
        //cmd.Parameters.AddWithValue("@a6", TextBox6.Text);
        //cmd.Parameters.AddWithValue("@a7", TextBox7.Text);
        //cmd.Parameters.AddWithValue("@a8", TextBox8.Text);
        //int c1 = int.Parse(TextBox1.Text);
        //int c2 = int.Parse(TextBox2.Text);
        //int c3 = int.Parse(TextBox3.Text);
        //int c4 = int.Parse(TextBox4.Text);
        //int c5 = int.Parse(TextBox5.Text);
        //int c6 = int.Parse(TextBox6.Text);
        //int c7 = int.Parse(TextBox7.Text);
        //int c8 = int.Parse(TextBox8.Text);
        //int c9 = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8;
        //int c10 = c9 / 800;
        //cmd.Parameters.AddWithValue("@total", c9);
        //cmd.Parameters.AddWithValue("@percent", c10);
       
        //cn.Open();
        //int status = cmd.ExecuteNonQuery();
        //cn.Close();
        //Response.Write("Registered successfully");


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into exam values(@id,@name,@sdate,@edate)", cn);
        cmd.Parameters.AddWithValue("@id", TextBox1.Text);
        cmd.Parameters.AddWithValue("@name", TextBox2.Text);
        cmd.Parameters.AddWithValue("@sdate", TextBox3.Text);
        cmd.Parameters.AddWithValue("@edate", TextBox4.Text);
        cn.Open();
        int status = cmd.ExecuteNonQuery();
        cn.Close();
        Response.Write("Registered successfully");



    }
}
