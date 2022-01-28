using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TutorialApplicationEntity;
namespace TutorialApplicationData
{
    public class UserInfoDataConnection
    {
        string sqlConnectionStr = "Data Source=W10JQQGN13;Initial Catalog=TutorialDB;Integrated Security=True";
        public string InsertUser(UserInfoModel userInfoModel)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into userinfo values('" + userInfoModel.Firstname + "','" + userInfoModel.Lastname + "','" + userInfoModel.Email + "'," + userInfoModel.Mobile + ",'" + userInfoModel.Password + "')", sqlConnectionObj);
            adp.Fill(dt);
            return "Registerd successfully";
        }
        public DataTable GetUserInfo()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from userinfo", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }

        public DataTable LoginCheck(string email, string password)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select firstname,lastname,email,mobile from userinfo where email='" + email + "' and pwd='" + password + "'", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
    }
}
