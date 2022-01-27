using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class subject : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into subject values(@sem,@dept,@subj)", cn);
        cmd.Parameters.AddWithValue("@sem", TextBox3.Text);
        cmd.Parameters.AddWithValue("@dept", TextBox1.Text);
        cmd.Parameters.AddWithValue("@subj", TextBox2.Text);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
        Response.Write("Registered successfully");
    }
}
