using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiSDKClient;

namespace SwiftExpressUI
{
    public class UserController : Controller
    {
        UserBll b = new UserBll();

        // GET: User
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <returns></returns>
        public ActionResult UserRegist()
        {
            return View();
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult UserRegist(UserRegisteredRequest request)
        {
            return Json(b.UserRegist(request));
        }


        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        public ActionResult UserLogin()
        {
            return View();
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult UserLogin(UserLoginRequest request)
        {

            return Json(b.UserLogin(request));
        }
        /// <summary>
        /// 登录页面验证码
        /// </summary>
        /// <returns></returns>
        public int Indexyanz(string yan)
        {
            int res = 0;
            string cnum = Session["CheckCode"].ToString();
            if (yan.ToLower() == cnum.ToLower())
            {
                res = 1;
                return res;
            }
            else
            {
                return res;
            }
        }
        /// <summary>
        /// 显示母版页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 后台模板页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Backstage()
        {
            return View();
        }


        /// <summary>
        /// 用户添加
        /// </summary>
        /// <returns></returns>
        public ActionResult AddDistribution1()
        {
            return View();
        }
        /// <summary>
        /// 配送添加
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult AddDistribution1(AddDistributionRequest request)
        {
            return Json(b.AddDistribution(request));
        }
        /// <summary>
        /// 配送显示页面
        /// </summary>
        /// <returns></returns> 
        public ActionResult GetDistribution11( )
        {
            return View();
        }
        /// <summary>
        /// 配送显示
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetDistribution11(DistributionRequestGet request)
        {

            return Json(b.GetDistribution(request));
        }   
        /// <summary>
        /// 配送查询
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetCxDistribution(GetCxDistributionRequest request)
        {
            return Json(b.GetCxDistribution(request));
        }

        /// <summary>
        /// 配送删除
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteDistribution(DeleteDistributionRequest request)
        {
            return Json(b.DeleteDistribution(request));
        }



    }
}