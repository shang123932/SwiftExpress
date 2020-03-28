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
        public DelStaffResponse DelCargo(DelStaffRequest request)
        {
            return Sbl.DelStaff(request);
        }
        /// <summary>
        /// 显示仓库
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public GetStaffResponse GetCargo()
        {
            return Sbl.GetStaff();
        }
        /// <summary>
        /// 添加仓库   zrx  2020年3月24日14:43:15
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public ADDStaffResponse AddCargo(ADDStaffRequest request)
        {

            return Sbl.ADDStaff(request);
        }
        //public UpdateStaffResponse UpdateStaff(UpdateStaffRequest request)
        //{

        //    return Sbl.(request);
        //}
        [HttpPost]
        public UpdateStaffResponse UpdateStaff(UpdateStaffRequest info)
        {
            return Sbl.UpdateStaff(info);
        }
    }
}
