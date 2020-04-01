using ApiSDKClient;
using ApiSDKClient.FApi.Request;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
namespace SwiftExpressUI
{
    public class ContrabandController : Controller
    {
        ContrabandBll bll = new ContrabandBll();
        // GET: Contraband
        #region  违禁品
        public ActionResult GetContraband()
        {
            return View();
        }
        /// <summary>
        /// 违禁品查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetContrabands()
        {
            ContrabandRequest request = new ContrabandRequest();
            var ss = Request["ItemName"];
            if (ss == null)
            {
                request.ItemName = "";
            }
            else
            {
                request.ItemName = ss;
            }
            return Json(bll.GetContrabands(request));
        }
        #endregion

        #region 运单的显示列表

        public JsonResult GetWaybillLnquiry(GetWaybillLnquiryRequest request)
        {
            return Json(bll.GetWaybillLnquiry(request));
        }

        #endregion

        #region  存储信息

        #region 存储信息列表
        /// <summary>
        /// 存储信息列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult GetStorage()
        {
            return View();
        }
        /// <summary>
        /// 存储信息显示
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetStorage(GetStorageRequest request)
        {
            return Json(bll.GetStorage(request));
        }
        #endregion

        #region 存储信息添加
        /// <summary>
        /// 存储信息添加页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AddStorage()
        {
            return View();
        }
        /// <summary>
        /// 存储信息添加
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult AddStorage(AddStorageRequest request)
        {
            return Json(bll.AddStorage(request));
        }
        #endregion

        /// <summary>
        /// 删除存储信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteStorage(DeleteStorageRequest request)
        {
            var Id = Request["id"];
            request.id = Convert.ToInt32(Id);
            return Json(bll.DeleteStorage(request));
        }

        public ActionResult UpdateStorageSt()
        {
            var arr = Request.Url.ToString().Split('/');
            ViewBag.Id = arr[arr.Length - 1];
            return View();
        }
        /// <summary>
        /// 获取单条信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult GetOneStorage()
        {
            GetStorageRequest request = new GetStorageRequest();
            GetOneStorageRequest request1 = new GetOneStorageRequest();
            var uid = Request["Id"];
            var list = (bll.GetStorage(request)).Storagelist;
            var Id = Convert.ToInt32(uid);
            list = list.Where(s => s.StorageId == Id).ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 修改存储信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult Update()
        {
            var datas = Request["data"];
            UpdateStorageRequest request =JsonConvert.DeserializeObject<UpdateStorageRequest>(datas.ToString());
            return Json(bll.UpdateStorage(request), JsonRequestBehavior.AllowGet);
        }

        #endregion

    }
}