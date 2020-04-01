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
        StaffBll bll = new StaffBll();
        // GET: Staff
        public ActionResult Index()
        {
            return View();
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
        //删除
        public ActionResult DelStafft()
        {
            return View();
        }
        [HttpPost]
        public JsonResult DelStaff(DelStaffRequest request)
        {
            return Json(bll.DelStaff(request));
        }
        public ActionResult UpdateStaff()
        {
            return View();
        }
        [HttpPost]
        public JsonResult UpdateStaff(UpdateStaffRequest request)
        {
            return Json(bll.UpdateStaff(request));
        }
    }
}