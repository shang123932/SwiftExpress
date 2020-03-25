
using ApiSDKClient.FApi.Request.Contraband;
using ApiSDKClient.FApi.Response.Contraband;
using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSDKClient;
namespace BLL
{
   public class ContrabandBll
    {
        ContrabandDal dal = new ContrabandDal();
        /// <summary>
        /// 查询物品是否是违禁物品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public ContrabandResponse GetContrabands(ContrabandRequest name)
        {
            ContrabandResponse response = new ContrabandResponse();
            var gname = name.ItemName;
            var list= dal.GetContrabands(gname);
            if (list.Count<=0)
            {
                response.Status = false;
                response.Message = "查询失败";
            }
            else
            {
                response.Message = "成功";
            }
            return response;

        }

        

        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public GetWaybillLnquiryResponse GetWaybillLnquiry(GetWaybillLnquiryRequest bh)
        {
            GetWaybillLnquiryResponse response = new GetWaybillLnquiryResponse();
            var number = bh.TrackingNumber;
            var list = dal.GetWaybillLnquiry(number);
            if (list.Count<=0)
            {
                response.Status = false;
                response.Message = "查询失败";
            }
            else
            {
                response.Message = "成功";
            }
            return response;
        }

        /// <summary>
        /// 查询运单号查看信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dh"></param>
        /// <returns></returns>
        public GetStorageResponse GetStorage()
        {
            GetStorageResponse response = new GetStorageResponse();

            var list = dal.GetStorage();
            if (list.Count<=0)
            {
                response.Status = false;
                response.Message = "获取用户信息失败,请检查一下在弄";
            }
            else
            {
                response.Message = "获取信息成功";
            }
            return response;
        }

        /// <summary>
        /// 添加运单信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AddWaybillLnquiryResponse AddWaybillLnquiryResponse(AddWaybillLnquiryRequest request)
        {
            AddWaybillLnquiryResponse response = new AddWaybillLnquiryResponse();
            if (request==null||!string.IsNullOrEmpty(request.FreightTotal.ToString()))
            {
                response.Status = false;
                response.Message = "运费不能为空呀";
                return response;
            }
            if (request == null )
            {
                response.Status = false;
                response.Message = "快递时间不能为空呀";
                return response;
            }
            if (request == null || !string.IsNullOrEmpty(request.TrackingDetails))
            {
                response.Status = false;
                response.Message = "快递详情不能为空呀";
                return response;
            }
            if (request == null )
            {
                response.Status = false;
                response.Message = "物品状态不能为空呀";
                return response;
            }

            WaybillLnquiry waybill = new WaybillLnquiry()
            {
                FreightTotal = request.FreightTotal,
                TrackingDate = request.TrackingDate,
                TrackingDetails = request.TrackingDetails,
                TrackingState = request.TrackingState
            };
            var res = dal.AddWaybillLnquiry(waybill);
            if (res>0)
            {
                response.IsRegistSuccess = true;
                response.Message = "添加成功";
            }
            else
            {
                response.Message = "添加失败";
            }
            return response;
        }


    }
}
