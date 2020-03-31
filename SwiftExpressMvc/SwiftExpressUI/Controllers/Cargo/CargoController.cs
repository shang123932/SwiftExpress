using ApiSDKClient.FApi.Request.Cargo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace SwiftExpressUI.Controllers.Cargo
{
    public class CargoController : Controller
    {
        CargoBll cbll = new CargoBll();

        // GET: Cargo
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 添加库房
        /// </summary>
        /// <returns></returns>
        public ActionResult cargoAdd()
        {
            return View();
        }
        [HttpPost]
        public JsonResult cargoAdd(CargoAddRequest request)
        {
            return Json(cbll.CargoAdd(request));
        }
        /// <summary>
        /// 删除库房
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult cargoDel(CargoDelRequest request)
        {
            return Json(cbll.CargoDel(request));
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

        /// <summary>
        /// 修改页面
        /// </summary>
        /// <returns></returns>
        public ActionResult cargoUpdate(int pid)
        {
            ViewBag.pid = pid;
            return View();
        }
        /// <summary>
        /// 获取一条
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult cargoGetOne(CargoGetOneRequest request)
        {
            return Json(cbll.CargoGetOne(request));
        }
        /// <summary>
        /// 保存修改
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult cargoUpdate(CargoUpdateRequest request)
        {
            return Json(cbll.CargoSave(request));
        }


    }
}