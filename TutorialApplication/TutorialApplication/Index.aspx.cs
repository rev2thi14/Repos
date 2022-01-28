using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorialApplication.DataConnection;
using System.Data;

namespace TutorialApplication
{
    public partial class index : System.Web.UI.Page
    {
        private object txtTutorialId;
        private readonly object txtTutorialName;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            TutorialDbConnection tutorialDbConnectionObj = new TutorialDbConnection();
            TutorialModel tutorialModel = new TutorialModel();

            tutorialModel.TutorialId = Convert.ToInt32(txtTutorialId.Text);
            tutorialModel.TutorialName = txtTutorialName.Text;
            tutorialModel.TutorialDesc = txtTutorialDesc.Text;
            

            string msg = tutorialDBConnectionObj.InsertTutorial(tutorialModel);
            lblResult.Text = msg;

            DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
            gvTutorialDetails.DataSource = dtResult;
            gvTutorialDetails.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}