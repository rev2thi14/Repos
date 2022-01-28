using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DF
{
    public partial class HomeLoginPage : System.Web.UI.Page
    {
        void FillData()
        {
            SqlConnection con = new SqlConnection("Data Source=GANGAKRISHNA ;Initial Catalog=DiscussionForum;Integrated Security=True");
            SqlDataAdapter Da = new SqlDataAdapter("select * from post", con);
            DataSet ds = new DataSet();
            Da.Fill(ds, "post");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           if(IsPostBack==false)
            {
                FillData();
            }
        }
    }
}