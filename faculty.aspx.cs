using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class faculty : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into faculty values(@id,@name,@qual,@doj,@address,@phone,@email,@ng,@ag,@hs)", cn);
        cmd.Parameters.AddWithValue("@id", TextBox1.Text);
        cmd.Parameters.AddWithValue("@name", TextBox2.Text);
        cmd.Parameters.AddWithValue("@qual", TextBox3.Text);

        cmd.Parameters.AddWithValue("@doj", TextBox4.Text);
        cmd.Parameters.AddWithValue("@address", TextBox5.Text);
        cmd.Parameters.AddWithValue("@phone", TextBox6.Text);
        cmd.Parameters.AddWithValue("@email", TextBox7.Text);
        cmd.Parameters.AddWithValue("@ng", TextBox8.Text);
        cmd.Parameters.AddWithValue("@ag", TextBox10.Text);
        cmd.Parameters.AddWithValue("hs", TextBox9.Text);
            
        cn.Open();
        int status = cmd.ExecuteNonQuery();
        cn.Close();
        Response.Write("Registered successfully");
        


    }
}
