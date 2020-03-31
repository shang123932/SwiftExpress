using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiSDKClient.FApi.Request.WareHouse;
using BLL;

namespace SwiftExpressUI
{
    public class WareHouseController : Controller
    {
        WareHouseBll wbll = new WareHouseBll();
        // GET: WareHouse   zrx 2020年3月26日19:26:25
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 添加库房
        /// </summary>
        /// <returns></returns>
        public ActionResult wareHouseAdd()
        {
            return View();
        }
        [HttpPost]
        public JsonResult wareHouseAdd(WareHouseAddRequest request)
        {
            return Json(wbll.WareHouseAdd(request));
        }
        /// <summary>
        /// 删除库房
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult wareHouseDel(WareHouseDelRequest request)
        {
            return Json(wbll.WareHouseDel(request));
        }
       /// <summary>
       /// 显示库房
       /// </summary>
       /// <returns></returns>
        public ActionResult wareHouseShow()
        {
            return View();
        }
        [HttpPost]
        public JsonResult wareHouseShow(WareHouseGetRequest request)
        {
            return Json(wbll.WareHouseGet(request));
        }
        /// <summary>
        /// 修改页面
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public ActionResult wareHouseUpdate(int pid)
        {
            ViewBag.pid = pid;
            return View();
        }
        /// <summary>
        /// 获取一条数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult wareHouseGetOne(WareHouseGetOneRequest request)
        {
            return Json(wbll.WareHouseGetOne(request));
        }
        /// <summary>
        /// 保存修改
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult wareHouseUpdate(WareHouseUpdateRequest request)
        {
            return Json(wbll.WareHouseSave(request));
        }

    }
}