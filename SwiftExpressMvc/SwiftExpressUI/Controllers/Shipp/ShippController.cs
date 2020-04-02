using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiSDKClient.FApi.Request.ShippingInfor;
using ApiSDKClient.ShippingInfor;
using BLL;
namespace SwiftExpressUI
{
    public class ShippController : Controller
    {
        // GET: Shipp
        public ActionResult Index()
        {
            return View();
        }
        ShippingInforBll bll = new ShippingInforBll();
        /// <summary>
        /// 添加库房
        /// </summary>
        /// <returns></returns>
        public ActionResult ADDShippingInfor1()
        {
            return View();
        }
        [HttpPost]
        public JsonResult ADDShippingInfor1(ADDShippingInforRequest request)
        {
            return Json(bll.ADDShippingInfor(request));
        }

      
        /// <summary>
        /// 显示库房
        /// </summary>
        /// <returns></returns>
        public ActionResult GetShippingInfor()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetShippingInfor(ShippingInforRequest request)
        {
            return Json(bll.GetShippingInfor(request));
        }
    }
}