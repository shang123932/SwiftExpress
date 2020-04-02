using ApiSDKClient;

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
        #region 违禁品
        /// <summary>
        /// 查询物品是否是违禁物品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        [HttpPost]
        public ContrabandResponse GetContrabands(ContrabandRequest request)
        {
            return bll.GetContrabands(request);
        }
        #endregion

        #region 运单一套
        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        [HttpPost]
        public GetWaybillLnquiryResponse GetWaybillLnquiry(GetWaybillLnquiryRequest bh)
        {
            return bll.GetWaybillLnquiry(bh);
        }

        /// <summary>
        /// 添加运单信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public AddWaybillLnquiryResponse AddWaybillLnquiry(AddWaybillLnquiryRequest request)
        {
            return bll.AddWaybillLnquiry(request);
        }

        /// <summary>
        /// 运单删除
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public DeleteWaybillLnquiryResponse DeleteWaybillLnquiry(DeleteWaybillLnquiryRequest request)
        {
            return bll.DeleteWaybillLnquiry(request);
        }
        /// <summary>
        /// 修改运单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public UpdateWaybillLnquiryResponse UpdateWaybillLnquiry(UpdateWaybillLnquiryRequest request)
        {
            return bll.UpdateWaybillLnquiry(request);
        }

        /// <summary>
        /// 获取单条运单数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public GetOneWaybillLnquiryResponse GetOneWaybillLnquiry(GetOneWaybillLnquiryRequest request)
        {
            return bll.GetOneWaybillLnquiry(request);
        }

        #endregion
        /// <summary>
        /// 运单查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public GetShippingInforResponse GetShippingInfor(GetShippingInforRequest request)
        {
            return bll.GetShippingInfor(request);
        }

        #region 存储一套
        /// <summary>
        /// 查询存储信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        [HttpPost]
        public GetStorageResponse GetStorage(/*GetStorageRequest request*/)
        {
            return bll.GetStorage(/*request*/);
        }
        /// <summary>
        /// 修改存储信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public UpdateStorageResponse UpdateStorage(UpdateStorageRequest request)
        {
            return bll.UpdateStorage(request);
        }
        /// <summary>
        /// 删除存储信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public DeleteStorageResponse DeleteStorage(DeleteStorageRequest request)
        {
            return bll.DeleteStorage(request);
        }

        /// <summary>
        /// 获取一条存储信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public GetOneStorageResponse GetOneStorage(GetOneStorageRequest request)
        {
            return bll.GetOneStorage(request);

        }

        public AddStorageResponse AddStorage(AddStorageRequest request)
        {
            return bll.AddStorage(request);
        }

        #endregion

    }
}
