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
    }
}