using ApiSDKClient.FApi.Request.Staff;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwiftExpressUI
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        StaffBll bll = new StaffBll();
        /// <summary>
        /// 添加库房
        /// </summary>
        /// <returns></returns>
        public ActionResult ADDStaff()
        {
            return View();
        }
        [HttpPost]
        public JsonResult ADDStaff(ADDStaffRequest request)
        {
            return Json(bll.ADDStaff(request));
        }


        public ActionResult GetStaff()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetStaff(GetStaffRequest request)
        {
            return Json(bll.GetStaff(request));
        }
        /// <summary>
        /// 配送删除
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteDistribution(DelStaffRequest request)
        {
            return Json(bll.DelStaff(request));
        }
        [HttpPost]
        public JsonResult UpdateStaff(UpdateStaffRequest request)
        {
            return Json(bll.UpdateStaff(request));
        }
    }
}