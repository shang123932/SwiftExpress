using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using ApiSDKClient.FApi.Request.Staff;

namespace SwiftExpressUI
{
    public class StaffController : Controller
    {
        StaffBll b = new StaffBll();
            
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 添加员工
        /// </summary>
        /// <returns></returns>
        public ActionResult AddStaff1()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddStaff1(ADDStaffRequest request)
        {
            return Json(b.ADDStaff(request));
        }
    

    }
}