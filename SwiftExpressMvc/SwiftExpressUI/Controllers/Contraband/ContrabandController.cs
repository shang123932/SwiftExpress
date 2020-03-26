using ApiSDKClient.FApi.Request.Contraband;
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

        public ActionResult AddWaybillLnquiry()
        {
            return View();
        }
        /// <summary>
        /// 添加运单信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult AddWaybillLnquiry(AddWaybillLnquiryRequest request)
        {
            return Json(bll.AddWaybillLnquiry(request));
        }
        

    }
}