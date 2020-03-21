using ApiSDKClient;
using ApiSDKClient.FApi.Request.Contraband;
using ApiSDKClient.FApi.Response.Contraband;
using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public WaybillLnquiryResponse GetWaybillLnquiry(WaybillLnquiryRequest bh)
        {
            WaybillLnquiryResponse response = new WaybillLnquiryResponse();
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
        public StorageResponse GetStorage()
        {
            StorageResponse response = new StorageResponse();

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
    }
}
