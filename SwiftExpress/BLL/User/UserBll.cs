﻿using ApiSDKClient;

using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class UserBll
    {
        UserDal d = new UserDal();
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public UserLoginResponse UserLogin(UserLoginRequest userlogin)
        {
            UserLoginResponse response = new UserLoginResponse();
            UserModel userModel = new UserModel() {
                 UserPhone=userlogin.Phone,
                  PassWord=userlogin.Pwd
            };
            var res = d.UserLogin(userModel);
            if (res>0)
            {
                response.IsRegistSuccess = true;
            }
            else
            {
                response.Status = false;
                response.Message = "登录失败";
            }
            return response;
        }


        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public UserRegisteredResponse UserRegistered(UserRegisteredRequest  userRegistered)
        {
            UserRegisteredResponse response = new UserRegisteredResponse();
            UserModel userModel = new UserModel()
            {
                UserPhone = userRegistered.Phone,
                PassWord = userRegistered.Pwd
            };
            var res = d.UserRegistered(userModel);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
            }
            else
            {
                response.Status = false;
                response.Message = "注册失败";
            }
            return response;
        }

    }
}
