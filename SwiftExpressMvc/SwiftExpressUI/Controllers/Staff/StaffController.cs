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
        public ActionResult GetStaff1()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetStaff1(GetStaffRequest request)
        {
            return Json(b.GetStaff(request));
        }
        /// <summary>
        /// 显示员工
        /// </summary>
        /// <returns></returns>
        //public ActionResult DelStaff2()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public JsonResult DelStaff2(GetStaffRequest request)
        //{
        //    return Json(b.GetStaff1(request));
        //}
        public ActionResult UpdateStaffPwd()
        {
            return View();
        }
        [HttpPost]
        public JsonResult UpdateStaffPwd(UpdateStaffPwdRequest request)
        {
            return Json(b.UpdateStaffPwd(request));
        }
        /// <summary>
        /// 显示员工
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowStaff()
        {
            return View();
        }
        [HttpPost]
        public JsonResult ShowStaff(GetStaffRequest request)
        {
            return Json(b.GetStaff(request));
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DelStaff5(DelStaffRequest request)
        {
            return Json(b.DelStaff(request));
        }


    }
}