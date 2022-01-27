using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class facultypassword : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string aa=TextBox1.Text;
        string bb=TextBox2.Text;
        string fname = Session["uname"].ToString();
        SqlDataAdapter da = new SqlDataAdapter("Select * from register", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            string dp = ds.Tables[0].Rows[i].ItemArray.GetValue(4).ToString();
            
            if (fname.Equals(dp) )
            {

                SqlCommand cmd = new SqlCommand("update register set psd='" + bb + "'where unm='" + fname + "'", cn);
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                int status = cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
       
        
        Response.Write("Password changed successfully");



    }
}
