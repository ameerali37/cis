using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class onlineexamc : System.Web.UI.Page
{
    int i = 0;
    string s;
    string p;
    int n;
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        string s1 = Session["uname"].ToString();
        SqlDataAdapter da1 = new SqlDataAdapter("select * from register where unm='" + s1 + "'", cn);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        string ab = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
        SqlDataAdapter da2 = new SqlDataAdapter("select * from student1 where regno='" + ab + "'", cn);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        string ac = ds2.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
        string ad = ds2.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
        string ae = ds2.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
        TextBox1.Text = ab;
        TextBox2.Text = ac;
        TextBox3.Text = ad;
        TextBox4.Text = ae;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string k = Session["uname"].ToString();
        SqlDataAdapter da = new SqlDataAdapter("select * from register where unm='" + k + "'", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        string kk = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
        
        cn.Open();

        SqlCommand cmd = new SqlCommand("select count(*) from onlineexamc where regno='" + kk + "' and examid='" + TextBox5.Text + "'", cn);
        int a = Convert.ToInt32(cmd.ExecuteScalar());
        cn.Close();
        
       
        if (a > 0)
        {
            Response.Write("not possible");
        }
        else
        {


            Session["exid"] = TextBox5.Text;
            string bb=Session["exid"].ToString();
            string reg = TextBox1.Text;
            Session["unm"] = TextBox1.Text;
            string name = TextBox2.Text;

            string sem = TextBox3.Text;
            Session["a1"] = TextBox3.Text;

            string dept = TextBox4.Text;
            Session["a2"] = TextBox4.Text;
            SqlCommand cmd1 = new SqlCommand("insert into onlineexamc values(@regno,@name,@sem,@dept,@mark,@examid)", cn);
            cmd1.Parameters.AddWithValue("@regno", reg);
            cmd1.Parameters.AddWithValue("@name", name);
            cmd1.Parameters.AddWithValue("@sem", sem);
            cmd1.Parameters.AddWithValue("@dept", dept);
            cmd1.Parameters.AddWithValue("@mark", 0);
            cmd1.Parameters.AddWithValue("@examid", bb);
            cn.Open();
            cmd1.ExecuteNonQuery();
            cn.Close();
            Session["eid"] = null;
            Response.Redirect("onlineexam1.aspx");
            //if (i < 10)
            //{

            //}
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {


        ////if (RadioButton1.Checked == true)
        ////{
        ////    s = RadioButton1.Text;
        ////}
        ////else if (RadioButton2.Checked == true)
        ////{
        ////    s = RadioButton2.Text;
        ////}
        ////else if (RadioButton3.Checked == true)
        ////{
        ////    s = RadioButton3.Text;
        ////}
        ////else if (RadioButton4.Checked == true)
        ////{
        ////    s = RadioButton4.Text;
        ////}
        ////SqlDataAdapter da1 = new SqlDataAdapter("select * from onlineexam", cn);
        ////DataSet ds1 = new DataSet();
        ////da1.Fill(ds1);
        ////p = ds1.Tables[0].Rows[i].ItemArray.GetValue(8).ToString();

        ////if (s.Equals(p))
        ////{

        ////    SqlCommand cmd = new SqlCommand("update onlineexamc set mark=mark+1 where regno='" + TextBox1.Text + "'", cn);
        ////    cn.Open();
        ////    cmd.ExecuteNonQuery();
        ////    cn.Close();
        ////    i++;
        ////}
        ////else
        ////{

        ////    i++;
        ////}

        ////    if (i < 10)
        ////    {
        ////        SqlDataAdapter da = new SqlDataAdapter("select * from onlineexam", cn);
        ////        DataSet ds = new DataSet();
        ////        da.Fill(ds);
        ////        TextBox5.Text = i.ToString();
        ////        Label1.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(3).ToString();
        ////        RadioButton1.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(4).ToString();
        ////        RadioButton2.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(5).ToString();
        ////        RadioButton3.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(6).ToString();
        ////        RadioButton4.Text = ds.Tables[0].Rows[i].ItemArray.GetValue(7).ToString();

        ////        //Session["n"] =Convert.ToInt32(i+1);
        ////    }
        ////}
        //else
        //{
        //    int x = i+1;
        //    //int a = Convert.ToInt32(Session["n"].ToString());
        //    int b = x+1;
        //    if(b<10)
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("select * from onlineexam", cn);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds);
        //        TextBox5.Text = b.ToString();
        //        Label1.Text = ds.Tables[0].Rows[b].ItemArray.GetValue(3).ToString();
        //        RadioButton1.Text = ds.Tables[0].Rows[b].ItemArray.GetValue(4).ToString();
        //        RadioButton2.Text = ds.Tables[0].Rows[b].ItemArray.GetValue(5).ToString();
        //        RadioButton3.Text = ds.Tables[0].Rows[b].ItemArray.GetValue(6).ToString();
        //        RadioButton4.Text = ds.Tables[0].Rows[b].ItemArray.GetValue(7).ToString();

        //        Session["n"] = b;
        //    }

        //}
    }


}