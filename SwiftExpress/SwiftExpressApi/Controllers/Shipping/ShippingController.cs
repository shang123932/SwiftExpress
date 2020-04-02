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
        public ADDShippingInforResonse AddCargo1(ADDShippingInforRequest request)
        {

            return bll.ADD(request);
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
        /// 添加寄件   zrx  2020年3月24日14:43:15
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public ADDShippingInforResonse ShippingAdd(ADDShippingInforRequest request)
        {

            return bll.ADD(request);
        }
        //public UpdateStaffResponse UpdateStaff(UpdateStaffRequest request)
        //{

        //    return Sbl.(request);
        //}
    }
}

