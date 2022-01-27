using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class register : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FileUpload2.PostedFile.SaveAs(Server.MapPath("Image/" + FileUpload2.FileName));
        SqlCommand cmd = new SqlCommand("insert into register values(@regno,@name,@age,@dept,@unm,@psd,@role,@image)", cn);
        cmd.Parameters.AddWithValue("@regno", TextBox1.Text);
        cmd.Parameters.AddWithValue("@name", TextBox2.Text);
        cmd.Parameters.AddWithValue("@age", TextBox6.Text);
        cmd.Parameters.AddWithValue("@dept", TextBox3.Text);

        cmd.Parameters.AddWithValue("@unm", TextBox4.Text);
        cmd.Parameters.AddWithValue("@psd", TextBox5.Text);
        cmd.Parameters.AddWithValue("@image", FileUpload2.FileName);
        SqlCommand cmd6 = new SqlCommand("insert into chat values(@id,@name,@status)", cn);
        cmd6.Parameters.AddWithValue("@id", TextBox1.Text);
        cmd6.Parameters.AddWithValue("@name", TextBox2.Text);
        cmd6.Parameters.AddWithValue("@status", '0');
        string f = TextBox4.Text;
        SqlCommand ff = new SqlCommand("select * from register where unm='" + TextBox1.Text + "'", cn);
        cn.Open();
        int gg = Convert.ToInt32(ff.ExecuteScalar());
        cn.Close();
        if (gg > 0)
        {
            Response.Write("User name already exist");
        }
        else
        {
            string b = TextBox1.Text;

            SqlCommand dd = new SqlCommand("select * from register where regno='" + TextBox1.Text + "'", cn);
            cn.Open();
            int c = Convert.ToInt32(dd.ExecuteScalar());
            cn.Close();
            if (c > 0)
            {
                Response.Write("Already Registered");
            }
            else
            {

                SqlCommand da = new SqlCommand("select * from student1 where regno='" + TextBox1.Text + "'", cn);

                cn.Open();
                int a = Convert.ToInt32(da.ExecuteScalar());
                cn.Close();
                if (a > 0)
                {
                    cn.Open();
                    cmd.Parameters.AddWithValue("@role", 0);

                    int status = cmd.ExecuteNonQuery();
                    cmd6.ExecuteNonQuery();
                    cn.Close();
                    Response.Write("Registered successfully");
                }
                else
                {

                    SqlCommand db = new SqlCommand("select * from faculty where id='" + TextBox1.Text + "'", cn);

                    cn.Open();
                    int d = Convert.ToInt32(db.ExecuteScalar());
                    cn.Close();
                    if (d > 0)
                    {
                        cn.Open();
                        cmd.Parameters.AddWithValue("@role", 1);
                        int status = cmd.ExecuteNonQuery();
                        cn.Close();
                        Response.Write("Registered successfully");
                    }
                    else
                    {
                        Response.Write("No such user....");
                    }


                }
            }


        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        

       
    }
}
