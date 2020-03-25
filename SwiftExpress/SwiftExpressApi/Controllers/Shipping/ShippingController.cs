using ApiSDKClient.FApi.Request.ShippingInfor;
using ApiSDKClient.FApi.Request.Staff;
using ApiSDKClient.FApi.Response.ShippingInfor;
using ApiSDKClient.FApi.Response.Staff;
using ApiSDKClient.ShippingInfor;
using BLL;
using BLL.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwiftExpressApi
{
    public class ShippingController : ApiController
    {
        StaffBll Sbl = new StaffBll();
        ShippingInforBll bll = new ShippingInforBll();
        [HttpPost]
        public GetShippingInforResonse GetShippingInfor()
        {
            return bll.GetShippingInfor();
        }
        [HttpPost]
        public ADDShippingInforResonse AddCargo(ADDShippingInforRequest request)
        {

            return bll.AddDistribution(request);
        }
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
        public UpdateStaffResponse UpdateStaff(UpdateStaffRequest request)
        {

            return Sbl.(request);
        }
    }
}

