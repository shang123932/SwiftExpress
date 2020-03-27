using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        public ActionResult cargoAdd()
        {
            return View();
        }
        [HttpPost]
        public JsonResult cargoAdd(ADDShippingInforRequest request)
        {
            return Json(bll(request));
        }

      
        /// <summary>
        /// 显示库房
        /// </summary>
        /// <returns></returns>
        public ActionResult cargoShow()
        {
            return View();
        }
        [HttpPost]
        public JsonResult cargoShow(CargoGetRequest request)
        {
            return Json(cbll.CargoGet(request));
        }
    }
}