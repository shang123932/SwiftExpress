using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiSDKClient.FApi.Request;
using ApiSDKClient.FApi.Request.Area;
using BLL;

namespace SwiftExpressUI
{
    public class AreaController : Controller
    {
        AreaBll abll = new AreaBll();
        // GET: Area
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Freight()
        {
            //AreaProvinceRequest pro = new AreaProvinceRequest();
            //ViewBag.prolist = Province(pro);
            //AreaCityRequest city = new AreaCityRequest();
            //ViewBag.citylist = City(city);

            return View();
        }
        [HttpPost]
        public JsonResult Province(AreaProvinceRequest request)
        {
            return Json(abll.GetProvince(request));
        }
        [HttpPost]
        public JsonResult City(AreaCityRequest request)
        {
            return Json(abll.GetCity(request));
        }
    }
}