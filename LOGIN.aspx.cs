using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class LOGIN : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Session["uname"] = null;
        SqlDataAdapter da = new SqlDataAdapter("Select * from register", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);



        string pp = TextBox1.Text;
        string qq = TextBox2.Text;
        //string rr = "admin";
        //string ss = "admin";
        //if (pp.Equals(rr) && qq.Equals(ss))
        //{
        //    Response.Redirect("default.aspx");
        //}
        //else
        //{

            int i;
            int lm = 0;
            int ln = 0;
            int lp = 1;
            int ls = 2;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string dj = ds.Tables[0].Rows[i].ItemArray.GetValue(4).ToString();
                string db = ds.Tables[0].Rows[i].ItemArray.GetValue(5).ToString();
                string dc = ds.Tables[0].Rows[i].ItemArray.GetValue(6).ToString();
                int lq = int.Parse(dc);
                if (pp.Equals(dj) && qq.Equals(db) && lq.Equals(ls))
                {
                    Session["uname"] = null;
                    Session["pwd"] = null;
                    Session["uname"] = TextBox1.Text;
                    Session["pwd"] = TextBox2.Text;
                    Response.Redirect("default.aspx");
                }

                if (pp.Equals(dj) && qq.Equals(db) && lq.Equals(ln))
                {
                    lm = 1;
                    Session.Timeout = 60;
                  
                    Session["uname"] = null;
                    Session["pwd"] = null;
                    Session["uname"] = TextBox1.Text;
                    Session["pwd"] = TextBox2.Text;
                    SqlCommand cmd = new SqlCommand("select *from register where unm='" + Session["uname"].ToString() + "' and psd='" + Session["pwd"].ToString() + "'", cn);
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        Session["regno"] = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                        Session["image"] = ds1.Tables[0].Rows[0].ItemArray.GetValue(7).ToString();
                    }
                    cn.Open();
                    SqlCommand cmd6 = new SqlCommand("update chat set status='1' where id='" + Session["regno"].ToString() + "'", cn);
                    cmd6.ExecuteNonQuery();
                    cn.Close();
                    
                    Response.Redirect("student11.aspx");
                }
                if (pp.Equals(dj) && qq.Equals(db) && lq.Equals(lp))
                {

                    lm = 1;
                    
                    Session["uname"] = null;
                    Session["pwd"] = null;
                    Session["uname"] = TextBox1.Text;
                    Session["pwd"] = TextBox2.Text;
                    string uname = Session["uname"].ToString();
                    string pwd = Session["pwd"].ToString();
                    SqlCommand cmd2 = new SqlCommand("select * from register where unm='" + uname + "' and psd='" + pwd + "'", cn);
                    cn.Open();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);
                    if (ds2.Tables[0].Rows.Count > 0)
                    {
                        Session["regno"] = ds2.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    }
                    Response.Redirect("faculty11.aspx");
                }
            }
            if (lm == 0)
            {
                Response.Write(" Incorrect username or password. Click 'sign up' to create a new account");
            }
        }
    }
    

