using ApiSDKClient.FApi.Request.Staff;
using ApiSDKClient.FApi.Response.Staff;
using BLL.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwiftExpressApi.Controllers.Staff
{
    public class StaffController : ApiController
    {
        StaffBll Sbl = new StaffBll();
        [HttpPost]
        public DelStaffResponse DelStaff(DelStaffRequest request)
        {
            return Sbl.DelStaff(request);
        }
        /// <summary>
        /// 显示仓库
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public GetStaffResponse GetStaff()
        {
            return Sbl.GetStaff();
        }
        /// <summary>
        /// 添加员工   zrx  2020年3月24日14:43:15
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public ADDStaffResponse AddStaff(ADDStaffRequest request)
        {

            return Sbl.AddStaff(request);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public UpdateStaffPwdResponse UpdateStaffPwd(UpdateStaffPwdRequest request)
        {
            return Sbl.UpdateStaffPwd(request);
        }
        //public UpdateStaffResponse UpdateStaff(UpdateStaffRequest request)
        //{

        //    return Sbl.(request);
        //}
        //[HttpPost]
        //public UpdateStaffResponse UpdateStaff(UpdateStaffRequest info)
        //{
        //    return Sbl.UpdateStaff(info);
        //}
    }
}
