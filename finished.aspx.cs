using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class finished : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Server=Localhost;Database=cis;integrated security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        string s = Session["unm"].ToString();
        SqlDataAdapter da = new SqlDataAdapter("select * from onlineexamc where regno='"+s+"'", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Label1.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();

    }
}
