﻿using ApiSDKClient;
using ApiSDKClient.FApi.Request;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwiftExpressUI
{
    public class ContrabandController : Controller
    {
        ContrabandBll bll = new ContrabandBll();
        // GET: Contraband
        #region
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
        public JsonResult GetContraband(ContrabandRequest request)
        {
            return Json(bll.GetContraband(request));
        }
        #endregion

        #region 运单的显示列表

        public JsonResult GetWaybillLnquiry(GetWaybillLnquiryRequest request)
        {
            return Json(bll.GetWaybillLnquiry(request));
        }

        #endregion

        #region  存储信息
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

    }
}