using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class onlineexam1 : System.Web.UI.Page
{
    
    string p;
    int eid ;


    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
           

            Load();
        }
        if (Session["chk"] == null)
        {
            
        }
        else
        {
            Button2_Click(this, EventArgs.Empty);
        }
        

    }
    

            
  
    protected void Button2_Click(object sender, EventArgs e)
    {

        string s = "";

        Session["chk"] = null;
        
        string j = "";
        if (Session["exid"] != null)
        {
            j = Session["exid"].ToString();
        }
        else
        {
            Response.Write("Session not Found");
        }
        string k = "";
        if (Session["a1"] != null)
        {
            k = Session["a1"].ToString();
        }
        else
        {
            Response.Write("Session not found");
        }
        string l = "";

        if (Session["a2"] != null)
        {
            l = Session["a2"].ToString();
        }

        else
        {
            Response.Write("Session not found");
        }

        if (RadioButton1.Checked == true)
        {
            s = RadioButton1.Text;
        }
        else if (RadioButton2.Checked == true)
        {
            s = RadioButton2.Text;
        }
        else if (RadioButton3.Checked == true)
        {
            s = RadioButton3.Text;
        }
        else if (RadioButton4.Checked == true)
        {
            s = RadioButton4.Text;
        }
        SqlDataAdapter da1 = new SqlDataAdapter("select * from onlineexam where examid='" + j + "' and sem='" + k + "' and dept='" + l + "' and answer='"+s+"'", cn);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        

        if (ds1.Tables[0].Rows.Count > 0)
        {
            string gg = Session["unm"].ToString();
            int jkl = int.Parse(gg);

            SqlCommand cmd = new SqlCommand("update onlineexamc set mark=mark+1 where regno='" + jkl + "'", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        
    
   
    Clear();




    //if (Session["eid"] != null)
    //{
    //    Session["eid"] =int.Parse( eid.ToString());
    //    //Session["eid"] = int.Parse(Session["eid"].ToString()) + 1;
    //}
    //else { Session["eid"] = 0; }

       
    }
    public void Load()
    {
        string j = "";
        if (Session["exid"] != null)
        {
            j = Session["exid"].ToString();
        }
        else
        {
            Response.Write("Session not Found");
        }
        string k = "";
        if (Session["a1"] != null)
        {
            k = Session["a1"].ToString();
        }
        else
        {
            Response.Write("Session not found");
        }
        string l = "";

        if (Session["a2"] != null)
        {
            l = Session["a2"].ToString();
        }

        else
        {
            Response.Write("Session not found");
        }

        SqlDataAdapter da = new SqlDataAdapter("select * from onlineexam where examid='" + j + "' and sem='" + k + "' and dept='" + l + "'", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        string jj = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
        int j1 = int.Parse(jj);
        //Session["eid"] = 1;

        if (Session["eid"] != null)
        {
            eid = int.Parse(Session["eid"].ToString()) + 1;
            Session["eid"] = eid;
        }
        else
        {
            Session["eid"] = 0;
            eid = int.Parse(Session["eid"].ToString());
        }
        if (eid < j1)
        {


            Label2.Text = (eid + 1).ToString();

            Label1.Text = ds.Tables[0].Rows[eid].ItemArray.GetValue(5).ToString();
            RadioButton1.Text = ds.Tables[0].Rows[eid].ItemArray.GetValue(6).ToString();
            RadioButton2.Text = ds.Tables[0].Rows[eid].ItemArray.GetValue(7).ToString();
            RadioButton3.Text = ds.Tables[0].Rows[eid].ItemArray.GetValue(8).ToString();
            RadioButton4.Text = ds.Tables[0].Rows[eid].ItemArray.GetValue(9).ToString();


        }
        //Session["chk"] = "123";
        else
        {
            Response.Redirect("finished.aspx");
        }
    }
    public void Clear()
    {
        Load();
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;
    }
}
