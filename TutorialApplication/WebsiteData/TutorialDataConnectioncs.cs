using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TutorialApplicationEntity;

namespace TutorialApplicationData
{
    class TutorialDataConnectioncs
    {
        string sqlconnectionstr = "data source=LAPTOP-RSVLL0Q3\\SQLEXPRESS;initial catalog=csharp;integrated security=true";
        public string insertsqldbconnection(TutorialModel tutorialmodelobj)
        {
            SqlConnection sqlconnectionobj = new SqlConnection(sqlconnectionstr);
            SqlCommand sqlcommandobj = new SqlCommand("insert into csharpcouse values (" + tutorialmodelobj.TutorialId + ",'" + tutorialmodelobj.TutorialName + "'," + tutorialmodelobj.TutorialDesc+"'," + tutorialmodelobj.Published + ")", sqlconnectionobj);
            sqlconnectionobj.Open();
            sqlcommandobj.ExecuteNonQuery();
            sqlconnectionobj.Close();
            return " insert executed";
        }
        public DataTable selectsqldbconnection()
        {
            SqlConnection sqlconnectionobj = new SqlConnection(sqlconnectionstr);
            SqlCommand sqlcommandobj = new SqlCommand("select * from csharpcouse", sqlconnectionobj);
            sqlconnectionobj.Open();
            SqlDataReader sqldatareaderobj = sqlcommandobj.ExecuteReader();
            DataTable datatableobj = new DataTable();
            datatableobj.Load(sqldatareaderobj);
            sqlconnectionobj.Close();

            return datatableobj;
        }
        public string updatesqldbconnection(TutorialModel tutorialmodelobj)
        {

            SqlConnection sqlconnectionobj = new SqlConnection(sqlconnectionstr);
            SqlCommand sqlcommandobj = new SqlCommand("update csharpcouse set  tutorialName = '" + tutorialmodelobj.TutorialName + "',tutorialFess = " + tutorialmodelobj.TutorialFees + " ", sqlconnectionobj);
            sqlconnectionobj.Open();
            sqlcommandobj.ExecuteNonQuery();
            sqlconnectionobj.Close();
            return "update successfully";

        }
        public DataTable editsqldbconnection(int tutorialId)
        {
            SqlConnection sqlconnectionobj = new SqlConnection(sqlconnectionstr);
            SqlCommand sqlcommandobj = new SqlCommand("select * from csharpcouse where tutorialId=" + tutorialId + "", sqlconnectionobj);
            sqlconnectionobj.Open();
            SqlDataReader sqldatareaderobj = sqlcommandobj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqldatareaderobj);
            sqlconnectionobj.Close();

            return dt;

        }

        public string deletesqldbconnectionbyId(int tutorialId)
        {
            SqlConnection sqlconnectionobj = new SqlConnection(sqlconnectionstr);
            SqlCommand sqlcommandobj = new SqlCommand("delete from csharpcouse where  tutorialId = " + tutorialId + "", sqlconnectionobj);
            sqlconnectionobj.Open();
            sqlcommandobj.ExecuteNonQuery();
            sqlconnectionobj.Close();
            return "delete successfully";




        }
    }
}
    