using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class examdate : System.Web.UI.Page
{

    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FileUpload1.PostedFile.SaveAs(Server.MapPath("examdate1/" + FileUpload1.FileName));
        SqlCommand cmd = new SqlCommand("insert into examdate values(@dept,@path)", cn);
        cmd.Parameters.AddWithValue("@dept", TextBox1.Text);

        cmd.Parameters.AddWithValue("@path", FileUpload1.FileName);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }
}