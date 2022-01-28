using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApplicationBusiness;


namespace Application
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserInfoBusiness userInfoBusiness = new UserInfoBusiness();
            System.Data.DataTable dtLogin = userInfoBusiness.LoginCheck(txtemail.Text, txtpwd.Text);
            if (dtLogin.Rows.Count > 0)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblResult.Text = "Email id or password wrong!";
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}