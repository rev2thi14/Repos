﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialApplicationData;
namespace TutorialApplicatioEntity
{
    public class UserInfoBusiness
    {
        public string InsertUser(UserInfoModel userInfoModel)
        {
            UserInfoDataConnection userObj = new UserInfoDataConnection();
            string msg = userObj.InsertUser(userInfoModel);
            return msg;
        }
        public DataTable GetUserInfo()
        {
            UserInfoDataConnection userObj = new UserInfoDataConnection();
            DataTable dt = userObj.GetUserInfo();
            return dt;
        }
        public DataTable LoginCheck(string email, string password)
        {
            UserInfoDataConnection userObj = new UserInfoDataConnection();
            DataTable dt = userObj.LoginCheck(email, password);
            return dt;
        }
    }
}