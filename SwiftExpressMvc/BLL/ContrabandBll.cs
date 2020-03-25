using ApiSDKClient.FApi.Request.Contraband;
using ApiSDKClient.FApi.Response.Contraband;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContrabandBll
    {
        #region  违禁品查询
        /// <summary>
        /// 违禁品查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ContrabandResponse GetContraband(ContrabandRequest request)
        {
            return ApiRequestHelper.Post<ContrabandRequest, ContrabandResponse>(request);
        }
        #endregion

        #region 运单
        /// <summary>
        /// 添加运单信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AddWaybillLnquiryResponse AddWaybillLnquiry(AddWaybillLnquiryRequest request)
        {
            return ApiRequestHelper.Post<AddWaybillLnquiryRequest, AddWaybillLnquiryResponse>(request);
        }

        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public GetWaybillLnquiryResponse GetWaybillLnquiry(GetWaybillLnquiryRequest bh)
        {
            return ApiRequestHelper.Post<GetWaybillLnquiryRequest, GetWaybillLnquiryResponse>(bh);
        }
        /// <summary>
        /// 运单删除
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        public DeleteWaybillLnquiryResponse DeleteWaybillLnquiry(DeleteWaybillLnquiryRequest request)
        {
            return ApiRequestHelper.Post<DeleteWaybillLnquiryRequest, DeleteWaybillLnquiryResponse>(request);
        }
        /// <summary>
        /// 修改运单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateWaybillLnquiryResponse UpdateWaybillLnquiry(UpdateWaybillLnquiryRequest request)
        {
            return ApiRequestHelper.Post<UpdateWaybillLnquiryRequest, UpdateWaybillLnquiryResponse>(request);

        }
        /// <summary>
        /// 获取单条数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //public GetOneWaybillLnquiryResponse GetOneWaybillLnquiry(GetOneWaybillLnquiryRequest request)
        //{
        //    GetOneWaybillLnquiryResponse response = new GetOneWaybillLnquiryResponse();
        //    var res = dal.GetOneWaybillLnquiry(request.id);

        //    return response;
        //}
        #endregion
    }
}
