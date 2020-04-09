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
        /// 管理员登录
        /// </summary>
        /// <returns></returns>
        /// 

        [HttpPost]
        public JsonResult AdminLogin(AdminLoginRequest request)
        {
            return Json(b.AdminLogin(request));
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

        /// <summary>
        /// 显示仓库下拉
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult wareHouseBll(WareHouseBllRequest request)
        {
            return Json(b.wareHouseBll(request));
        }

        /// <summary>
        /// 传值
        /// </summary>
        /// <returns></returns> 
        [HttpPost]
        public void Cookie()
        {
            //实例化
            HttpCookie http = new HttpCookie("cookie");
            string name =HttpUtility.UrlEncode(Request["SS"]);//接受data并加密
            http.Value=name;//赋值
            Response.Cookies.Add(http);  
        }
        /// <summary>
        /// 传值
        /// </summary>
        /// <returns></returns> 
        [HttpPost]
        public JsonResult Cookieqest()
        {
            //接受cookie
            HttpCookie http = System.Web.HttpContext.Current.Request.Cookies["cookie"];
            var name = HttpUtility.UrlDecode(http.Value);//解密
            var arr = name.ToString().Split('"');
            name = arr[arr.Length -2];
            return Json(new {name1=name },JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 用户管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Lay()
        {
            return View();
        }
        //生成卡号

        [HttpPost]
        public ActionResult VIPKaHao()

        {

            //声明一个变量为空

            var aa = "";

            //随机数生成器

            Random bb = new Random();

            //指定1000-10000的4位随机数

            string cc = bb.Next(1000, 10000).ToString();

            //获取当前时间分秒值，或“ffff”毫秒值

            string dd = DateTime.Now.ToString("mmss");

            //拼接字符串

            aa = "YUY" + dd + cc;

            return Json(aa, JsonRequestBehavior.AllowGet);

        }

       
    }
}