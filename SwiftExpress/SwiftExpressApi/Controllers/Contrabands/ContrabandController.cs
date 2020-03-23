using ApiSDKClient.FApi.Request.Contraband;
using ApiSDKClient.FApi.Response.Contraband;
using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwiftExpressApi.Controllers.Contrabands
{
    public class ContrabandController : ApiController
    {
        ContrabandBll bll = new ContrabandBll();
        /// <summary>
        /// 查询物品是否是违禁物品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        [HttpPost]
        public ContrabandResponse GetContrabands(ContrabandRequest name)
        {
            return bll.GetContrabands(name);

        }

        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        [HttpPost]
        public WaybillLnquiryResponse GetWaybillLnquiry(WaybillLnquiryRequest bh)
        {
            return bll.GetWaybillLnquiry(bh);
        }

        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public StorageResponse GetStorage()
        {
            return bll.GetStorage();
        }

    }
}
