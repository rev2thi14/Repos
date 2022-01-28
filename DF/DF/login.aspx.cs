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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string loginuserid = txtuserid.Text;
            string loginpassword = txtpassword.Text;

            SqlConnection con = new SqlConnection("data source=GANGAKRISHNA;Initial catalog=DiscussionForum;Integrated security=true");

            string sql1 = "select *from  Registration where UserName='" + loginuserid + "'and Password='" + loginpassword + "' ";

            SqlDataAdapter adpt = new SqlDataAdapter(sql1, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);


        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");

        }
    }
}