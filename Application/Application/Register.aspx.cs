using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApplicationBusiness;
using ApplicationEntity;

namespace Application
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            UserInfoModel userInfoModelObj = new UserInfoModel();
            UserInfoBusiness userInfoBusiness = new UserInfoBusiness();
            userInfoModelObj.Firstname = txtfname.Text;
            userInfoModelObj.Lastname = txtlname.Text;
            userInfoModelObj.Email = txtemail.Text;
            userInfoModelObj.Mobile = Convert.ToInt32(txtmobile.Text);
            userInfoModelObj.Password = txtpwd.Text;
            string msg = userInfoBusiness.InsertUser(userInfoModelObj);
            DataTable dtUserInfo = userInfoBusiness.GetUserInfo();
            gvUserInfo.DataSource = dtUserInfo;
            gvUserInfo.DataBind();
        }
    }
}