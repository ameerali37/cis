using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class facultyinfoaspx : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    string ab;
    protected void Page_Load(object sender, EventArgs e)
    {
        string a = Session["uname"].ToString();
        con.Open();
        SqlCommand com = new SqlCommand("select * from fac3 where unm='" + a.ToString() + "'", con);

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
            TextBox11.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(10).ToString();


        }
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        TextBox3.Enabled = false;   
        TextBox4.Enabled = false;
        TextBox5.Enabled = false;

        //Button2.Visible = true;

    }
   
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd6 = new SqlCommand("update fac3 set address='" + TextBox6.Text + "' where id='" + ab + "'", con);
        con.Open();
        cmd6.ExecuteNonQuery();
       
        SqlCommand cmd7 = new SqlCommand("update fac3 set email='" + TextBox7.Text + "' where id='" + ab + "'", con);
        
        
        cmd7.ExecuteNonQuery();

        
        SqlCommand cmd8 = new SqlCommand("update fac3 set subj='" + TextBox8.Text + "' where id='" + ab + "'", con);
        
        cmd8.ExecuteNonQuery();
        
        SqlCommand cmd9 = new SqlCommand("update fac3 set mobno='" + TextBox9.Text + "' where id='" + ab + "'", con);
        
        cmd9.ExecuteNonQuery();
        
        SqlCommand cmd10 = new SqlCommand("update fac3 set unm='" + TextBox10.Text + "' where id='" + ab + "'", con);
        
        cmd10.ExecuteNonQuery();
        
        SqlCommand cmd11 = new SqlCommand("update fac3 set pwd='" + TextBox11.Text + "' where id='" + ab + "'", con);
        
        cmd11.ExecuteNonQuery();
        con.Close();
        //Response.Write("Success");
       
    }
    
}