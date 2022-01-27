using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class uploadimage : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        //FileUpload1.PostedFile.SaveAs(Server.MapPath(FileUpload1.FileName));

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FileUpload1.PostedFile.SaveAs(Server.MapPath("Image/"+FileUpload1.FileName));
        SqlCommand cmd = new SqlCommand("insert into image values(@imageid,@imagename,@imagedes,@path)", cn);
        cmd.Parameters.AddWithValue("@imageid", TextBox1.Text);
        cmd.Parameters.AddWithValue("@imagename", TextBox2.Text);
        cmd.Parameters.AddWithValue("@imagedes", TextBox3.Text);
        cmd.Parameters.AddWithValue("@path", FileUpload1.FileName);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();

    }
}
