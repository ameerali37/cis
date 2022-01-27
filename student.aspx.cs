using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select Max(regno)from student1", cn);
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            int b = a + 1;
            TextBox1.Text = b.ToString();
        }
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into student1 values(@regno,@name,@dept,@sem,@dob,@pn,@pm,@pe,@m2,@m10,@yoa,@email,@address,@phone)", cn);
        cmd.Parameters.AddWithValue("@regno", TextBox1.Text);
        cmd.Parameters.AddWithValue("@name", TextBox2.Text);
        cmd.Parameters.AddWithValue("@dept", TextBox3.Text);
        cmd.Parameters.AddWithValue("@sem", TextBox14.Text);
        cmd.Parameters.AddWithValue("@dob", TextBox6.Text);
        cmd.Parameters.AddWithValue("@pn", TextBox7.Text);
        cmd.Parameters.AddWithValue("@pm", TextBox11.Text);
        cmd.Parameters.AddWithValue("@pe", TextBox13.Text);
        cmd.Parameters.AddWithValue("@m2", TextBox8.Text);
        cmd.Parameters.AddWithValue("@m10", TextBox9.Text);
        cmd.Parameters.AddWithValue("@yoa", TextBox10.Text);
        cmd.Parameters.AddWithValue("@email", TextBox12.Text);


        cmd.Parameters.AddWithValue("@address", TextBox4.Text);
        cmd.Parameters.AddWithValue("@phone",TextBox5.Text);

        cn.Open();
        
        int status = cmd.ExecuteNonQuery();
        cn.Close();
        Response.Write("Registered successfully");
        
            
            
        


    }
    protected void Button2_Click(object sender, EventArgs e)
    {


        SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select Max(regno)from student1", cn);
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            int b = a + 1;
            TextBox1.Text = b.ToString();
       





        

    }
}
