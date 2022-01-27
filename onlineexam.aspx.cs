using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class onlineexam : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("select Max(qid)from onlineexam", cn);
            int a = Convert.ToInt32(cmd1.ExecuteScalar());
            int b = a + 1;
            TextBox1.Text = b.ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into onlineexam values(@examid,@noq,@sem,@dept,@qid,@qname,@op1,@op2,@op3,@op4,@answer)", cn);
        cmd.Parameters.AddWithValue("@examid", TextBox10.Text);
        cmd.Parameters.AddWithValue("@noq", TextBox11.Text);
        cmd.Parameters.AddWithValue("@sem", TextBox8.Text);
        cmd.Parameters.AddWithValue("@dept", TextBox9.Text);
        cmd.Parameters.AddWithValue("@qid", TextBox1.Text);
        cmd.Parameters.AddWithValue("@qname", TextBox2.Text);
        cmd.Parameters.AddWithValue("@op1", TextBox3.Text);
        cmd.Parameters.AddWithValue("@op2", TextBox4.Text);
        cmd.Parameters.AddWithValue("@op3", TextBox5.Text);
        cmd.Parameters.AddWithValue("@op4", TextBox6.Text);
        cmd.Parameters.AddWithValue("@answer", TextBox7.Text);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
        Response.Write("Registered successfully");


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
            SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("select Max(qid)from onlineexam", cn);
            int a = Convert.ToInt32(cmd1.ExecuteScalar());
            int b = a + 1;
            TextBox1.Text = b.ToString();
        
    }
}
