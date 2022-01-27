using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class feedback1 : System.Web.UI.Page
{
    string b;

    SqlConnection con = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        string unm = Session["uname"].ToString();

        SqlCommand cmd = new SqlCommand("select * from stud3 where unm='" + unm + "'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        b = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
        SqlCommand cmd1 = new SqlCommand("select * from fac3 where dept='" + b.ToString() + "'", con);
        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
        DataSet ds1 = new DataSet();
       // DataTable dt = new DataTable();
        
        
       da1.Fill(ds1,"fac3");
       int p = ds1.Tables[0].Rows.Count;
       for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
       
        {

           string ss = ds1.Tables[0].Rows[i].ItemArray.GetValue(1).ToString();
           DropDownList1.Items.Add(ss);
           
       }
      
        //GridView1.DataSource = ds1;
        //GridView1.DataBind();
       


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       string name= DropDownList1.SelectedItem.ToString();
       string feedback = TextBox1.Text;
       SqlCommand cmd1 = new SqlCommand("insert into feedback values (@name,@dept,@feedback)", con);
       cmd1.Parameters.AddWithValue("@name", name);
       cmd1.Parameters.AddWithValue("@dept", b);
            cmd1.Parameters.AddWithValue("@feedback",feedback);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
    }
}