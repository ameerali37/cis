using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Entermarks : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string a = TextBox22.Text;
        string b = TextBox23.Text;
        SqlDataAdapter da = new SqlDataAdapter("select regno,name from student1 where sem='" + a + "' and dept='" + b + "'", cn);
        DataSet ds=new DataSet ();
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

        SqlDataAdapter dd = new SqlDataAdapter("select subj from subject where sem='"+a+"' and dept='"+b+"'", cn);
        DataSet dm = new DataSet();
        dd.Fill(dm);
        DropDownList1.DataSource = dm;
        DropDownList1.DataTextField = "subj";
        DropDownList1.DataBind();


        //TextBox5.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
        //TextBox6.Text = ds.Tables[0].Rows[1].ItemArray.GetValue(2).ToString();
        //TextBox7.Text = ds.Tables[0].Rows[2].ItemArray.GetValue(2).ToString();
        //TextBox8.Text = ds.Tables[0].Rows[3].ItemArray.GetValue(2).ToString();
        //TextBox9.Text = ds.Tables[0].Rows[4].ItemArray.GetValue(2).ToString();
        //TextBox10.Text = ds.Tables[0].Rows[5].ItemArray.GetValue(2).ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        { 
            SqlCommand cmd = new SqlCommand("insert into exam1 values(@exid,@exname,@sem,@dept,@date,@regno,@mark,@subjname)", cn);
            cmd.Parameters.AddWithValue("@exid", TextBox24.Text);
            cmd.Parameters.AddWithValue("@exname", TextBox25.Text);
            cmd.Parameters.AddWithValue("@sem", TextBox22.Text);
            cmd.Parameters.AddWithValue("@dept", TextBox23.Text);
            cmd.Parameters.AddWithValue("@date", TextBox27.Text);

            TextBox txt = (TextBox)GridView1.Rows[i].FindControl("TextBox26");
            string mark = txt.Text;

            cmd.Parameters.AddWithValue("@regno", GridView1.Rows[i].Cells[0].Text);
            cmd.Parameters.AddWithValue("@mark", mark);   
            cmd.Parameters.AddWithValue("@subjname",DropDownList1.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
