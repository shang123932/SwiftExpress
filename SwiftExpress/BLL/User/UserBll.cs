﻿using ApiSDKClient;
using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using ApiSDKClient.FApi.Request.ShippingInfor;
using ApiSDKClient.FApi.Response.ShippingInfor;
using System.Security.Cryptography;
using MODEL.Staff;

namespace BLL
{
   public class UserBll
    {
        UserDal d = new UserDal();
        DistributionDal dl = new DistributionDal();
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public UserLoginResponse UserLogin(UserLoginRequest userlogin)
        {
            UserLoginResponse response = new UserLoginResponse();
            UserModel userModel = new UserModel() {
                  UserName=userlogin.UserName,
                    PassWord=userlogin.Pwd
            };
            if (userlogin == null || userlogin.UserName == null)
            {
                response.Status = false;
                response.Message = "用户不能为空";
                return response;
            }
            if (userlogin == null || userlogin.Pwd == null)
            {
                response.Status = false;
                response.Message = "密码不能为空";
                return response;
            }
            var res = d.UserLogin(userModel);
            if (res>0)
            {
                response.IsRegistSuccess = true;
                response.UserName = userlogin.UserName;
                response.Message = "登录成功";
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
            var pass = Md5jiam.MD5Encrypt32(userRegistered.Pwd);
            UserModel userModel = new UserModel()
            {
                UserName=userRegistered.UserName,//用户名
                UserPhone = userRegistered.Phone,//手机号
                PassWord = userRegistered.Pwd,//密码
                PassJmi=pass,
                UserMailbox ="16096533",//邮箱
      
            };
            if (userRegistered == null || userRegistered.Phone == null)
            {
                response.Status = false;
                response.Message = "用户名不能为空";
                return response;
            }
            if (userRegistered == null || userRegistered.Phone==null)
            {
                response.Status = false;
                response.Message = "手机号不能为空";
                return response;
            }
            if (userRegistered == null || userRegistered.Pwd==null)
            {
                response.Status = false;
                response.Message = "密码不能为空";
                return response;
            }
            if (userRegistered.Pwd!=userRegistered.Pwd1)
            {
                response.Status = false;
                response.Message = "密码不一致";
                return response;
            }
            var res = d.UserRegistered(userModel);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "注册成功";
            }
            else
            {
                response.Status = false;
                response.Message = "注册失败";
            }
            return response;
        }

     
        /// <summary>
        /// 寄件
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public ADDShippingInforResonse AddShipp(ADDShippingInforRequest userRegistered)
        {
            ADDShippingInforResonse response = new ADDShippingInforResonse();
    
            ShippingInforModel userModel = new ShippingInforModel()
            {
               ShippingOrder=userRegistered.ShippingOrder1,
               ShippingName= userRegistered.ShippingName1,
               ShippingPhone= userRegistered.ShippingPhone1,
               ShippingAddress= userRegistered.ShippingAddress1,
               ReceiveName= userRegistered.ReceiveName1,
               ReceivePhone= userRegistered.ReceivePhone1,
               ReceiveAddress= userRegistered.ReceiveAddress1,
               ShippingRemark= userRegistered.ShippingRemark1

            };

            var res = dl.AddShipp(userModel);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
                response.Message = "寄件成功";
            }
            else
            {
                response.Status = false;
                response.Message = "寄件失败";
            }
            return response;
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="userlogin"></param>
        /// <returns></returns>
        public AdminLoginResponse AdminLogin(AdminLoginRequest request)
        {
            AdminLoginResponse response = new AdminLoginResponse();
            StaffModel smodel = new StaffModel()
            {
                 StaffName = request.AdminName,
                 StaffPhone = request.AdminPhone,
                  StaffPwd= request.AdminPwd
            };
            //if (request == null || request.AdminName == null)
            //{
            //    response.Status = false;
            //    response.Message = "用户不能为空";
            //    return response;
            //}
            //if (request == null || request.AdminPwd == null)
            //{
            //    response.Status = false;
            //    response.Message = "密码不能为空";
            //    return response;
            //}
            var res = d.Administrator(smodel);
            if (!string.IsNullOrEmpty(res))
            {
                response.IsRegistSuccess = true;
                response.Aname= res;
                response.Message = "登录成功";
            }
            else
            {
                response.Status = false;
                response.Message = "登录失败";
            }
            return response;
        }
    }
}
