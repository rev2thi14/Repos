using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialApplication;
using TutorialApplication.DataConnection;

namespace TutorialApplicationData
{
    public class TurtorialDataConnection
    {
        string sqlConnectionStr = "Data Source=W10JQQGN13;Initial Catalog=TutorialDB;Integrated Security=True";
        public string InsertTutorial(TutorialModel tutorialModelObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            #region connectecd approach
            //SqlCommand sqlCommandObj = new SqlCommand("insert into Tutorial values("+tutorialModelObj.TutorialId+",'"+tutorialModelObj.TutorialName+"','"+tutorialModelObj.TutorialDesc+"',"+tutorialModelObj.Published+")", sqlConnectionObj);
            //sqlConnectionObj.Open();
            //sqlCommandObj.ExecuteNonQuery();
            //sqlConnectionObj.Close();
            #endregion

            #region disconnected approach
            SqlDataAdapter adp = new SqlDataAdapter("insert into Tutorial values(" + tutorialModelObj.TutorialId + ",'" + tutorialModelObj.TutorialName + "','" + tutorialModelObj.TutorialDesc + "'," + tutorialModelObj.Published + ")", sqlConnectionObj);
            adp.Fill(dt);
            #endregion
            return "Tutorial details saved successfully";
        }
        public string UpdateTutorial(TutorialModel tutorialModelObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            //SqlCommand sqlCommandObj = new SqlCommand("update Tutorial set tutorialname='" + tutorialModelObj.TutorialName + "' , tutorialdesc='" + tutorialModelObj.TutorialDesc + "' , published=" + tutorialModelObj.Published + " where tutorialid=" + tutorialModelObj.TutorialId + "", sqlConnectionObj);
            //sqlConnectionObj.Open();
            //sqlCommandObj.ExecuteNonQuery();
            //sqlConnectionObj.Close();
            #region disconnected approach
            SqlDataAdapter adp = new SqlDataAdapter("update Tutorial set tutorialname='" + tutorialModelObj.TutorialName + "' , tutorialdesc='" + tutorialModelObj.TutorialDesc + "' , published=" + tutorialModelObj.Published + " where tutorialid=" + tutorialModelObj.TutorialId + "", sqlConnectionObj);
            adp.Fill(dt);
            #endregion
            return "Tutorial id " + tutorialModelObj.TutorialId + " details updated successfully";
        }
        public string DeleteTutorialById(int tutorialId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("delete from Tutorial where tutorialid=" + tutorialId + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Tutorial id " + tutorialId + " details deleted successfully";
        }
        public DataTable SelectTutorial()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            #region connected approach
            //SqlCommand sqlCommandObj = new SqlCommand("select * from Tutorial", sqlConnectionObj);
            //sqlConnectionObj.Open();
            //SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(sqlDataReader);
            //sqlConnectionObj.Close();
            #endregion
            #region disconnected approach
            SqlDataAdapter adp = new SqlDataAdapter("select * from Tutorial", sqlConnectionObj);
            adp.Fill(dt);
            #endregion
            return dt;
        }
        public DataTable EditTutorialById(int tutorialId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Tutorial where tutorialid=" + tutorialId + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
    }
}